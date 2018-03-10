using ConvertTiff;
using Gnostice.Documents;
using System;
using System.Collections.Generic;

using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PdfSharp.Pdf;
using PdfSharp;
namespace T2P._2015.Cross.Utility.FileType
{
    public class PDFInfo
    {
        private string filePDF;

        public string FilePDF
        {
            get { return filePDF; }
            set { filePDF = value; }
        }
        private int rotate;

        public int Rotate
        {
            get { return rotate; }
            set { rotate = value; }
        }
        private int order;

        public int Order
        {
            get { return order; }
            set { order = value; }
        }
    }
    public class FileConversion
    {
        public void HtmlToPDF(string body, string fileName)
        {
            PdfDocument pdf = TheArtOfDev.HtmlRenderer.PdfSharp.PdfGenerator.GeneratePdf(System.Web.HttpUtility.HtmlDecode(body), PageSize.A4);
            pdf.Save(fileName);
        }

        public static void Active()
        {
            //string licenseKey = "A635-604D-F82A-680E-A31A-7FEE-F0F9-2EE2";
            //Framework.ActivateLicense(licenseKey);
            string licenseKey = "4F2B-99A8-1A22-C087-214A-95FE-5363-4AA1";
            Framework.ActivateLicense(licenseKey);
        }

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public FileConversion()
        {

        }

        private static FileConversion convertion;
        public static FileConversion Convertion
        {
            get
            {
                if (convertion == null)
                {
                    Active();
                    convertion = new FileConversion();
                }
                return convertion;
            }
        }

        private void PDFSharpConvert(string pdfFileName)
        {

            FileStream stream = File.OpenRead(pdfFileName);
            byte[] fileArray = new byte[stream.Length];
            stream.Read(fileArray, 0, fileArray.Length);
            MemoryStream sourceStream = new MemoryStream(fileArray);
            stream.Close();
            stream.Dispose();
            MemoryStream outputStream = null;
            sourceStream.Position = 0;
            outputStream = new MemoryStream();
            iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(sourceStream);
            iTextSharp.text.pdf.PdfStamper pdfStamper = new iTextSharp.text.pdf.PdfStamper(reader, outputStream);
            pdfStamper.FormFlattening = true;
            pdfStamper.Writer.SetPdfVersion(iTextSharp.text.pdf.PdfWriter.PDF_VERSION_1_7);
            pdfStamper.Writer.CloseStream = false;
            pdfStamper.Close();
            using (FileStream file = new FileStream(pdfFileName, FileMode.Create, FileAccess.Write))
            {
                outputStream.WriteTo(file);
            }


        }

        public List<string> Convert(int nBit, string outputFolder, string fileName, string baseFileName, int DPI = 96, string fileExtension = "pdf", bool multiPage = false)
        {

            List<string> result = new List<string>();
            string extension = Path.GetExtension(fileName);
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
                case ".wmf":
                case ".emf":
                case ".tiff":
                case ".tif":
                case ".pdf":
                case ".fdf":
                    var docConverter = new DocumentConverter();

                    if (fileExtension == "pdf")
                    {
                        //string filePDF = Path.GetDirectoryName(outputFolder) + @"\" + Path.GetFileNameWithoutExtension(fileName) +  + ".pdf";

                        //string extenstion = Path.GetExtension(fileName);
                        //if (extenstion.ToLower() != ".pdf")
                        //{
                        List<string> inputDocuments = new List<string>();
                        inputDocuments.Add(fileName);
                        List<string> temp = docConverter.ConvertToFile(inputDocuments, fileExtension, Path.GetDirectoryName(outputFolder), baseFileName, false, null, null, string.Empty);
                        if (temp.Count > 0)
                        {
                            //docConverter.ConvertToFile(fileName, filePDF);
                            PDFSharpConvert(temp.First());
                            result.Add(temp.First());
                        }
                        else
                        {
                            message = "Can not convert file to pdf";
                        }
                        //}
                        //else
                        //{
                        //    string filePDF = Path.GetDirectoryName(outputFolder) + @"\" + baseFileName +  ".pdf";

                        //    PDFSharpConvert(filePDF);
                        //    result.Add(filePDF);
                        //}

                    }
                    else
                    {
                        if (extension != ".pdf")
                        {
                            ConverterParams converterParams = new ConverterParams();
                            TIFFEncoderParams encoderParams = new TIFFEncoderParams();
                            encoderParams.PageScalling = PageScalling.UseRenderingResolution;
                            float dPI = Utility.Conversion.Conversion.ObjectToFloat(DPI);
                            encoderParams.ResolutionSettings = new ResolutionSettings(dPI, dPI);
                            encoderParams.CompressionType = TiffCompressionType.LZW;
                            if (multiPage)
                            {
                                encoderParams.MultiPage = true;
                            }
                            else
                            {
                                encoderParams.MultiPage = false;
                            }

                            result = docConverter.ConvertToFile(fileName, fileExtension, Path.GetDirectoryName(outputFolder), baseFileName, false, null, encoderParams, string.Empty);
                            if (result.Count == 0)
                            {
                                PDFSharpConvert(fileName);
                                result = docConverter.ConvertToFile(fileName, fileExtension, Path.GetDirectoryName(outputFolder), baseFileName, false, null, encoderParams, string.Empty);
                                if (result.Count == 0)
                                {
                                    encoderParams = new TIFFEncoderParams();
                                    result = docConverter.ConvertToFile(fileName, fileExtension, Path.GetDirectoryName(outputFolder), baseFileName, false, null, encoderParams, string.Empty);
                                    if (result.Count == 0)
                                    {
                                        throw new Exception("Can not convert file to " + fileExtension);
                                    }
                                }
                            }
                            docConverter.Dispose();

                        }
                        else
                        {
                            result = PdfConvertImage(nBit, outputFolder, fileName, baseFileName, DPI, fileExtension, multiPage);
                        }
                    }

                    if (!fileExtension.ToLower().Contains("tif") && !fileExtension.ToLower().Contains("pdf") && !fileExtension.ToLower().Contains(".doc"))
                    {
                        result.ForEach(item => { ImageCustomBit.ConvertNBit(item, nBit); });
                    }
                    break;
                default:

                    break;
            }
            return result;

        }

        public void convertBW(string fileName, string fileBW)
        {
            BlackToWhiteColor bw = new BlackToWhiteColor();
            bw.Change(fileName, fileBW);
        }

        private List<string> PdfConvertImage(int nBit, string outputFolder, string fileName, string baseFileName, int DPI = 96, string fileExtension = "pdf", bool multiPage = false)
        {
            List<string> filePDFTemp = new List<string>();
            try
            {
                PDFToImage convert = new PDFToImage();
                List<string> result = new List<string>();
                if (!multiPage)
                {
                    ConvertToPDF pdf = new ConvertToPDF();
                    filePDFTemp = pdf.SplitPDF(outputFolder, fileName, baseFileName);
                    filePDFTemp.ForEach(item => { result.Add(convert.Convert(item, Path.GetDirectoryName(outputFolder), 10, fileExtension, DPI)); });

                }
                else
                {
                    if (fileExtension.ToLower().Contains("tif"))
                    {

                        if (string.IsNullOrWhiteSpace(baseFileName))
                        {
                            baseFileName = Path.GetFileNameWithoutExtension(fileName);
                        }
                        List<string> ImageTemp = new List<string>();
                        ConvertToPDF pdf = new ConvertToPDF();
                        filePDFTemp = pdf.SplitPDF(outputFolder, fileName, baseFileName);
                        filePDFTemp.ForEach(item => { ImageTemp.Add(convert.Convert(item, Path.GetDirectoryName(outputFolder), 10, "jpg", DPI)); });
                        result.Add(NImageToTiff(Path.GetDirectoryName(outputFolder), ImageTemp, baseFileName, nBit));
                    }
                    else
                    {
                        result.Add(convert.Convert(fileName, Path.GetDirectoryName(outputFolder), 10, fileExtension, DPI));
                    }
                }

                return result;
            }
            finally
            {
                filePDFTemp.ForEach(item => { if (File.Exists(item)) { File.Delete(item); } });
            }
        }

        public string NImageToTiff(string DesFolder, List<string> listFileConvert, string fileName, int nBIt)
        {
            try
            {
                string result = string.Empty;
                if (listFileConvert.Count == 0) return string.Empty;
                //get the codec for tiff files
                System.Drawing.Imaging.ImageCodecInfo info = null;
                info = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders().FirstOrDefault(x => x.MimeType == "image/tiff");
                //use the save encoder
                System.Drawing.Imaging.Encoder enc = System.Drawing.Imaging.Encoder.SaveFlag;

                System.Drawing.Imaging.EncoderParameters ep = new System.Drawing.Imaging.EncoderParameters(3);
                ep.Param[0] = new System.Drawing.Imaging.EncoderParameter(enc, (long)System.Drawing.Imaging.EncoderValue.MultiFrame);
                ep.Param[1] = new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Compression, (long)System.Drawing.Imaging.EncoderValue.CompressionLZW);
                ep.Param[2] = new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.ColorDepth, nBIt);
                Bitmap pages = null;
                int frame = 0;

                foreach (string fifle in listFileConvert)
                {
                    if (File.Exists(fifle) == true)
                    {
                        if (frame == 0)
                        {
                            FileStream stream = new FileStream(fifle, FileMode.Open, FileAccess.Read);
                            pages = (Bitmap)Image.FromStream(stream);
                            //pages = (Bitmap)Image.FromFile(fifle);
                            //save the first frame
                            //string[] temp = Path.GetFileNameWithoutExtension(fifle).Split('.');
                            //string fileNameConvert = temp[0] + "Combine";
                            result = DesFolder + "\\" + Path.GetFileNameWithoutExtension(fileName) + ".tif";
                            //tiffFilePath = DesFolder + "\\T2P_" + Path.GetFileNameWithoutExtension(firsttifffilepath) + ".tif";



                            pages.Save(result, info, ep);
                            stream.Close();
                        }
                        else
                        {
                            //save the intermediate frames
                            ep.Param[0] = new System.Drawing.Imaging.EncoderParameter(enc, (long)System.Drawing.Imaging.EncoderValue.FrameDimensionPage);
                            //Bitmap bm = (Bitmap)Image.FromFile(fifle);
                            FileStream stream = new FileStream(fifle, FileMode.Open, FileAccess.Read);
                            Bitmap bm = (Bitmap)Image.FromStream(stream);
                            pages.SaveAdd(bm, ep);
                            stream.Close();
                        }
                        if (frame == listFileConvert.Count - 1)
                        {
                            //flush and close.
                            ep.Param[0] = new System.Drawing.Imaging.EncoderParameter(enc, (long)System.Drawing.Imaging.EncoderValue.Flush);
                            pages.SaveAdd(ep);
                        }
                        frame++;
                    }
                }

                pages.Dispose();

                ep.Dispose();
                return result; // Count files converted to TIFF
            }
            finally
            {
                listFileConvert.ForEach(item => { if (File.Exists(item)) { File.Delete(item); } });
            }
        }

        private void StreamToFile(Stream stream, string fileName)
        {
            // read data from attachment

            // save attachment to disk
            FileStream outStream = null;
            MemoryStream mem = (MemoryStream)stream;
            string fileAttach = fileName;
            outStream = File.OpenWrite(fileAttach);

            // Save File
            mem.WriteTo(outStream);
            mem.Close();
            outStream.Flush();
            outStream.Close();
        }

        public static string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= '0' && str[i] <= '9') || (str[i] >= 'A' && str[i] <= 'z' && str[i] != '[' && str[i] != ']' && str[i] != '^' && str[i] != '\\' || (str[i] == '.' || str[i] == '_')))
                    sb.Append(str[i]);
            }
            return sb.ToString();
        }

        private string ReplaceSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= '0' && str[i] <= '9') || (str[i] >= 'A' && str[i] <= 'z' && str[i] != '[' && str[i] != ']' && str[i] != '^' && str[i] != '\\' || (str[i] == '_')))
                    sb.Append(str[i]);
                else sb.Append('-');
            }
            return sb.ToString();
        }

        public string Convert(List<PDFInfo> listPDFInfo, string outputFolder, string outputFilename)
        {
            List<string> listFileTemp = new List<string>();
            try
            {
                PdfSharp.Pdf.PdfDocument outputPDFDocument = new PdfSharp.Pdf.PdfDocument();
                string fileCombine = outputFolder + @"\" + (!string.IsNullOrWhiteSpace(outputFilename) ? outputFilename.Trim() : Guid.NewGuid().ToString()) + ".pdf";
                listPDFInfo = listPDFInfo.OrderBy(x => x.Order).ToList();

                if (!Directory.Exists(outputFolder))
                {
                    Directory.CreateDirectory(outputFolder);
                }

                ConvertToPDF convertToPDF = new ConvertToPDF();
                foreach (var item in listPDFInfo)
                {
                    string fileTemp = outputFolder + @"\" + Guid.NewGuid().ToString() + Path.GetFileName(item.FilePDF);
                    File.Copy(item.FilePDF, fileTemp);
                    listFileTemp.Add(fileTemp);
                    if (item.Rotate != 0)
                    {
                        convertToPDF.RotatePDF(fileTemp, item.Rotate);
                    }
                    PdfSharp.Pdf.PdfDocument inputPDFDocument = PdfSharp.Pdf.IO.PdfReader.Open(fileTemp, PdfSharp.Pdf.IO.PdfDocumentOpenMode.Import);
                    outputPDFDocument.Version = inputPDFDocument.Version;
                    foreach (PdfSharp.Pdf.PdfPage page in inputPDFDocument.Pages)
                    {
                        outputPDFDocument.AddPage(page);
                    }

                }
                outputPDFDocument.Save(fileCombine);

                return fileCombine;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (listFileTemp.Count > 0)
                {
                    listFileTemp.ForEach(item => { if (File.Exists(item)) { File.Delete(item); } });

                }
            }
        }
    }
}
