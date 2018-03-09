using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Utility.FileType
{
    public class ImageCustomBit
    {
        public static void ConvertNBit(string file, int bit)
        {

            try
            {
                string FolderPath = Path.GetDirectoryName(file);
                string FileName = Path.GetFileNameWithoutExtension(file);

                string extension = Path.GetExtension(file);
                System.Drawing.Bitmap b1;
                using (FileStream stream = new FileStream(file, FileMode.Open, FileAccess.Read))
                {
                    Bitmap bitmap = (Bitmap)Image.FromStream(stream);
                    //Bitmap bitmap = (Bitmap)Image.FromFile(file);
                    int count = bitmap.GetFrameCount(FrameDimension.Page);
                    if (bit == 1 || bit == 8)
                    {
                        if (count > 1)
                        {
                            return;
                            for (int idx = 0; idx < count; idx++)
                            {
                                // save each frame to a bytestream
                                bitmap.SelectActiveFrame(FrameDimension.Page, idx);
                                //MemoryStream byteStream = new MemoryStream();
                                //EncoderParameters parameters = new EncoderParameters(1);
                                //System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
                                //parameters.Param[0] = new EncoderParameter(myEncoder, 0L);
                                //ImageCodecInfo pngCodec = ImageCodecInfo.GetImageEncoders().Where(codec => codec.FormatID.Equals(System.Drawing.Imaging.ImageFormat.Jpeg.Guid)).FirstOrDefault();
                                //string FullName = FolderPath + @"\" + FileName + "_" + (idx + 1) + "_0L.jpg";
                                //bitmap.Save(FullName, pngCodec, parameters);
                                //System.Drawing.Bitmap b1 = _8Bit.CopyToBpp(bitmap, 1);
                                //string FullName1Bit = FolderPath + @"\" + FileName + "_" + (idx + 1) + extension;

                                //b1.Save(FullName1Bit);
                                if (idx == 0)
                                {

                                }

                            }

                        }
                        else
                        {
                            b1 = CopyToBpp(bitmap, bit);
                        }
                    }
                    else
                    {
                        b1 = bitmap;
                    }
                }
                //string FullName1Bit = FolderPath + @"\" + FileName + "_1Bit" + extension;
                //int maxWidth = 2048; int maxHeight = 2048;

                //if (!Configuration.Config.IsProduction())
                //{
                //    if (b1.Width > maxWidth || b1.Height > maxHeight)
                //    {
                //        Save(b1, 2048, 2048, 100, file);
                //    }
                //    else
                //    {
                //        b1.Save(file);
                //    }
                //}
                //else
                //{
                //    b1.Save(file);
                //}
                b1.Save(file);
            }
            catch (Exception ex)
            {

                T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessageAndLog(ex, System.Reflection.MethodBase.GetCurrentMethod(), file, bit);
            }
        }


        /// <summary>
        /// Method to resize, convert and save the image.
        /// </summary>
        /// <param name="image">Bitmap image.</param>
        /// <param name="maxWidth">resize width.</param>
        /// <param name="maxHeight">resize height.</param>
        /// <param name="quality">quality setting value.</param>
        /// <param name="filePath">file path.</param>      
        public static void Save(Bitmap image, int maxWidth, int maxHeight, int quality, string filePath)
        {
            // Get the image's original width and height
            int originalWidth = image.Width;
            int originalHeight = image.Height;

            // To preserve the aspect ratio
            float ratioX = (float)maxWidth / (float)originalWidth;
            float ratioY = (float)maxHeight / (float)originalHeight;
            float ratio = Math.Min(ratioX, ratioY);

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
            ImageCodecInfo imageCodecInfo = GetEncoderInfo(ImageFormat.Jpeg);

            // Create an Encoder object for the Quality parameter.
            System.Drawing.Imaging.Encoder encoder = System.Drawing.Imaging.Encoder.Quality;

            // Create an EncoderParameters object. 
            EncoderParameters encoderParameters = new EncoderParameters(1);

            // Save the image as a JPEG file with quality level.
            EncoderParameter encoderParameter = new EncoderParameter(encoder, quality);
            encoderParameters.Param[0] = encoderParameter;
            newImage.Save(filePath, imageCodecInfo, encoderParameters);
        }

        /// <summary>
        /// Method to get encoder infor for given image format.
        /// </summary>
        /// <param name="format">Image format</param>
        /// <returns>image codec info.</returns>
        private static ImageCodecInfo GetEncoderInfo(ImageFormat format)
        {
            return ImageCodecInfo.GetImageDecoders().SingleOrDefault(c => c.FormatID == format.Guid);
        }



        static System.Drawing.Bitmap CopyToBpp(System.Drawing.Bitmap b, int bpp)
        {

            if (bpp != 1 && bpp != 8) throw new System.ArgumentException("1 or 8", "bpp");

            int w = b.Width, h = b.Height;
            IntPtr hbm = b.GetHbitmap();
            BITMAPINFO bmi = new BITMAPINFO();

            bmi.biSize = 40;

            bmi.biWidth = w;

            bmi.biHeight = h;

            bmi.biPlanes = 1;

            bmi.biBitCount = (short)bpp;

            bmi.biCompression = BI_RGB;

            bmi.biSizeImage = (uint)(((w + 7) & 0xFFFFFFF8) * h / 8);

            bmi.biXPelsPerMeter = 1000000;

            bmi.biYPelsPerMeter = 1000000;

            // Now for the colour table.

            uint ncols = (uint)1 << bpp;

            bmi.biClrUsed = ncols;

            bmi.biClrImportant = ncols;

            bmi.cols = new uint[256];

            if (bpp == 1) { bmi.cols[0] = MAKERGB(0, 0, 0); bmi.cols[1] = MAKERGB(255, 255, 255); }

            else { for (int i = 0; i < ncols; i++) bmi.cols[i] = MAKERGB(i, i, i); }

            IntPtr bits0; IntPtr hbm0 = CreateDIBSection(IntPtr.Zero, ref bmi, DIB_RGB_COLORS, out bits0, IntPtr.Zero, 0);

            IntPtr sdc = GetDC(IntPtr.Zero);

            IntPtr hdc = CreateCompatibleDC(sdc); SelectObject(hdc, hbm);

            IntPtr hdc0 = CreateCompatibleDC(sdc); SelectObject(hdc0, hbm0);

            BitBlt(hdc0, 0, 0, w, h, hdc, 0, 0, SRCCOPY);

            System.Drawing.Bitmap b0 = System.Drawing.Bitmap.FromHbitmap(hbm0);



            DeleteDC(hdc);

            DeleteDC(hdc0);

            ReleaseDC(IntPtr.Zero, sdc);

            DeleteObject(hbm);

            DeleteObject(hbm0);

            //

            return b0;

        }



        [System.Runtime.InteropServices.DllImport("gdi32.dll")]

        public static extern bool DeleteObject(IntPtr hObject);



        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern IntPtr GetDC(IntPtr hwnd);



        [System.Runtime.InteropServices.DllImport("gdi32.dll")]

        public static extern IntPtr CreateCompatibleDC(IntPtr hdc);



        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);



        [System.Runtime.InteropServices.DllImport("gdi32.dll")]

        public static extern int DeleteDC(IntPtr hdc);



        [System.Runtime.InteropServices.DllImport("gdi32.dll")]

        public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);



        [System.Runtime.InteropServices.DllImport("gdi32.dll")]

        public static extern int BitBlt(IntPtr hdcDst, int xDst, int yDst, int w, int h, IntPtr hdcSrc, int xSrc, int ySrc, int rop);

        static int SRCCOPY = 0x00CC0020;



        [System.Runtime.InteropServices.DllImport("gdi32.dll")]

        static extern IntPtr CreateDIBSection(IntPtr hdc, ref BITMAPINFO bmi, uint Usage, out IntPtr bits, IntPtr hSection, uint dwOffset);

        static uint BI_RGB = 0;

        static uint DIB_RGB_COLORS = 0;

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]

        public struct BITMAPINFO
        {

            public uint biSize;

            public int biWidth, biHeight;

            public short biPlanes, biBitCount;

            public uint biCompression, biSizeImage;

            public int biXPelsPerMeter, biYPelsPerMeter;

            public uint biClrUsed, biClrImportant;

            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 256)]

            public uint[] cols;

        }



        static uint MAKERGB(int r, int g, int b)
        {

            return ((uint)(b & 255)) | ((uint)((r & 255) << 8)) | ((uint)((g & 255) << 16));

        }

    }


    public class BlackToWhiteColor
    {
        struct BitmapIndex
        {
            public int Index;
            public Bitmap BitMap;
        }
        //private List<Bitmap> HandleManual()
        //{
        //    var originalbmp = new Bitmap(Bitmap.FromFile(textBox1.Text)); // Load the  image



        //    int path1 = (int)originalbmp.Height / 4 * 1;
        //    int path2 = (int)originalbmp.Height / 4 * 2;
        //    int path3 = (int)originalbmp.Height / 4 * 3;
        //    int Width = originalbmp.Width;
        //    int Height = originalbmp.Height;

        //    originalbmp.Dispose();
        //    Bitmap bitmapPath1 = null;
        //    Bitmap bitmapPath2 = null;
        //    Bitmap bitmapPath3 = null;
        //    Bitmap bitmapPath4 = null;
        //    Task item1 = new Task(() => bitmapPath1 = GetSafeSelectionBitmap(textBox1.Text, 0, 0, Width, path1));
        //    Task item2 = new Task(() => bitmapPath2 = GetSafeSelectionBitmap(textBox1.Text, 0, path1 + 1, Width, path1));
        //    Task item3 = new Task(() => bitmapPath3 = GetSafeSelectionBitmap(textBox1.Text, 0, path2 + 1, Width, path1));
        //    Task item4 = new Task(() => bitmapPath4 = GetSafeSelectionBitmap(textBox1.Text, 0, path3 + 1, Width, path1));
        //    item1.Start();
        //    item2.Start();
        //    item3.Start();
        //    item4.Start();
        //    item1.Wait();
        //    item2.Wait();
        //    item3.Wait();
        //    item4.Wait();
        //    List<Bitmap> list = new List<Bitmap>() { bitmapPath1, bitmapPath2, bitmapPath3, bitmapPath4 };
        //    return list;
        //}

        public void Change(string fileName, string fileChange)
        {
            try
            {

                List<Bitmap> list = HandleFor(fileName);
                Bitmap b = CombineImages(list);
                b.Save(fileChange);

            }
            catch
            {


            }
            finally
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
        }

        private List<Bitmap> HandleFor(string fileName)
        {
            Bitmap originalbmp = null;
            using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                originalbmp = (Bitmap)Image.FromStream(stream);
            }

            int Width = originalbmp.Width;
            int Height = originalbmp.Height;

            originalbmp.Dispose();

            List<Bitmap> list = new List<Bitmap>();
            List<Task> listTask = new List<Task>();
            int nPath = 10;
            int position = 0;
            int HeightPath = Height / nPath * 1;
            List<int> listPostion = new List<int>();





            for (int i = 1; i <= nPath; i++)
            {

                listPostion.Add(position);
                position = (Height / nPath * i) + 1;

            }
            List<BitmapIndex> listBitMap = new List<BitmapIndex>();


            //List<ManualResetEvent> manualEvents = new List<ManualResetEvent>();

            //foreach (var item in listPostion)
            //{
            //    ManualResetEvent even = new ManualResetEvent(false);

            //    ThreadPool.QueueUserWorkItem(new WaitCallback(

            //          (_) =>
            //          {
            //              listBitMap.Add(GetSafeSelectionBitmapIndex(fileName, 0, item, Width, HeightPath));
            //              even.Set();
            //          }
            //          ));
            //    manualEvents.Add(even);
            //}
            //manualEvents.ToList().ForEach(x => x.WaitOne());

            foreach (var item in listPostion)
            {
                Task task = new Task(() => listBitMap.Add(GetSafeSelectionBitmapIndex(fileName, 0, item, Width, HeightPath)));
                listTask.Add(task);
                task.Start();
            }
            listTask.ForEach(x => x.Wait());



            list = listBitMap.OrderBy(x => x.Index).Select(x => x.BitMap).ToList();
            return list;
        }

        private Bitmap CombineImages(List<Bitmap> files)
        {
            //change the location to store the final image.
            List<int> imageHeights = new List<int>();
            int nIndex = 0;
            int width = 0;
            int height = 0;
            float horizontalResolution = files.Max(x => x.HorizontalResolution);
            float verticalResolution = files.Max(x => x.VerticalResolution);
            foreach (Bitmap img in files)
            {

                imageHeights.Add(img.Height);
                height += img.Height;
                if (width < img.Width)
                {
                    width = img.Width;
                }

                //img.Dispose();
            }


            Bitmap img3 = new Bitmap(width, height);
            img3.SetResolution(horizontalResolution, verticalResolution);
            Graphics g = Graphics.FromImage(img3);
            g.Clear(SystemColors.AppWorkspace);
            foreach (Bitmap item in files)
            {
                //Image img = (Image)item;
                if (nIndex == 0)
                {


                    g.DrawImage(item, new Point(0, 0));
                    nIndex++;
                    height = item.Height;
                }
                else
                {
                    g.DrawImage(item, new Point(0, height));
                    height += item.Height;
                }
                item.Dispose();
            }
            g.Dispose();

            //img3.Dispose();
            return img3;

        }
        private BitmapIndex GetSafeSelectionBitmapIndex(string fileName, int xPos, int yPos, int with, int height)
        {
            BitmapIndex result = new BitmapIndex() { Index = yPos };
            Bitmap source;
            using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                source = (Bitmap)Image.FromStream(stream);
            }

            result.BitMap = new Bitmap(with, height);

            result.BitMap.SetResolution(source.HorizontalResolution, source.VerticalResolution);

            Graphics G = Graphics.FromImage(result.BitMap);
            // SetHighSpeedGraphics(ref G, System.Drawing.Drawing2D.PixelOffsetMode.Half);



            G.DrawImage(source, 0, 0, new Rectangle(xPos, yPos, with, height), GraphicsUnit.Pixel);
            G.Dispose();
            //source.Dispose();

            result.BitMap = SetPixel(result.BitMap);
            return result;
        }


        private Bitmap GetSafeSelectionBitmap(string fileName, int xPos, int yPos, int with, int height)
        {

            Bitmap source;
            using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                source = (Bitmap)Image.FromStream(stream);
            }

            Bitmap result = new Bitmap(with, height);

            result.SetResolution(source.HorizontalResolution, source.VerticalResolution);

            Graphics G = Graphics.FromImage(result);
            // SetHighSpeedGraphics(ref G, System.Drawing.Drawing2D.PixelOffsetMode.Half);



            G.DrawImage(source, 0, 0, new Rectangle(xPos, yPos, with, height), GraphicsUnit.Pixel);
            G.Dispose();
            //source.Dispose();

            //return SetPixel(result);
            return result;
        }
        private void SetHighSpeedGraphics(ref Graphics G, System.Drawing.Drawing2D.PixelOffsetMode OffsetMode)
        {
            G.PageUnit = GraphicsUnit.Pixel;
            G.PixelOffsetMode = OffsetMode;
            G.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            G.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
        }

        private Bitmap SetPixel(Bitmap originalbmp)
        {
            Bitmap newbmp = originalbmp;
            for (int row = 0; row < originalbmp.Width; row++) // Indicates row number
            {
                for (int column = 0; column < originalbmp.Height; column++) // Indicate column number
                {
                    var colorValue = originalbmp.GetPixel(row, column); // Get the color pixel
                    var averageValue = ((int)colorValue.R + (int)colorValue.B + (int)colorValue.G) / 3; // get the average for black and white
                    if (averageValue > 210)
                    {
                        newbmp.SetPixel(row, column, Color.White);
                    }
                    else
                    {
                        newbmp.SetPixel(row, column, Color.Black);
                    }
                    //newbmp.SetPixel(row, column, Color.FromArgb(averageValue, averageValue, averageValue)); // Set the value to new pixel
                }
            }
            return newbmp;
        }
    }
}

