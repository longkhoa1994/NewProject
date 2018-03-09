using HtmlAgilityPack;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using PdfSharp.Drawing;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Web;

using iTextSharp.tool.xml.html;
using iTextSharp.tool.xml.parser;
using iTextSharp.tool.xml.pipeline.css;
using iTextSharp.tool.xml.pipeline.end;
using iTextSharp.tool.xml.pipeline.html;
using System.Reflection;
using iTextSharp.text.pdf.parser;

namespace T2P._2015.Cross.Utility.FileType
{
    public class PDF
    {
        public byte[] CreateCostAcceptance(string body)
        {

            iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 10, 10, 10, 10);

            using (MemoryStream output = new MemoryStream())
            {
                iTextSharp.text.pdf.PdfWriter wri = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, output);
                doc.Open();

                iTextSharp.tool.xml.XMLWorkerHelper helper = iTextSharp.tool.xml.XMLWorkerHelper.GetInstance();

                //Added card image into HTML body
                var tagProcessors = (iTextSharp.tool.xml.html.DefaultTagProcessorFactory)iTextSharp.tool.xml.html.Tags.GetHtmlTagProcessorFactory();
                tagProcessors.RemoveProcessor(iTextSharp.tool.xml.html.HTML.Tag.IMG); // remove the default processor
                tagProcessors.AddProcessor(iTextSharp.tool.xml.html.HTML.Tag.IMG, new T2P._2015.Cross.Utility.FileType.CustomImageTagProcessor()); // use our new processor

                iTextSharp.tool.xml.css.CssFilesImpl cssFiles = new iTextSharp.tool.xml.css.CssFilesImpl();
                cssFiles.Add(iTextSharp.tool.xml.XMLWorkerHelper.GetInstance().GetDefaultCSS());
                var cssResolver = new iTextSharp.tool.xml.css.StyleAttrCSSResolver(cssFiles);
                //cssResolver.AddCss(@"code { padding: 2px 4px; }", "utf-8", true);
                var charset = Encoding.UTF8;
                var hpc = new iTextSharp.tool.xml.pipeline.html.HtmlPipelineContext(new iTextSharp.tool.xml.html.CssAppliersImpl(new iTextSharp.tool.xml.XMLWorkerFontProvider()));
                hpc.SetAcceptUnknown(true).AutoBookmark(true).SetTagFactory(tagProcessors); // inject the tagProcessors
                var htmlPipeline = new iTextSharp.tool.xml.pipeline.html.HtmlPipeline(hpc, new iTextSharp.tool.xml.pipeline.end.PdfWriterPipeline(doc, wri));
                var pipeline = new iTextSharp.tool.xml.pipeline.css.CssResolverPipeline(cssResolver, htmlPipeline);

                //render PDF from HTML
                var worker = new iTextSharp.tool.xml.XMLWorker(pipeline, true);
                var xmlParser = new iTextSharp.tool.xml.parser.XMLParser(true, worker, charset);
                xmlParser.Parse(new StringReader(body));

                doc.Close();
                return output.ToArray();
            }
        }

        public string CreateConfirmation(string location, string folder, string fileName, string body)
        {
            try
            {

                //string contents = string.Empty;
                //StreamReader sr;

                //Make HTML
                if (!body.Contains("height=\"50px\""))
                {
                    body = body.Replace("<img", "<img height=\"50px\"");
                }

                string folderPath = location + "\\" + folder;
                string filePath = location + "\\" + folder + "\\" + fileName;
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                body = "<html><head></head><body>" + body + "</body></html>";

                iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 10, 10, 10, 10);

                using (MemoryStream output = new MemoryStream())
                {
                    iTextSharp.text.pdf.PdfWriter wri = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, output);
                    doc.Open();

                    iTextSharp.tool.xml.XMLWorkerHelper helper = iTextSharp.tool.xml.XMLWorkerHelper.GetInstance();

                    //Added card image into HTML body
                    var tagProcessors = (iTextSharp.tool.xml.html.DefaultTagProcessorFactory)iTextSharp.tool.xml.html.Tags.GetHtmlTagProcessorFactory();
                    tagProcessors.RemoveProcessor(iTextSharp.tool.xml.html.HTML.Tag.IMG); // remove the default processor
                    tagProcessors.AddProcessor(iTextSharp.tool.xml.html.HTML.Tag.IMG, new T2P._2015.Cross.Utility.FileType.CustomImageTagProcessor()); // use our new processor

                    iTextSharp.tool.xml.css.CssFilesImpl cssFiles = new iTextSharp.tool.xml.css.CssFilesImpl();
                    cssFiles.Add(iTextSharp.tool.xml.XMLWorkerHelper.GetInstance().GetDefaultCSS());
                    var cssResolver = new iTextSharp.tool.xml.css.StyleAttrCSSResolver(cssFiles);
                    //cssResolver.AddCss(@"code { padding: 2px 4px; }", "utf-8", true);
                    var charset = Encoding.UTF8;
                    var hpc = new iTextSharp.tool.xml.pipeline.html.HtmlPipelineContext(new iTextSharp.tool.xml.html.CssAppliersImpl(new iTextSharp.tool.xml.XMLWorkerFontProvider()));
                    hpc.SetAcceptUnknown(true).AutoBookmark(true).SetTagFactory(tagProcessors); // inject the tagProcessors
                    var htmlPipeline = new iTextSharp.tool.xml.pipeline.html.HtmlPipeline(hpc, new iTextSharp.tool.xml.pipeline.end.PdfWriterPipeline(doc, wri));
                    var pipeline = new iTextSharp.tool.xml.pipeline.css.CssResolverPipeline(cssResolver, htmlPipeline);

                    //render PDF from HTML
                    var worker = new iTextSharp.tool.xml.XMLWorker(pipeline, true);
                    var xmlParser = new iTextSharp.tool.xml.parser.XMLParser(true, worker, charset);
                    xmlParser.Parse(new StringReader(body));

                    doc.Close();
                    File.WriteAllBytes(filePath, output.ToArray());

                    return filePath;
                }


            }
            catch (Exception ex)
            {
                fileName = string.Empty;
                T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessageAndLog(ex);
            }

            return fileName;
        }

        public string HtmlToPDF(string location, string folder, string fileName, string body, bool isFix = false)
        {
            try
            {

                //string contents = string.Empty;
                //StreamReader sr;

                //Make HTML
                if (!body.Contains("height=\"50px\""))
                {
                    body = body.Replace("<img", "<img height=\"50px\"");
                }

                string folderPath = location + "\\" + folder;
                string filePath = location + "\\" + folder + "\\" + fileName;
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                body = "<html><head></head><body>" + body + "</body></html>";

                ////Read file from server path
                //sr = File.OpenText(fileHtml);
                ////store content in the variable
                //contents = sr.ReadToEnd();
                //sr.Close();

                if (isFix)
                {
                    body = FixHtml(body);
                }

                using (iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10, 10, 40, 40))
                {

                    using (var existingFileStream = new FileStream(filePath, FileMode.Create))
                    {
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, existingFileStream);
                        //PdfWriter.GetInstance(pdfDoc, System.Web.HttpContext.Current.Response.OutputStream);

                        //Open PDF Document to write data
                        pdfDoc.Open();

                        //Read string contents using stream reader and convert html to parsed conent
                        XMLWorkerHelper helper = XMLWorkerHelper.GetInstance();
                        using (MemoryStream mStrm = new MemoryStream(Encoding.UTF8.GetBytes(body)))
                        {
                            helper.ParseXHtml(writer, pdfDoc, mStrm, null, Encoding.UTF8, new UnicodeFontFactory());
                        }
                        //Get each array values from parsed elements and add to the PDF document
                        //foreach (var htmlElement in parsedHtmlElements)
                        //    pdfDoc.Add(htmlElement as IElement);

                        //Close your PDF
                        pdfDoc.Close();
                    }
                }



            }
            catch (Exception ex)
            {
                fileName = string.Empty;
                T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessageAndLog(ex);
            }

            return fileName;
        }

        public string HtmlToPDF(string body, List<string> listFileAttach, bool isFix = false)
        {
            string filePath = string.Empty;
            List<string> filePDFTemp = new List<string>();
            try
            {

                //string contents = string.Empty;
                //StreamReader sr;

                //Make HTML
                //if (!body.Contains("height=\"50px\""))
                //{
                //    body = body.Replace("<img", "<img height=\"50px\"");
                //}

                filePath = AppDomain.CurrentDomain.BaseDirectory + @"Pdf\" + Guid.NewGuid().ToString() + ".pdf";
                if (!Directory.Exists(System.IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory + @"Pdf\")))
                {
                    Directory.CreateDirectory(System.IO.Path.GetDirectoryName(filePath));
                }

                body = "<html><head></head><body>" + body + "</body></html>";

                ////Read file from server path
                //sr = File.OpenText(fileHtml);
                ////store content in the variable
                //contents = sr.ReadToEnd();
                //sr.Close();

                if (isFix)
                {
                    body = FixHtml(body);
                }

                using (iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10, 10, 40, 40))
                {

                    using (var existingFileStream = new FileStream(filePath, FileMode.Create))
                    {
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, existingFileStream);
                        //PdfWriter.GetInstance(pdfDoc, System.Web.HttpContext.Current.Response.OutputStream);

                        //Open PDF Document to write data
                        pdfDoc.Open();

                        //Read string contents using stream reader and convert html to parsed conent
                        XMLWorkerHelper helper = XMLWorkerHelper.GetInstance();
                        using (MemoryStream mStrm = new MemoryStream(Encoding.UTF8.GetBytes(body)))
                        {
                            helper.ParseXHtml(writer, pdfDoc, mStrm, null, Encoding.UTF8, new UnicodeFontFactory());
                        }
                        //Get each array values from parsed elements and add to the PDF document
                        //foreach (var htmlElement in parsedHtmlElements)
                        //    pdfDoc.Add(htmlElement as IElement);

                        //Close your PDF
                        pdfDoc.Close();
                    }
                }
                string pDFPath = AppDomain.CurrentDomain.BaseDirectory + @"Pdf";
                if (!Directory.Exists(pDFPath))
                {
                    Directory.CreateDirectory(pDFPath);
                }
                listFileAttach.ForEach(x =>
                {
                    string filename = pDFPath + @"\" + Guid.NewGuid().ToString() + System.IO.Path.GetExtension(x);
                    File.Copy(x, filename);
                    filePDFTemp.Add(filename);
                });

                //Combine to 1 PDF
                if (filePDFTemp != null && filePDFTemp.Count > 0)
                {
                    filePDFTemp.Insert(0, filePath);
                    ConvertToPDF convertPDF = new ConvertToPDF();
                    filePath = convertPDF.Convert(filePDFTemp, pDFPath);
                }
                filePDFTemp.ForEach(x =>
                {
                    if (File.Exists(x))
                    {
                        File.Delete(x);
                    }
                });
                return filePath;
            }
            catch (Exception ex)
            {
                filePath = string.Empty;
                T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessageAndLog(ex);
                T2P._2015.Cross.Utility.Log.Logging.Info(body);
                return filePath;
            }


        }


        //public string HtmlToPDF(string body, List<string> listFileAttach)
        //{
        //    string fileHtml = string.Empty;
        //    List<string> filePDFTemp = new List<string>();
        //    try
        //    {

        //        string contents = string.Empty;
        //        StreamReader sr;

        //        //Make HTML
        //        if (!body.Contains("height=\"50px\""))
        //        {
        //            body = body.Replace("<img", "<img height=\"50px\"");
        //        }

        //        string sourcePath = AppDomain.CurrentDomain.BaseDirectory + @"Pdf\" + Guid.NewGuid().ToString() + ".pdf";
        //        if (!Directory.Exists(System.IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory + @"Pdf\")))
        //        {
        //            Directory.CreateDirectory(System.IO.Path.GetDirectoryName(sourcePath));
        //        }
        //        body = "<html><head></head><body>" + body + "</body><html>";

        //        fileHtml = CreateFileHtml(body);

        //        ////Read file from server path
        //        //sr = File.OpenText(fileHtml);
        //        ////store content in the variable
        //        //contents = sr.ReadToEnd();
        //        //sr.Close();

        //        //Document pdfDoc = new Document(PageSize.A4, 10, 10, 40, 40);

        //        //var existingFileStream = new FileStream(sourcePath, FileMode.Create);
        //        //PdfWriter writer = PdfWriter.GetInstance(pdfDoc, existingFileStream);
        //        ////PdfWriter.GetInstance(pdfDoc, System.Web.HttpContext.Current.Response.OutputStream);

        //        ////Open PDF Document to write data
        //        //pdfDoc.Open();

        //        ////Read string contents using stream reader and convert html to parsed conent
        //        //var parsedHtmlElements = HTMLWorker.ParseToList(new StringReader(body), null);

        //        ////Get each array values from parsed elements and add to the PDF document
        //        //foreach (var htmlElement in parsedHtmlElements)
        //        //    pdfDoc.Add(htmlElement as IElement);

        //        ////Close your PDF
        //        //pdfDoc.Close();

        //        using (iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10, 10, 40, 40))
        //        {

        //            using (var existingFileStream = new FileStream(sourcePath, FileMode.Create))
        //            {
        //                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, existingFileStream);
        //                //PdfWriter.GetInstance(pdfDoc, System.Web.HttpContext.Current.Response.OutputStream);

        //                //Open PDF Document to write data
        //                pdfDoc.Open();

        //                //Read string contents using stream reader and convert html to parsed conent
        //                XMLWorkerHelper helper = XMLWorkerHelper.GetInstance();
        //                using (MemoryStream mStrm = new MemoryStream(Encoding.UTF8.GetBytes(body)))
        //                {
        //                    helper.ParseXHtml(writer, pdfDoc, mStrm, null, Encoding.UTF8, new UnicodeFontFactory());
        //                }
        //                //Get each array values from parsed elements and add to the PDF document
        //                //foreach (var htmlElement in parsedHtmlElements)
        //                //    pdfDoc.Add(htmlElement as IElement);

        //                //Close your PDF
        //                pdfDoc.Close();
        //            }
        //        }

        //        string pDFPath = AppDomain.CurrentDomain.BaseDirectory + @"Pdf\";
        //        if (!Directory.Exists(pDFPath))
        //        {
        //            Directory.CreateDirectory(pDFPath);
        //        }
        //        listFileAttach.ForEach(x =>
        //        {
        //            string filename = pDFPath + Guid.NewGuid().ToString() + System.IO.Path.GetExtension(x);
        //            File.Copy(x, filename);
        //            filePDFTemp.Add(filename);
        //        });

        //        //Combine to 1 PDF
        //        if (filePDFTemp != null && filePDFTemp.Count > 0)
        //        {
        //            filePDFTemp.Insert(0, sourcePath);
        //            ConvertToPDF convertPDF = new ConvertToPDF();
        //            sourcePath = convertPDF.Convert(filePDFTemp, pDFPath);
        //        }
        //        return sourcePath;
        //    }
        //    catch (Exception ex)
        //    {
        //        return string.Empty;
        //    }
        //    finally
        //    {
        //        filePDFTemp.ForEach(x => { if (File.Exists(x)) { File.Delete(x); } });
        //        if (File.Exists(fileHtml))
        //        {
        //            File.Delete(fileHtml);
        //        }
        //    }
        //}

        public string CreateFileHtml(string body)
        {
            string fileName = AppDomain.CurrentDomain.BaseDirectory + @"Pdf\" + Guid.NewGuid().ToString() + ".html";

            StringBuilder html = new StringBuilder();
            html.Append(body);
            Text write = new Text();
            write.WriteText(html, fileName);

            return fileName;
        }

        public string FixHtml(string html)
        {
            HtmlDocument doc = new HtmlDocument();
            html = HttpUtility.HtmlDecode(html);
            doc.LoadHtml(html);
            System.IO.StringWriter sw = new System.IO.StringWriter();
            System.Xml.XmlTextWriter xw = new System.Xml.XmlTextWriter(sw);
            doc.Save(xw);
            return sw.ToString();
        }

        public string FixHtml2(string html)
        {
            HtmlDocument doc = new HtmlDocument();
            html = HttpUtility.HtmlDecode(html);
            doc.LoadHtml(html);
            return doc.DocumentNode.OuterHtml;
        }

        public string ExtractText(string filename)
        {
            string result = string.Empty;

            try
            {
                using (iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(filename))
                {

                    ITextExtractionStrategy Strategy = new iTextSharp.text.pdf.parser.LocationTextExtractionStrategy();

                    for (int i = 1; i <= reader.NumberOfPages; i++)
                    {
                        result = PdfTextExtractor.GetTextFromPage(reader, i, Strategy);

                    }
                }
            }
            catch (Exception)
            {

            }
            //result = System.Web.HttpUtility.HtmlEncode(result);

            return result;

        }

        public static string RemoveClass(string body, string className)
        {
            HtmlDocument document = new HtmlDocument();
            HtmlNode.ElementsFlags["br"] = HtmlElementFlag.Empty;
            HtmlNode.ElementsFlags["img"] = HtmlElementFlag.Empty;
            document.OptionWriteEmptyNodes = true;
            document.LoadHtml(body);
            var nodes = document.DocumentNode.SelectNodes("//*[contains(@class,'" + className + "')]");
            if (nodes != null)
            {
                foreach (HtmlNode row in nodes)
                {

                    row.RemoveAll();
                    row.Remove();
                }
            }
            return document.DocumentNode.OuterHtml;
        }

        public static string ToXML(string fileName)
        {
            string result = fileName + ".xml";
            try
            {

                Aspose.Pdf.Document doc = new Aspose.Pdf.Document(fileName);
                doc.Save(result, Aspose.Pdf.SaveFormat.MobiXml);
                return result;
            }
            catch (Exception ex)
            {
                T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessageAndLog(ex);
                if (File.Exists(result))
                {
                    File.Delete(result);
                }
                return string.Empty;
            }
        }

        public static string ToText(string fileName)
        {
            string result = fileName + ".xml";
            try
            {

                Aspose.Pdf.Document doc = new Aspose.Pdf.Document(fileName);
                //doc.Save(result, Aspose.Pdf.SaveFormat.TeX);


                // Convert the document to a different format and save to stream.
                MemoryStream dstStream = new MemoryStream();
                doc.Save(dstStream, Aspose.Pdf.SaveFormat.Xml);




                result = System.Text.Encoding.UTF8.GetString(dstStream.ToArray());





                return result;
            }
            catch (Exception ex)
            {
                T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessageAndLog(ex);
                if (File.Exists(result))
                {
                    File.Delete(result);
                }
                return string.Empty;
            }

        }

        public static void AddTextToPdf(string inputPdfPath, string outputPdfPath, string textToAdd, int xPos,int yPos, int fontSize = 10, float opacity = 1F)
        {
            //variables
            string pathin = inputPdfPath;
            string pathout = outputPdfPath;
            Point point = new Point(xPos, yPos);
            //create PdfReader object to read from the existing document

            using (FileStream stream = new FileStream(pathin, FileMode.Open, FileAccess.Read))
            {
                using (iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(stream))

                //create PdfStamper object to write to get the pages from reader 
                using (PdfStamper stamper = new PdfStamper(reader, new FileStream(pathout, FileMode.OpenOrCreate)))
                {
                    //select two pages from the original document
                    //reader.SelectPages("1");

                    //gettins the page size in order to substract from the iTextSharp coordinates
                    var pageSize = reader.GetPageSize(1);

                    // PdfContentByte from stamper to add content to the pages over the original content
                    PdfContentByte pbover = stamper.GetOverContent(1);

                    //add content to the page using ColumnText
                    iTextSharp.text.Font font = new iTextSharp.text.Font();
                    font.Size = fontSize;
                    font.Color = BaseColor.BLUE;


                    //setting up the X and Y coordinates of the document
                    int x = point.X;
                    int y = point.Y;

                    //x += 113;
                    y = (int)(pageSize.Height - y);
                    PdfGState gs1 = new PdfGState();
                    gs1.FillOpacity = opacity;

                    pbover.SetGState(gs1);

                    ColumnText.ShowTextAligned(pbover, Element.ALIGN_LEFT, new Phrase(textToAdd, font), x, y, 0);
                }

            }


           
        }
        #region Write file with more page pdf
        /// <summary>
        /// Created By : Duong.Nguyen
        /// Created Date : 16.06.2017
        /// Description: Write file with more page pdf
        /// </summary>
        public static void AddTextToPdfMorePage(string inputPdfPath, string outputPdfPath, string textToAdd, int xPoint, int yPoint, int fontSize = 10, float opacity = 1F)
        {
           
            string pathIn = inputPdfPath;
            string pathOut = outputPdfPath;
            Point point = new Point(xPoint, yPoint);
            using (FileStream stream = new FileStream(pathIn, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new iTextSharp.text.pdf.PdfReader(stream))
                {
                    using (var fileStream = new FileStream(pathOut, FileMode.Create, FileAccess.Write))
                    {
                        var newDocument = new Document(reader.GetPageSizeWithRotation(1));
                        var writer = PdfWriter.GetInstance(newDocument, fileStream);

                        newDocument.Open();

                        for (var i = 1; i <= reader.NumberOfPages; i++)
                        {
                            newDocument.NewPage();
                            var getSizePage = reader.GetPageSize(1); // get size page 

                            var getPageTemp = writer.GetImportedPage(reader, i);

                            PdfContentByte pdfContentByte = writer.DirectContent;
                            pdfContentByte.BeginText();

                            iTextSharp.text.Font font = new iTextSharp.text.Font();
                            font.Size = 10;
                            font.Color = BaseColor.BLUE;

                            int xPos = point.X;
                            int yPos = point.Y;

                            yPos = (int)(getSizePage.Height - yPos); //Postion x - y
                            ColumnText.ShowTextAligned(pdfContentByte, Element.ALIGN_LEFT, new Phrase(textToAdd, font), xPos, yPos, 0);

                            pdfContentByte.EndText();
                            pdfContentByte.AddTemplate(getPageTemp, 0, 0);
                        }

                        newDocument.Close();
                        writer.Close();
                    }
                }
            }



        }
        #endregion
    }
    public class ConvertToPDF
    {

        public List<string> SplitPDF(string destinyFolderPath, string pdfFilePath, string fileName)
        {
            try
            {
                if (!Directory.Exists(destinyFolderPath))
                {
                    Directory.CreateDirectory(destinyFolderPath);
                }
                List<string> result = new List<string>();
                PdfSharp.Pdf.PdfDocument inputPDFDocument = PdfSharp.Pdf.IO.PdfReader.Open(pdfFilePath, PdfDocumentOpenMode.Import);
                for (int i = 0; i < inputPDFDocument.Pages.Count; i++)
                {
                    PdfSharp.Pdf.PdfDocument outputPDFDocument = new PdfSharp.Pdf.PdfDocument();
                    outputPDFDocument.Version = inputPDFDocument.Version;
                    PdfSharp.Pdf.PdfPage page = inputPDFDocument.Pages[i];
                    outputPDFDocument.AddPage(page);
                    int temp = i + 1;
                    string fileSplit = System.IO.Path.GetDirectoryName(destinyFolderPath) + @"\" + fileName + "_" + temp + System.IO.Path.GetExtension(pdfFilePath);
                    outputPDFDocument.Save(fileSplit);
                    result.Add(fileSplit);
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public int PDFCountPages(string fileName)
        {
            try
            {
                int count = 0;
                PdfSharp.Pdf.PdfDocument outputPDFDocument = new PdfSharp.Pdf.PdfDocument();
                PdfSharp.Pdf.PdfDocument inputPDFDocument = PdfSharp.Pdf.IO.PdfReader.Open(fileName, PdfDocumentOpenMode.Import);
                outputPDFDocument.Version = inputPDFDocument.Version;
                count = inputPDFDocument.Pages.Count;
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SplitPDFPage(string fileConvert, string fileName, int pageNumber)
        {
            try
            {
                SplitPDF(fileConvert, fileName, pageNumber - 1, pageNumber);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SplitPDFPage(string fileConvert, string fileName, int from, int to)
        {
            try
            {
                SplitPDF(fileConvert, fileName, from - 1, to);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void SplitPDF(string fileConvert, string fileName, int min, int max)
        {
            try
            {
                PdfSharp.Pdf.PdfDocument outputPDFDocument = new PdfSharp.Pdf.PdfDocument();
                PdfSharp.Pdf.PdfDocument inputPDFDocument = PdfSharp.Pdf.IO.PdfReader.Open(fileName, PdfDocumentOpenMode.Import);
                outputPDFDocument.Version = inputPDFDocument.Version;

                for (int i = min; i < max; i++)
                {
                    PdfSharp.Pdf.PdfPage page = inputPDFDocument.Pages[i];
                    outputPDFDocument.AddPage(page);
                }
                outputPDFDocument.Save(fileConvert);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void MutiPDFToPDF(List<string> listPDF, string fileDestination)
        {
            try
            {
                PdfSharp.Pdf.PdfDocument outputPDFDocument = new PdfSharp.Pdf.PdfDocument();
                foreach (string pdfFile in listPDF)
                {
                    PdfSharp.Pdf.PdfDocument inputPDFDocument = PdfSharp.Pdf.IO.PdfReader.Open(pdfFile, PdfDocumentOpenMode.Import);
                    outputPDFDocument.Version = inputPDFDocument.Version;
                    foreach (PdfSharp.Pdf.PdfPage page in inputPDFDocument.Pages)
                    {
                        outputPDFDocument.AddPage(page);
                    }
                }
                outputPDFDocument.Save(fileDestination);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string Convert(List<string> listFileAttach, string folderDes)
        {
            try
            {
                if (listFileAttach.Count == 0)
                {
                    return null;
                }
                List<string> listFileConvert = new List<string>();
                List<string> listTiffConvert = new List<string>();

                for (int i = 0; i < listFileAttach.Count; i++)
                {
                    string extension = System.IO.Path.GetExtension(listFileAttach[i].ToLower());
                    string fileConvert = System.IO.Path.GetDirectoryName(listFileAttach[i]) + @"\" + System.IO.Path.GetFileNameWithoutExtension(listFileAttach[i]) + i + ".pdf";
                    switch (extension)
                    {
                        case ".docx":
                        case ".doc":
                        case ".rtf":
                        case ".wps":
                        case ".xls":
                        case ".xlsx":
                            //OfficeToPDF.ConvertToPDF(listFileAttach[i], fileConvert);
                            //listFileConvert.Add(fileConvert);
                            break;
                        case ".png":
                        case ".jpg":
                        case ".jpeg":
                        case ".gif":
                        case ".bmp":
                            List<string> fileTemp = new List<string>();
                            fileTemp.Add(listFileAttach[i]);
                            ImageToPDF(listFileConvert, fileConvert, fileTemp);
                            break;
                        case ".tiff":
                        case ".tif":
                            listTiffConvert.AddRange(TiffToPDF(listFileAttach[i], listFileConvert, fileConvert));
                            break;
                        case ".pdf":
                        case ".fdf":
                            PDFToPDF(listFileAttach[i], listFileConvert, fileConvert);
                            break;
                        default:

                            break;
                    }
                }
                string fileConvertComplete = string.Empty;
                if (listFileConvert.Count > 0)
                {
                    fileConvertComplete = folderDes + @"\T2P_" + System.IO.Path.GetFileNameWithoutExtension(listFileAttach[0]) + "Convert.pdf";

                    MutiPDFToPDF(listFileConvert, fileConvertComplete);
                    DeleteFileTemp(listFileConvert, listTiffConvert);
                }
                else
                {
                    //ToolSendEmail toolSendEmail = new ToolSendEmail();
                    //toolSendEmail.SendMailMessage("Could not convert file", "");
                }
                return fileConvertComplete;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string Convert2(List<string> listFileAttach, string folderDes)
        {
            try
            {
                if (listFileAttach.Count == 0)
                {
                    return null;
                }
                List<string> listFileConvert = new List<string>();
                List<string> listTiffConvert = new List<string>();

                for (int i = 0; i < listFileAttach.Count; i++)
                {
                    string extension = System.IO.Path.GetExtension(listFileAttach[i].ToLower());
                    string fileConvert = System.IO.Path.GetDirectoryName(listFileAttach[i]) + @"\" + System.IO.Path.GetFileNameWithoutExtension(listFileAttach[i]) + i + ".pdf";
                    switch (extension)
                    {
                        case ".docx":
                        case ".doc":
                        case ".rtf":
                        case ".wps":
                        case ".xls":
                        case ".xlsx":
                            //OfficeToPDF.ConvertToPDF(listFileAttach[i], fileConvert);
                            //listFileConvert.Add(fileConvert);
                            break;
                        case ".png":
                        case ".jpg":
                        case ".jpeg":
                        case ".gif":
                        case ".bmp":
                            List<string> fileTemp = new List<string>();
                            fileTemp.Add(listFileAttach[i]);
                            ImageToPDF(listFileConvert, fileConvert, fileTemp);
                            break;
                        case ".tiff":
                        case ".tif":
                            listTiffConvert.AddRange(TiffToPDF(listFileAttach[i], listFileConvert, fileConvert));
                            break;
                        case ".pdf":
                        case ".fdf":
                            PDFToPDF(listFileAttach[i], listFileConvert, fileConvert);
                            break;
                        default:

                            break;
                    }
                }
                string fileConvertComplete = string.Empty;
                if (listFileConvert.Count > 0)
                {
                    fileConvertComplete = folderDes + "T2P_" + Guid.NewGuid().ToString() + "_" + DateTime.Now.ToString(@"yyyyMMddHHmmssfff") + "Convert.pdf";

                    MutiPDFToPDF(listFileConvert, fileConvertComplete);
                    DeleteFileTemp(listFileConvert, listTiffConvert);
                }
                else
                {
                    //ToolSendEmail toolSendEmail = new ToolSendEmail();
                    //toolSendEmail.SendMailMessage("Could not convert file", "");
                }
                return fileConvertComplete;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void DeleteFileTemp(List<string> listFileConvert, List<string> listTiffConvert)
        {
            try
            {
                foreach (string fifle in listFileConvert)
                {
                    if (File.Exists(fifle))
                    {

                        File.Delete(fifle);
                    }
                }
                foreach (string fifle in listTiffConvert)
                {
                    if (File.Exists(fifle))
                    {

                        File.Delete(fifle);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void PDFToPDF(string listFileAttach, List<KeyValuePair<long, string>> listFileConvert, string fileConvert, long imageID)
        {
            try
            {
                PdfSharp.Pdf.PdfDocument outputPDFDocument = new PdfSharp.Pdf.PdfDocument();
                PdfSharp.Pdf.PdfDocument inputPDFDocument = PdfSharp.Pdf.IO.PdfReader.Open(listFileAttach, PdfDocumentOpenMode.Import);
                outputPDFDocument.Version = inputPDFDocument.Version;
                foreach (PdfSharp.Pdf.PdfPage page in inputPDFDocument.Pages)
                {
                    outputPDFDocument.AddPage(page);
                }
                outputPDFDocument.Save(fileConvert);
                listFileConvert.Add(new KeyValuePair<long, string>(imageID, fileConvert));
            }
            catch (Exception ex)
            {
                try
                {
                    CreateTiffFromPdf(listFileAttach, fileConvert);
                    listFileConvert.Add(new KeyValuePair<long, string>(imageID, fileConvert));
                }
                catch (Exception dx)
                {
                    throw dx;
                }
                //log.Info(LogNameBusiness.ConvertError + version + ExceptionMessage.throwEx(ex, "ERROR_FrmAutoService: PDFToPDF"));
            }
        }

        public void PDFToPDF(string listFileAttach, List<string> listFileConvert, string fileConvert)
        {
            try
            {
                PdfSharp.Pdf.PdfDocument outputPDFDocument = new PdfSharp.Pdf.PdfDocument();
                PdfSharp.Pdf.PdfDocument inputPDFDocument = PdfSharp.Pdf.IO.PdfReader.Open(listFileAttach, PdfDocumentOpenMode.Import);
                outputPDFDocument.Version = inputPDFDocument.Version;
                foreach (PdfSharp.Pdf.PdfPage page in inputPDFDocument.Pages)
                {
                    outputPDFDocument.AddPage(page);
                }
                outputPDFDocument.Save(fileConvert);
                listFileConvert.Add(fileConvert);
            }
            catch (Exception ex)
            {
                try
                {
                    CreateTiffFromPdf(listFileAttach, fileConvert);
                    listFileConvert.Add(fileConvert);
                }
                catch (Exception dx)
                {
                    throw dx;
                }
                //log.Info(LogNameBusiness.ConvertError + version + ExceptionMessage.throwEx(ex, "ERROR_FrmAutoService: PDFToPDF"));
            }
        }
        public void CreateTiffFromPdf(string listFileAttach, string fileConvert)
        {
            try
            {
                FileStream stream = File.OpenRead(listFileAttach);

                byte[] fileArray = new byte[stream.Length];
                stream.Read(fileArray, 0, fileArray.Length);
                MemoryStream sourceStream = new MemoryStream(fileArray);
                stream.Close();
                stream.Dispose();
                MemoryStream outputStream = null;
                PdfSharp.Pdf.PdfDocument pdfDoc = null;
                sourceStream.Position = 0;
                outputStream = new MemoryStream();
                iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(sourceStream);
                iTextSharp.text.pdf.PdfStamper pdfStamper = new iTextSharp.text.pdf.PdfStamper(reader, outputStream);
                pdfStamper.FormFlattening = true;
                pdfStamper.Writer.SetPdfVersion(iTextSharp.text.pdf.PdfWriter.PDF_VERSION_1_4);
                pdfStamper.Writer.CloseStream = false;
                pdfStamper.Close();
                //pdfDoc = PdfReader.Open(outputStream);
                //for (int i = 0; i < pdfDoc.PageCount; i++)
                //{
                //    pdfDoc.Pages[i].Width = pdfDoc.Pages[i].Width * 2;
                //    pdfDoc.Pages[i].Height = pdfDoc.Pages[i].Height * 2;
                //}
                //pdfDoc.Save(fileConvert);
                using (FileStream file = new FileStream(fileConvert, FileMode.Create, FileAccess.Write))
                {
                    outputStream.WriteTo(file);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<string> TiffToPDF(string fileAttach, List<string> listFileConvert, string fileConvert)
        {
            try
            {
                List<string> listImage = SplitTIFF(fileAttach);
                ImageToPDF(listFileConvert, fileConvert, listImage);
                return listImage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private static void ImageToPDF(List<string> listFileConvert, string fileConvert, List<string> listImage)
        {
            try
            {
                PdfSharp.Pdf.PdfDocument doc = new PdfSharp.Pdf.PdfDocument();
                for (int i = 0; i < listImage.Count; i++)
                {
                    doc.Pages.Add(new PdfSharp.Pdf.PdfPage());
                    XGraphics xgr = XGraphics.FromPdfPage(doc.Pages[i]);
                    FileStream stream = new FileStream(listImage[i], FileMode.Open, FileAccess.Read);
                    Bitmap temp = (Bitmap)System.Drawing.Image.FromStream(stream);

                    double Height = temp.Height;
                    if (temp.HorizontalResolution < temp.VerticalResolution)
                    {

                        if (temp.Width > temp.Height)
                        {
                            Height = temp.Width * 3 / 4;
                            //y.Inch = x.Inch * 3 / 4;
                        }
                        else
                        {
                            Height = temp.Width * 3 / 4;
                        }
                    }
                    else
                    {

                        if (temp.HorizontalResolution > temp.VerticalResolution)
                        {

                            if (temp.Width > temp.Height)
                            {
                                //y.Inch = x.Inch * 4 / 3;
                                Height = temp.Width * 4 / 3;
                            }
                        }
                    }

                    if (Height < temp.Width)
                    {
                        temp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        Height = temp.Width * 4 / 3;
                    }
                    XImage img = XImage.FromGdiPlusImage(temp);
                    XUnit x = new XUnit();
                    x.Inch = (double)img.Width / (double)110;
                    XUnit y = new XUnit(); ;
                    y.Inch = (double)Height / (double)110;

                    doc.Pages[i].Width = x;
                    doc.Pages[i].Height = y;
                    //xgr.DrawImage(img, 0, 0, x, y);
                    XRect xrect = new XRect();

                    //xrect.Height = img.Height;
                    //xrect.Width = img.Height;

                    xrect = new XRect(0, 0, doc.Pages[i].Width, doc.Pages[i].Height);
                    //xgr.DrawImage(img, xrect, xrect,srcUnit);
                    xgr.DrawImage(img, xrect);
                    stream.Close();

                }
                doc.Save(fileConvert);
                doc.Close();
                listFileConvert.Add(fileConvert);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void RotatePDF(string fileRotate, List<int> listPageNumber, int Rotate)
        {
            try
            {
                PdfSharp.Pdf.PdfDocument outputPDFDocument = new PdfSharp.Pdf.PdfDocument();
                FileStream stream = new FileStream(fileRotate, FileMode.Open, FileAccess.Read);
                PdfSharp.Pdf.PdfDocument inputPDFDocument = PdfSharp.Pdf.IO.PdfReader.Open(stream, PdfDocumentOpenMode.Modify);
                foreach (int PageNumber in listPageNumber)
                {
                    inputPDFDocument.Pages[PageNumber - 1].Rotate = (inputPDFDocument.Pages[PageNumber - 1].Rotate + Rotate) % 360;
                    inputPDFDocument.Pages[PageNumber - 1].Orientation = PdfSharp.PageOrientation.Portrait;
                }
                stream.Close();
                inputPDFDocument.Save(fileRotate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool RotatePDF(string fileRotate, int Rotate)
        {
            try
            {
                PdfSharp.Pdf.PdfDocument outputPDFDocument = new PdfSharp.Pdf.PdfDocument();
                FileStream stream = new FileStream(fileRotate, FileMode.Open, FileAccess.Read);
                PdfSharp.Pdf.PdfDocument inputPDFDocument = PdfSharp.Pdf.IO.PdfReader.Open(stream, PdfDocumentOpenMode.Modify);
                for (int i = 0; i < inputPDFDocument.Pages.Count; i++)
                {
                    inputPDFDocument.Pages[i].Rotate = (inputPDFDocument.Pages[i].Rotate + Rotate) % 360;
                    inputPDFDocument.Pages[i].Orientation = PdfSharp.PageOrientation.Portrait;
                }
                stream.Close();
                inputPDFDocument.Save(fileRotate);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
        public bool RotatePDF(string fileRotate, int[] pages, int Rotate)
        {
            try
            {
                PdfSharp.Pdf.PdfDocument outputPDFDocument = new PdfSharp.Pdf.PdfDocument();
                FileStream stream = new FileStream(fileRotate, FileMode.Open, FileAccess.Read);
                PdfSharp.Pdf.PdfDocument inputPDFDocument = PdfSharp.Pdf.IO.PdfReader.Open(stream, PdfDocumentOpenMode.Modify);
                for (int i = 0; i < pages.Length; i++)
                {
                    inputPDFDocument.Pages[pages[i] - 1].Rotate = (inputPDFDocument.Pages[pages[i] - 1].Rotate + Rotate) % 360;
                    inputPDFDocument.Pages[pages[i] - 1].Orientation = PdfSharp.PageOrientation.Portrait;
                }
                stream.Close();
                inputPDFDocument.Save(fileRotate);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
        private List<string> SplitTIFF(string fileTiff)
        {
            try
            {
                System.Drawing.Image pagestmp = null;
                List<string> InPathFilesTMP = new List<string>();
                FileStream stream = new FileStream(fileTiff, FileMode.Open, FileAccess.Read);
                pagestmp = System.Drawing.Image.FromStream(stream);
                Guid objGuid = (Guid)pagestmp.FrameDimensionsList[0];
                FrameDimension objDimension = new FrameDimension(objGuid);
                //'Gets the total number of frames in the .tiff file
                int totalFrame = pagestmp.GetFrameCount(objDimension);
                for (int i = 0; i < totalFrame; i++)
                {
                    pagestmp.SelectActiveFrame(objDimension, i);
                    //save the first frame
                    pagestmp.Save(fileTiff + i + ".tif", System.Drawing.Imaging.ImageFormat.Tiff);
                    InPathFilesTMP.Add(fileTiff + i + ".tif");
                }
                stream.Close();
                pagestmp.Dispose();
                return InPathFilesTMP;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteFile(List<string> listFilePDF)
        {
            try
            {
                foreach (string filePDF in listFilePDF)
                {
                    if (File.Exists(filePDF))
                    {
                        System.IO.File.Delete(filePDF);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ChangetSizePDF(string fileOriginal, string fileModify)
        {
            iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A6, 0, 0, 0, 0);
            iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(fileOriginal);


            var mediabox = reader.GetPageSize(1);
            var cropbox = reader.GetCropBox(1);
            float ratioChange = 1;
            float widthNew = 0;
            float heightNew = 0;

            if (mediabox.Height > mediabox.Width)
            {
                if (mediabox.Width / mediabox.Height < 0.1)
                {
                    ratioChange = 1;
                }
                else
                {
                    ratioChange = iTextSharp.text.PageSize.A6.Width / mediabox.Width;
                }

            }
            else
            {
                if (mediabox.Height / mediabox.Width < 0.1)
                {
                    ratioChange = 1;
                }
                else
                {
                    ratioChange = iTextSharp.text.PageSize.A6.Height / mediabox.Height;
                }
            }

            widthNew = (int)(mediabox.Width * ratioChange);
            heightNew = (int)(mediabox.Height * ratioChange);
            document = new iTextSharp.text.Document(new iTextSharp.text.Rectangle(widthNew, heightNew), 0, 0, 0, 0);


            // Create a new PdfWriter object, specifying the output stream
            System.IO.FileStream file = new System.IO.FileStream(fileModify, System.IO.FileMode.Create);
            iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(document, file);

            // Open the Document for writing
            document.Open();


            for (int k = 1; k <= reader.NumberOfPages; k++)
            {
                document.NewPage();
                // invoice image                                  
                iTextSharp.text.pdf.PdfImportedPage page = writer.GetImportedPage(reader, k);

                int pageRotation = reader.GetPageRotation(k);


                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(page);

                image.SetDpi(300, 300);

                image.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                image.Alignment = iTextSharp.text.Image.ALIGN_MIDDLE;

                switch (pageRotation)
                {
                    case 0:
                        image.RotationDegrees = 0f;
                        break;
                    case 90:
                        image.RotationDegrees = 360f - 90f;
                        break;
                    case 180:
                        image.RotationDegrees = 360f - 180f;
                        break;
                    case 270:
                        image.RotationDegrees = 360f - 270f;
                        break;
                    default:
                        image.RotationDegrees = 360f - pageRotation;
                        break;
                }
                image.Rotate();
                // fix image is full of A4 page
                image.ScaleToFit(document.PageSize.Width, document.PageSize.Height);

                document.Add(image);



            }
            // Close the Document - this saves the document contents to the output stream
            document.Close();
            reader.Close();
            writer.Close();
            file.Close();
        }


    }

    public class UnicodeFontFactory : FontFactoryImp
    {
        private static readonly string FontPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts),
        "arial.ttf");
        private readonly BaseFont _baseFont;
        public UnicodeFontFactory()
        {
            _baseFont = BaseFont.CreateFont(FontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
        }
        public override iTextSharp.text.Font GetFont(string fontname, string encoding, bool embedded, float size, int style, BaseColor color,
        bool cached)
        {
            return new iTextSharp.text.Font(_baseFont, size, style, color);
        }
    }


    public class HtmlToPDFForBillingEmail
    {

        public string ConvertHtmlToPdf(string location, string folder, string fileName, string htmlText, string emailTypeAndID = "")
        {
            try
            {
                Byte[] bytes;

                if (!string.IsNullOrWhiteSpace(htmlText))
                {
                    htmlText = htmlText.Replace("&nbsp;", " ")
                                        .Replace("<blockquote", "<div")
                                        .Replace("</blockquote>", "</div>")
                                        .Replace("</BLOCKQUOTE>", "</div>")
                                        .Replace("<BLOCKQUOTE", "<div");
                    htmlText = ReplaceSpecicalCharacter(htmlText);
                }

                HtmlDocument htmlDoc = new HtmlDocument();

                htmlDoc.LoadHtml(htmlText);

                //Convert HTML to well-formed XHTML

                htmlDoc.OptionFixNestedTags = true;

                htmlDoc.OptionOutputAsXml = true;

                htmlDoc.OptionCheckSyntax = true;


                HtmlNode bodyNode = htmlDoc.DocumentNode;

                htmlText = bodyNode.WriteTo();


                //Create a byte array that will hold final PDF

                var ms = new MemoryStream();

                var doc = new Document(PageSize.A4, 5f, 5f, 30f, 30f);


                var writer = PdfWriter.GetInstance(doc, ms);

                writer.CloseStream = false;

                var srHtml = new StringReader(htmlText);


                //Open the document for writing
                doc.Open();

                //Add support for embeded images

                var tagProcessors = (DefaultTagProcessorFactory)Tags.GetHtmlTagProcessorFactory();

                tagProcessors.RemoveProcessor(HTML.Tag.IMG);

                tagProcessors.AddProcessor(HTML.Tag.IMG, new CustomImageTagProcessor());

                HtmlPipelineContext htmlContext = new HtmlPipelineContext(null);
                htmlContext.SetTagFactory(tagProcessors);

                ICSSResolver cssResolver = XMLWorkerHelper.GetInstance().GetDefaultCssResolver(true);

                IPipeline pipeline = new CssResolverPipeline(cssResolver, new HtmlPipeline(htmlContext, new PdfWriterPipeline(doc, writer)));

                XMLWorker worker = new XMLWorker(pipeline, true);
                XMLParser xmlParser = new XMLParser(true, worker, Encoding.Unicode);

                xmlParser.Parse(srHtml);


                //Close your PDF
                doc.Close();

                srHtml.Close();

                doc.Close();

                writer.Close();

                doc.Close();

                bytes = ms.ToArray();

                ms.Close();

                //Now we just need to do something with those bytes.
                string folderPath = location + "\\" + folder;
                string filePath = location + "\\" + folder + "\\" + fileName;
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                System.IO.File.WriteAllBytes(filePath, bytes);
            }
            catch (Exception ex)
            {
                fileName = string.Empty;
                T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessageAndLog(ex, MethodInfo.GetCurrentMethod(), emailTypeAndID);
                //T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessageAndLog(ex);
            }

            return fileName;
        }


        public string ConvertTextToPDF(string textFilePath, string pdfFilePath, string emailTypeAndID = "")
        {
            try
            {
                //Read the Data from Input File

                StreamReader rdr = new StreamReader(textFilePath);

                //Create a New instance on Document Class

                Document doc = new Document();

                //Create a New instance of PDFWriter Class for Output File

                PdfWriter.GetInstance(doc, new FileStream(pdfFilePath, FileMode.Create));

                //Open the Document

                doc.Open();

                //Add the content of Text File to PDF File

                doc.Add(new Paragraph(rdr.ReadToEnd()));

                //Close the Document

                doc.Close();

                rdr.Close();

                rdr.Dispose();
            }
            catch (Exception ex)
            {
                pdfFilePath = string.Empty;
                T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessageAndLog(ex, MethodInfo.GetCurrentMethod(), emailTypeAndID);
            }
            return pdfFilePath;
        }

        public string ReplaceSpecicalCharacter(string text)
        {
            var ressult = string.Empty;
            ressult = text.Replace("&#43;", "+")
                            .Replace("&#8211;", "–")
                            .Replace("&#8212;", "—")
                            .Replace("&#161;", "¡")
                            .Replace("&#191;", "¿")
                            .Replace("&#34;", "\"")
                            .Replace("&#8220;", "“")
                            .Replace("&#8221;", "”")
                            .Replace("&#39;", "'")
                            .Replace("&#8216;", "‘")
                            .Replace("&#8217;", "’")
                            .Replace("&#171;", "«")
                            .Replace("&#187;", "»")
                            .Replace("&#160;", "")
                            .Replace("&#38;", "&")
                            .Replace("&#162;", "¢")
                            .Replace("&#169;", "©")
                            .Replace("&#247;", "÷")
                            .Replace("&#62;", ">")
                            .Replace("&#60;", "<")
                            .Replace("&#181;", "µ")
                            .Replace("&#183;", "·")
                            .Replace("&#182;", "¶")
                            .Replace("&#177;", "±")
                            .Replace("&#8364;", "€")
                            .Replace("&#163;", "£")
                            .Replace("&#174;", "®")
                            .Replace("&#167;", "§")
                            .Replace("&#153;", "™")
                            .Replace("&#165;", "¥")
                            .Replace("&#176;", "°")
                            .Replace("&#225;", "á")
                            .Replace("&#193;", "Á")
                            .Replace("&#224;", "à")
                            .Replace("&#192;", "À")
                            .Replace("&#226;", "â")
                            .Replace("&#194;", "Â")
                            .Replace("&#229;", "å")
                            .Replace("&#197;", "Å")
                            .Replace("&#227;", "ã")
                            .Replace("&#195;", "Ã")
                            .Replace("&#228;", "ä")
                            .Replace("&#196;", "Ä")
                            .Replace("&#230;", "æ")
                            .Replace("&#198;", "Æ")
                            .Replace("&#231;", "ç")
                            .Replace("&#199;", "Ç")
                            .Replace("&#233;", "é")
                            .Replace("&#201;", "É")
                            .Replace("&#232;", "è")
                            .Replace("&#200;", "È")
                            .Replace("&#234;", "ê")
                            .Replace("&#202;", "Ê")
                            .Replace("&#235;", "ë")
                            .Replace("&#203;", "Ë")
                            .Replace("&#237;", "í")
                            .Replace("&#205;", "Í")
                            .Replace("&#236;", "ì")
                            .Replace("&#204;", "Ì")
                            .Replace("&#238;", "î")
                            .Replace("&#206;", "Î")
                            .Replace("&#239;", "ï")
                            .Replace("&#207;", "Ï")
                            .Replace("&#241;", "ñ")
                            .Replace("&#209;", "Ñ")
                            .Replace("&#243;", "ó")
                            .Replace("&#211;", "Ó")
                            .Replace("&#242;", "ò")
                            .Replace("&#210;", "Ò")
                            .Replace("&#244;", "ô")
                            .Replace("&#212;", "Ô")
                            .Replace("&#248;", "ø")
                            .Replace("&#216;", "Ø")
                            .Replace("&#245;", "õ")
                            .Replace("&#213;", "Õ")
                            .Replace("&#246;", "ö")
                            .Replace("&#214;", "Ö")
                            .Replace("&#223;", "ß")
                            .Replace("&#250;", "ú")
                            .Replace("&#218;", "Ú")
                            .Replace("&#249;", "ù")
                            .Replace("&#217;", "Ù")
                            .Replace("&#251;", "û")
                            .Replace("&#219;", "Û")
                            .Replace("&#252;", "ü")
                            .Replace("&#220;", "Ü")
                            .Replace("&#255;", "ÿ")
                            .Replace("&#180;", "´")
                            .Replace("&#96;", "`");



            return ressult;
        }
    }

    public class CustomImageTagProcessor : iTextSharp.tool.xml.html.Image
    {

        public override IList<IElement> End(IWorkerContext ctx, Tag tag, IList<IElement> currentContent)
        {

            IDictionary<string, string> attributes = tag.Attributes;

            string src;

            if (!attributes.TryGetValue(HTML.Attribute.SRC, out src))

                return new List<IElement>(1);


            if (string.IsNullOrEmpty(src))

                return new List<IElement>(1);


            if (src.StartsWith("data:image/", StringComparison.InvariantCultureIgnoreCase))
            {

                // data:[<MIME-type>][;charset=<encoding>][;base64],<data>

                var base64Data = src.Substring(src.IndexOf(",") + 1);

                var imagedata = Convert.FromBase64String(base64Data);

                var image = iTextSharp.text.Image.GetInstance(imagedata);

                //image.ScaleToFitLineWhenOverflow = true;

                image.Alignment = iTextSharp.text.Image.ALIGN_LEFT | iTextSharp.text.Image.TEXTWRAP;


                var list = new List<IElement>();

                var htmlPipelineContext = GetHtmlPipelineContext(ctx);

                list.Add(GetCssAppliers().Apply(new Chunk((iTextSharp.text.Image)GetCssAppliers().Apply(image, tag, htmlPipelineContext), 0, 0, true), tag, htmlPipelineContext));

                return list;

            }

            else
            {

                return base.End(ctx, tag, currentContent);

            }

        }

    }
}