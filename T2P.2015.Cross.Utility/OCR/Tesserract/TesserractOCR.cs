//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using T2P._2015.Cross.Utility.FileType;
//using Tesseract;

//namespace T2P._2015.Cross.Utility.OCR
//{
//    public class TesserractOCR
//    {
//        public List<OCRRow> listOCRRow = new List<OCRRow>();
//        public string Message = string.Empty;


//        public void Run(string imageFile, int x, int y, int width, int height)
//        {


//            ImageProcessing image = new ImageProcessing();

//            Bitmap bmp = image.LoadImageFromFile(imageFile);

//            //crop image
//            Rectangle zone = new Rectangle(x, y, width, height);
//            Bitmap bmpZone = image.Crop(bmp, zone);
//            OCR(ImageToByte2(bmpZone));
//        }
//        public void Run(Bitmap bmp, int x, int y, int width, int height)
//        {


//            ImageProcessing image = new ImageProcessing();
//            //crop image
//            Rectangle zone = new Rectangle(x, y, width, height);
//            Bitmap bmpZone = image.Crop(bmp, zone);
//            OCR(ImageToByte2(bmpZone));
//        }
//        public void Run(string imageFile)
//        {


//            ImageProcessing image = new ImageProcessing();
//            Bitmap bmp = image.LoadImageFromFile(imageFile);
//            OCR(ImageToByte2(bmp));
//        }





//        public static byte[] ImageToByte2(Image img)
//        {
//            byte[] byteArray = new byte[0];
//            using (MemoryStream stream = new MemoryStream())
//            {
//                img.Save(stream, System.Drawing.Imaging.ImageFormat.Tiff);
//                stream.Close();

//                byteArray = stream.ToArray();
//            }
//            return byteArray;
//        }

//        private void OCR(byte[] fileName)
//        {

//            using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
//            {

//                using (var img = Pix.LoadTiffFromMemory(fileName))
//                {
//                    var i = 1;
//                    using (var page = engine.Process(img))
//                    {
//                        Message = page.GetText();
//                        OCRRow row = new OCRRow();
//                        using (var iter = page.GetIterator())
//                        {
//                            iter.Begin();
//                            do
//                            {
//                                if (iter.IsAtBeginningOf(PageIteratorLevel.TextLine))
//                                {
//                                    listOCRRow.Add(row);
//                                    row = new OCRRow();
//                                    row.Row = iter.GetText(PageIteratorLevel.TextLine);
//                                    row.Confidence = iter.GetConfidence(PageIteratorLevel.TextLine);
//                                }

//                                WordInfo wordInfo = new WordInfo();
//                                wordInfo.Word = iter.GetText(PageIteratorLevel.Word);

//                                if (!string.IsNullOrWhiteSpace(wordInfo.Word))
//                                {
//                                    Pix pix = iter.GetImage(PageIteratorLevel.Word, 0, out wordInfo.XPos, out wordInfo.YPos);
//                                    wordInfo.Width = pix.Width;
//                                    wordInfo.Height = pix.Height;
//                                    wordInfo.Confidence = iter.GetConfidence(PageIteratorLevel.Word);
//                                    row.ListWord.Add(wordInfo);
//                                }



//                                i++;
//                            }
//                            while (iter.Next(PageIteratorLevel.Word));
//                            listOCRRow.Add(row);

//                        }
//                    }
//                }
//            }

//        }
//    }
//}
