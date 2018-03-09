using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using T2P._2015.Cross.Enum;

namespace T2P._2015.Cross.Utility.FileType
{
    public class gmseDeskew
    {
        // Representation of a line in the image.
        public class HougLine
        {
            // Count of points in the line.
            public int Count;

            // Index in Matrix.
            public int Index;

            // The line is represented as all x,y that solve y*cos(alpha)-x*sin(alpha)=d
            public double Alpha;

            public double d;
        }

        // The Bitmap
        private Bitmap cBmp;

        // The range of angles to search for lines
        private double cAlphaStart = -20;

        private double cAlphaStep = 0.2;
        private int cSteps = 40 * 5;

        // Precalculation of sin and cos.
        private double[] cSinA;

        private double[] cCosA;

        // Range of d
        private double cDMin;

        private double cDStep = 1;
        private int cDCount;
        // Count of points that fit in a line.

        private int[] cHMatrix;

        // Calculate the skew angle of the image cBmp.
        public double GetSkewAngle()
        {
            gmseDeskew.HougLine[] hl = null;
            int i = 0;
            double sum = 0;
            int count = 0;

            // Hough Transformation
            Calc();
            // Top 20 of the detected lines in the image.
            hl = GetTop(20);
            // Average angle of the lines
            for (i = 0; i <= 19; i++)
            {
                sum += hl[i].Alpha;
                count += 1;
            }
            return sum / count;
        }

        // Calculate the Count lines in the image with most points.
        private HougLine[] GetTop(int Count)
        {
            HougLine[] hl = null;
            int i = 0;
            int j = 0;
            HougLine tmp = null;
            int AlphaIndex = 0;
            int dIndex = 0;

            hl = new HougLine[Count + 1];
            for (i = 0; i <= Count - 1; i++)
            {
                hl[i] = new HougLine();
            }
            for (i = 0; i <= cHMatrix.Length - 1; i++)
            {
                if (cHMatrix[i] > hl[Count - 1].Count)
                {
                    hl[Count - 1].Count = cHMatrix[i];
                    hl[Count - 1].Index = i;
                    j = Count - 1;
                    while (j > 0 && hl[j].Count > hl[j - 1].Count)
                    {
                        tmp = hl[j];
                        hl[j] = hl[j - 1];
                        hl[j - 1] = tmp;
                        j -= 1;
                    }
                }
            }
            for (i = 0; i <= Count - 1; i++)
            {
                dIndex = hl[i].Index / cSteps;
                AlphaIndex = hl[i].Index - dIndex * cSteps;
                hl[i].Alpha = GetAlpha(AlphaIndex);
                hl[i].d = dIndex + cDMin;
            }
            return hl;
        }

        public gmseDeskew(Bitmap bmp)
        {
            cBmp = bmp;
        }

        // Hough Transforamtion:
        private void Calc()
        {
            int x = 0;
            int y = 0;
            int hMin = cBmp.Height / 4;
            int hMax = cBmp.Height * 3 / 4;

            Init();
            for (y = hMin; y <= hMax; y++)
            {
                for (x = 1; x <= cBmp.Width - 2; x++)
                {
                    // Only lower edges are considered.
                    if (IsBlack(x, y))
                    {
                        if (!IsBlack(x, y + 1))
                        {
                            Calc(x, y);
                        }
                    }
                }
            }
        }

        // Calculate all lines through the point (x,y).
        private void Calc(int x, int y)
        {
            int alpha = 0;
            double d = 0;
            int dIndex = 0;
            int Index = 0;

            for (alpha = 0; alpha <= cSteps - 1; alpha++)
            {
                d = y * cCosA[alpha] - x * cSinA[alpha];
                dIndex = CalcDIndex(d);
                Index = dIndex * cSteps + alpha;
                try
                {
                    cHMatrix[Index] += 1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private int CalcDIndex(double d)
        {
            return Convert.ToInt32(d - cDMin);
        }

        private bool IsBlack(int x, int y)
        {
            Color c = default(Color);
            double luminance = 0;

            c = cBmp.GetPixel(x, y);
            luminance = (c.R * 0.299) + (c.G * 0.587) + (c.B * 0.114);
            return luminance < 140;
        }

        private void Init()
        {
            int i = 0;
            double angle = 0;

            // Precalculation of sin and cos.
            cSinA = new double[cSteps];
            cCosA = new double[cSteps];
            for (i = 0; i <= cSteps - 1; i++)
            {
                angle = GetAlpha(i) * Math.PI / 180.0;
                cSinA[i] = Math.Sin(angle);
                cCosA[i] = Math.Cos(angle);
            }
            // Range of d:
            cDMin = -cBmp.Width;
            cDCount = Convert.ToInt32(2 * (cBmp.Width + cBmp.Height) / cDStep);
            cHMatrix = new int[cDCount * cSteps + 1];
        }

        public double GetAlpha(int Index)
        {
            return cAlphaStart + Index * cAlphaStep;
        }
    }

    public class ImageProcessing
    {
        private float ratio = 0;

        public static bool CheckFileImage(string fileImage, System.IO.MemoryStream mem)
        {
            bool result = true;
            string extension = Path.GetExtension(fileImage);

            switch (extension.ToLower())
            {
                //case ".docx":
                //case ".doc":
                //case ".rtf":
                //case ".wps":
                //case ".xls":
                //case ".xlsx":
                case ".png":
                case ".jpg":
                case ".jpeg":
                case ".gif":
                case ".bmp":
                case ".tiff":
                case ".tif":
                    Bitmap bitmap = new Bitmap(mem);
                    if (bitmap.HorizontalResolution == 1 || bitmap.VerticalResolution == 1)
                    {
                        result = false;
                    }
                    break;

                default: break;
            }
            return result;
        }

        public string CreateCardBackSide(CardProvider cardProvider, string imageCard, string cardValueCode, bool showCVCNo = true)
        {
            if (!string.IsNullOrEmpty(cardValueCode) && cardValueCode.Length < 3)
                cardValueCode = cardValueCode.PadLeft(3, '0');
            Bitmap source;
            using (FileStream stream = new FileStream(imageCard, FileMode.Open, FileAccess.Read))
            {
                source = (Bitmap)Image.FromStream(stream);
            }

            Bitmap result = new Bitmap(source.Width, source.Height);

            result.SetResolution(source.HorizontalResolution, source.VerticalResolution);

            int opacity = 255;
            Brush brush = new SolidBrush(Color.FromArgb(opacity, Color.Black));//Brushes.Silver;

            string fontType = "Arial";
            Graphics G = Graphics.FromImage(result);
            G.DrawImage(source, 0, 0, new Rectangle(0, 0, source.Width, source.Height), GraphicsUnit.Pixel);

            G.DrawString("CVC-Number", new Font(fontType, 10, FontStyle.Regular), brush, new PointF(95, 74));
            if (showCVCNo)
            {
                G.DrawString(cardValueCode, new Font(fontType, 11, FontStyle.Italic), brush, new PointF(187, 74));
            }

            G.Dispose();

            return BitmapToBase64(result);
        }

        public static FontFamily LoadFontFamily(string fileName, out System.Drawing.Text.PrivateFontCollection fontCollection)
        {
            fontCollection = new System.Drawing.Text.PrivateFontCollection();
            fontCollection.AddFontFile(fileName);
            return fontCollection.Families[0];
        }

        public string CreateCardFontSide(CardProvider cardProvider, string imageCard, string cardNumber, string dateExpire, string cardHolderName, string traveler)
        {
            // specify embedded resource name
            string resource = AppDomain.CurrentDomain.BaseDirectory + @"Font\CREDC___.ttf";
            System.Drawing.Text.PrivateFontCollection private_fonts;
            FontFamily font = LoadFontFamily(resource, out private_fonts);

            Bitmap source;
            using (FileStream stream = new FileStream(imageCard, FileMode.Open, FileAccess.Read))
            {
                source = (Bitmap)Image.FromStream(stream);
            }

            Bitmap result = new Bitmap(source.Width, source.Height);

            result.SetResolution(source.HorizontalResolution, source.VerticalResolution);

            //string fontType = "Credit Card";

            int opacity = 255;
            Brush brush = new SolidBrush(Color.FromArgb(opacity, Color.Black));//Brushes.Silver;

            Graphics G = Graphics.FromImage(result);
            G.DrawImage(source, 0, 0, new Rectangle(0, 0, source.Width, source.Height), GraphicsUnit.Pixel);
            G.DrawString(cardNumber, new Font(private_fonts.Families[0], 13), brush, new PointF(30, 120));
            G.DrawString(dateExpire, new Font(private_fonts.Families[0], 8), brush, new PointF(150, 160));

            if (string.IsNullOrWhiteSpace(traveler))
            {
                G.DrawString(cardHolderName.ToUpper(), new Font(private_fonts.Families[0], 8), brush, new PointF(20, 173));
                G.DrawString(string.Empty, new Font(private_fonts.Families[0], 8), brush, new PointF(20, 188));
            }
            else
            {
                G.DrawString(traveler.ToUpper(), new Font(private_fonts.Families[0], 8), brush, new PointF(20, 173));
                G.DrawString(cardHolderName.ToUpper(), new Font(private_fonts.Families[0], 8), brush, new PointF(20, 188));
            }
            G.Dispose();

            return BitmapToBase64(result);
        }

        public string BitmapToBase64(Bitmap image)
        {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            image.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] imageBytes = stream.ToArray();
            string base64Str = System.Convert.ToBase64String(imageBytes);
            return base64Str;
        }

        private Bitmap image = null;

        public Bitmap LoadImageFromFile(string fileName)
        {
            Bitmap loadedImage = null;
            FileStream stream = null;

            try
            {
                // read image to temporary memory stream
                // (.NET locks any stream until bitmap is disposed,
                // so that is why this work around is required to prevent file locking)
                stream = File.OpenRead(fileName);
                MemoryStream memoryStream = new MemoryStream();

                byte[] buffer = new byte[10000];
                while (true)
                {
                    int read = stream.Read(buffer, 0, 10000);

                    if (read == 0)
                        break;

                    memoryStream.Write(buffer, 0, read);
                }

                loadedImage = (Bitmap)Bitmap.FromStream(memoryStream);
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                    stream.Dispose();
                }
            }

            return loadedImage;
        }

        private bool CheckIfGrayscale()
        {
            // check pixel format
            if (image.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                return false;
            }
            return true;
        }

        private void Greyscale()
        {
            image = AForge.Imaging.Filters.Grayscale.CommonAlgorithms.BT709.Apply(image);
        }

        private void Threshold()
        {
            if (!CheckIfGrayscale())
            {
                Greyscale();
            }

            AForge.Imaging.Filters.Threshold filter = new AForge.Imaging.Filters.Threshold(230);
            // apply the filter
            filter.ApplyInPlace(image);
        }

        private void OtsuThreshold()
        {
            if (!CheckIfGrayscale())
            {
                Greyscale();
            }
            AForge.Imaging.Filters.OtsuThreshold filter = new AForge.Imaging.Filters.OtsuThreshold();
            // apply the filter
            filter.ApplyInPlace(image);
        }

        private void Median()
        {
            // create filter
            AForge.Imaging.Filters.Median filter = new AForge.Imaging.Filters.Median();
            // apply the filter
            filter.ApplyInPlace(image);
        }

        private void Mean()
        {
            // create filter
            AForge.Imaging.Filters.Mean filter = new AForge.Imaging.Filters.Mean();
            // apply the filter
            filter.ApplyInPlace(image);
        }

        private void Sharpen()
        {
            // create filter
            AForge.Imaging.Filters.Sharpen filter = new AForge.Imaging.Filters.Sharpen();
            // apply the filter
            filter.ApplyInPlace(image);
        }

        public string Process(string filename)
        {
            string newFilename = string.Empty;

            try
            {
                newFilename = filename.Replace(Path.GetFileNameWithoutExtension(filename), Path.GetFileNameWithoutExtension(filename) + "_PP");

                if (!System.IO.File.Exists(newFilename))
                {
                    image = LoadImageFromFile(filename);

                    Greyscale();

                    Threshold();

                    Mean();

                    Median();

                    Sharpen();

                    image.Save(newFilename);

                    image = null;
                }
            }
            catch (Exception)
            {
                newFilename = string.Empty;
            }

            return newFilename;
        }

        /// <summary>
        /// Method to resize, convert and save the image.
        /// </summary>
        /// <param name="image">Bitmap image.</param>
        /// <param name="maxWidth">resize width.</param>
        /// <param name="maxHeight">resize height.</param>
        /// <param name="quality">quality setting value.</param>
        /// <param name="filePath">file path.</param>
        public Bitmap Resize(Bitmap image, int maxWidth, int maxHeight, int quality)
        {
            // Get the image's original width and height
            int originalWidth = image.Width;
            int originalHeight = image.Height;

            // To preserve the aspect ratio
            float ratioX = (float)maxWidth / (float)originalWidth;
            float ratioY = (float)maxHeight / (float)originalHeight;
            ratio = Math.Min(ratioX, ratioY);

            // New width and height based on aspect ratio
            int newWidth = (int)(originalWidth * ratio);
            int newHeight = (int)(originalHeight * ratio);

            // Convert other formats (including CMYK) to RGB.
            Bitmap newImage = new Bitmap(newWidth, newHeight);
            newImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            // Draws the image in the specified size with quality mode set to HighQuality
            using (Graphics graphics = Graphics.FromImage(newImage))
            {
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            // Get an ImageCodecInfo object that represents the JPEG codec.
            ImageCodecInfo imageCodecInfo = this.GetEncoderInfo(ImageFormat.Jpeg);

            // Create an Encoder object for the Quality parameter.
            System.Drawing.Imaging.Encoder encoder = System.Drawing.Imaging.Encoder.Quality;

            // Create an EncoderParameters object.
            EncoderParameters encoderParameters = new EncoderParameters(1);

            // Save the image as a JPEG file with quality level.
            EncoderParameter encoderParameter = new EncoderParameter(encoder, quality);
            encoderParameters.Param[0] = encoderParameter;
            //newImage.Save(filePath, imageCodecInfo, encoderParameters);
            return newImage;
        }

        public string ResizeString(string filename, int maxWidth, int maxHeight, int rotateAngle = 0, int quality = 100)
        {
            string resizedImage = string.Empty;
            try
            {
                if (!System.IO.File.Exists(resizedImage))
                {
                    resizedImage = filename + ".resize.jpg";

                    image = LoadImageFromFile(filename);

                    if (rotateAngle != 0)
                    {
                        image = RotateFlip(image, rotateAngle);
                        image.Save(resizedImage + "rotate.jpg");
                    }

                    image = Resize(image, maxWidth, maxHeight, quality);

                    image.Save(resizedImage);

                    image = null;
                }
            }
            catch (Exception)
            {
                resizedImage = string.Empty;
            }

            return resizedImage;
        }

        /// <summary>
        /// Method to get encoder infor for given image format.
        /// </summary>
        /// <param name="format">Image format</param>
        /// <returns>image codec info.</returns>
        private ImageCodecInfo GetEncoderInfo(ImageFormat format)
        {
            return ImageCodecInfo.GetImageDecoders().SingleOrDefault(c => c.FormatID == format.Guid);
        }

        public Bitmap Crop(Bitmap source, Rectangle cropArea, int rotate = 0)
        {
            if (ratio != 0)
            {
                cropArea.X = (int)(cropArea.X * ratio);
                cropArea.Y = (int)(cropArea.Y * ratio);
                //template.With = (int)(template.With * ratio);
                //template.Height = (int)(template.With * ratio);
            }

            Bitmap result = new Bitmap(cropArea.Width, cropArea.Height);

            result.SetResolution(source.HorizontalResolution, source.VerticalResolution);
            Graphics G = Graphics.FromImage(result);
            SetHighSpeedGraphics(ref G, System.Drawing.Drawing2D.PixelOffsetMode.Half);
            G.DrawImage(source, 0, 0, new Rectangle(cropArea.X, cropArea.Y, cropArea.Width, cropArea.Height), GraphicsUnit.Pixel);
            G.Dispose();
            if (rotate != 0)
            {
                result = Rotate(result, rotate);
            }
            //result.Save(DateTime.Now.ToString("yyyyMMmmhhmmss") + ".jpg");
            return result;
        }

        public Bitmap DectectSkewAngle(Bitmap bmp, out decimal skewangle)
        {
            gmseDeskew sk = new gmseDeskew(bmp);
            double skewangle2 = sk.GetSkewAngle();
            Bitmap bmpOut = RotateImage(bmp, -skewangle2);
            skewangle = (decimal)skewangle2;
            return bmpOut;
        }

        public Bitmap RotateImage(Bitmap bmp, double angle)
        {
            Graphics g = default(Graphics);
            Bitmap tmp = new Bitmap(bmp.Width, bmp.Height, PixelFormat.Format32bppRgb);

            tmp.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);
            g = Graphics.FromImage(tmp);
            try
            {
                g.FillRectangle(Brushes.White, 0, 0, bmp.Width, bmp.Height);
                g.RotateTransform((float)angle);
                g.DrawImage(bmp, 0, 0);
            }
            finally
            {
                g.Dispose();
            }
            return tmp;
        }

        public void RotateImage(string fileImage, double angle)
        {
            Bitmap bmp;
            using (FileStream stream = new FileStream(fileImage, FileMode.Open, FileAccess.Read))
            {
                bmp = new Bitmap(stream);
            }
            Graphics g = default(Graphics);
            Bitmap tmp = new Bitmap(bmp.Width, bmp.Height, PixelFormat.Format32bppRgb);

            tmp.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);
            g = Graphics.FromImage(tmp);
            try
            {
                g.FillRectangle(Brushes.White, 0, 0, bmp.Width, bmp.Height);
                g.RotateTransform((float)angle);
                g.DrawImage(bmp, 0, 0);
                tmp.Save(fileImage);
            }
            finally
            {
                g.Dispose();
            }
        }

        public Bitmap RotateImprove(Bitmap bmp, float angle)
        {
            angle = angle % 360;
            if (angle > 180)
                angle -= 360;
            Color bkColor = Color.Transparent;
            System.Drawing.Imaging.PixelFormat pf = default(System.Drawing.Imaging.PixelFormat);
            if (bkColor == Color.Transparent)
            {
                pf = System.Drawing.Imaging.PixelFormat.Format32bppArgb;
            }
            else
            {
                pf = bmp.PixelFormat;
            }

            float sin = (float)Math.Abs(Math.Sin(angle * Math.PI / 180.0)); // this function takes radians
            float cos = (float)Math.Abs(Math.Cos(angle * Math.PI / 180.0)); // this one too
            float newImgWidth = sin * bmp.Height + cos * bmp.Width;
            float newImgHeight = sin * bmp.Width + cos * bmp.Height;
            float originX = 0f;
            float originY = 0f;

            if (angle > 0)
            {
                if (angle <= 90)
                    originX = sin * bmp.Height;
                else
                {
                    originX = newImgWidth;
                    originY = newImgHeight - sin * bmp.Width;
                }
            }
            else
            {
                if (angle >= -90)
                    originY = sin * bmp.Width;
                else
                {
                    originX = newImgWidth - sin * bmp.Height;
                    originY = newImgHeight;
                }
            }

            Bitmap newImg = new Bitmap((int)newImgWidth, (int)newImgHeight, pf);
            newImg.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);
            Graphics g = Graphics.FromImage(newImg);
            g.Clear(bkColor);
            g.TranslateTransform(originX, originY); // offset the origin to our calculated values
            g.RotateTransform(angle); // set up rotate
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            g.DrawImageUnscaled(bmp, 0, 0); // draw the image at 0, 0
            g.Dispose();

            return newImg;
        }

        //private Bitmap Skew(Bitmap bitmap)
        //{
        //    Rectangle rec = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
        //    BitmapData bitmapdata = bitmap.LockBits(rec, ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
        //    // create instance of skew checker
        //    DocumentSkewChecker skewChecker = new DocumentSkewChecker();
        //    // get documents skew angle
        //    double angle = skewChecker.GetSkewAngle(bitmapdata);
        //    // create rotation filter
        //    RotateBilinear rotationFilter = new RotateBilinear(-angle);
        //    rotationFilter.FillColor = Color.White;
        //    // rotate image applying the filter
        //    Bitmap rotatedImage = rotationFilter.Apply(bitmapdata);
        //    bitmap.UnlockBits(bitmapdata);
        //    return rotatedImage;
        //}

        public string Crop(string filename, int xPos, int yPos, int width, int height, int rotate = 0)
        {
            string cropFilename = filename + ".Crop.jpg";
            Bitmap bmp = LoadImageFromFile(filename);
            if (rotate != 0)
            {
                bmp = RotateFlip(bmp, rotate, filename);
            }
            //bmp.Save(filename + "rotateAAAAAA.jpg");
            Rectangle cropArea = new Rectangle
            {
                Height = height,
                Width = width,
                X = xPos,
                Y = yPos
            };

            Bitmap bmpZone = Crop(bmp, cropArea);

            bmpZone.Save(cropFilename);

            return cropFilename;
        }

        private void SetHighSpeedGraphics(ref Graphics G, System.Drawing.Drawing2D.PixelOffsetMode OffsetMode)
        {
            G.PageUnit = GraphicsUnit.Pixel;
            G.PixelOffsetMode = OffsetMode;
            G.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            G.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
        }

        public string RotateFile(string filename, int angle)
        {
            string result = filename + ".Rotate.jpg";
            Bitmap bmp = LoadImageFromFile(filename);
            //Open the source image and create the bitmap for the rotatated image
            Bitmap rotateImage = new Bitmap(bmp.Width, bmp.Height);

            //Set the resolution for the rotation image
            rotateImage.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);
            //Create a graphics object
            using (Graphics gdi = Graphics.FromImage(rotateImage))
            {
                //Rotate the image
                gdi.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);
                gdi.RotateTransform(angle);
                gdi.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);
                gdi.DrawImage(bmp, new System.Drawing.Point(0, 0));
            }

            bmp.Save(result);

            return result;
        }

        public Bitmap Rotate(Bitmap bmp, int angle)
        {
            //Open the source image and create the bitmap for the rotatated image
            Bitmap rotateImage = new Bitmap(bmp.Width + angle, bmp.Height + angle);

            //Set the resolution for the rotation image
            rotateImage.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);
            //Create a graphics object
            using (Graphics gdi = Graphics.FromImage(rotateImage))
            {
                gdi.InterpolationMode = InterpolationMode.HighQualityBicubic;
                //Rotate the image
                gdi.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);
                gdi.RotateTransform(angle);
                gdi.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);
                gdi.DrawImage(bmp, new System.Drawing.Point(0, 0));
            }

            return rotateImage;
        }

        public Bitmap RotateSkewAngle(Bitmap bmp, int angle)
        {
            switch (angle)
            {
                case 0:
                    break;

                case 270:
                case -90:
                    break;

                case 180:
                    break;

                case 90:
                case -270:
                    break;

                default:
                    bmp = Rotate(bmp, angle);
                    break;
            }
            return bmp;
        }

        private Bitmap RotateFlip(Bitmap bmp, int angle, string fileName = "")
        {
            RotateFlipType type = RotateFlipType.RotateNoneFlipX;

            if (angle >= 360) angle = angle - 360;

            switch (((angle / 90 * 90) - 360) * -1)
            {
                case 0:
                    type = RotateFlipType.RotateNoneFlipNone;
                    break;

                case 90:
                    type = RotateFlipType.Rotate90FlipNone;
                    break;

                case 180:
                    type = RotateFlipType.Rotate180FlipNone;
                    break;

                case 270:
                    type = RotateFlipType.Rotate270FlipNone;
                    break;

                default:
                    type = RotateFlipType.RotateNoneFlipNone;
                    break;
            }

            bmp.RotateFlip(type);
            //bmp.Save(fileName + "rotateAAAAAA.jpg");
            return bmp;
        }

        public void DrawRect(List<Rectangle> rectangleLineItems, string fileImage)
        {
            Bitmap bmpOri = null;
            using (FileStream stream = new FileStream(fileImage, FileMode.Open, FileAccess.Read))
            {
                bmpOri = new Bitmap(stream);
            }

            Bitmap newBitmap = new Bitmap(bmpOri.Width, bmpOri.Height);
            newBitmap.SetResolution(bmpOri.HorizontalResolution, bmpOri.VerticalResolution);

            Graphics graphics = Graphics.FromImage(newBitmap);
            graphics.DrawImage(bmpOri, 0, 0);

            using (Graphics g = Graphics.FromImage((Image)newBitmap))
            {
                if (rectangleLineItems != null)
                {
                    foreach (var item in rectangleLineItems)
                    {
                        Pen pen = new Pen(Color.Brown, 1);
                        pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                        g.DrawRectangle(pen, item);
                    }
                }
            }
            string file = Path.GetDirectoryName(fileImage) + @"\DrawRect\" + Path.GetFileName(fileImage);
            if (!Directory.Exists(Path.GetDirectoryName(file)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(file));
            }
            newBitmap.Save(file);
        }
    }
}