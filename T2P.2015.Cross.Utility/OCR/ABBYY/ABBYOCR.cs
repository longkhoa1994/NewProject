using T2P._2015.Cross.Utility.OCR.ABBYY;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Utility.OCR;

namespace T2P._2015.Cross.Utility.OCR
{
    public class ABBYYOCR
    {
        List<CustomPage> PageItems { get; set; }

        public List<int> DetectRotation(string sourceImagePath)
        {
            using (Processor processor = new Processor())
            {
                return processor.DetectRotate(sourceImagePath);
            }
        }

        public RecognitionStatistics Run(string sourceImagePath,  string language = "English", bool exportImage = false, bool drawTable = false, bool drawBlock = false, bool drawLine = false)
        {
            try
            {
                using (Processor processor = new Processor())
                {

                    ProcessingSettings initialSettings = new ProcessingSettings();
                    initialSettings.IsRecognize = true;//recognitionCheckBox.Checked;
                    initialSettings.Language = language;//languageComboBox.Text;

                    ProcessingSettings modifiedSettings = new ProcessingSettings();
                    modifiedSettings.IsRecognize = true;// recognitionCheckBox.Checked;
                    modifiedSettings.Language = language;//languageComboBox.Text;
                    modifiedSettings.CropImage = false;//cropImageCheckBox.Checked;
                    modifiedSettings.EnhanceLocalContrast = false;//enhanceContrastCheckBox.Checked;
                    modifiedSettings.DeskewImage = true;//deskewImageCheckBox.Checked;
                    //if (correctOrientationCheckBox.Checked)
                    //{
                    modifiedSettings.CorrectOrientationMode = (ProcessingSettings.OrientationCorrectionMode)ProcessingSettings.OrientationCorrectionMode.Automatic;
                    //}
                    //else
                    //{
                    //    modifiedSettings.CorrectOrientationMode = ProcessingSettings.OrientationCorrectionMode.None;
                    //}
                    //if (removeGarbageCheckBox.Checked)
                    //{
                    modifiedSettings.RemoveGarbage = true;
                    int size = 0;//garbageUpDown.Value;
                    modifiedSettings.GarbageSize = size == 0 ? -1 : size;
                    //}
                    //else
                    //{
                    //    modifiedSettings.RemoveGarbage = false;
                    //}
                    //if (correctResolutionCheckBox.Checked)
                    //{
                    modifiedSettings.CorrectResolution = true;
                    modifiedSettings.NewResolution = 0;//(int)resolutionUpDown.Value;
                    //}
                    //else
                    //{
                    //    modifiedSettings.CorrectResolution = false;
                    //}
                    modifiedSettings.SplitPages = false;//splitPagesCheckBox.Checked;
                    modifiedSettings.SplitBusinessCards = false;//splitBusinessCardsCheckBox.Checked;
                    modifiedSettings.InvertImage = false;//invertImageCheckBox.Checked;
                    //if (suppressColorCheckBox.Checked)
                    //{
                    //    modifiedSettings.SuppressColor = true;
                    //    modifiedSettings.HslHueToSuppress = (byte)hueUpDown.Value;
                    //    modifiedSettings.HslSaturationBoundaryToSuppress = (byte)saturationBoundaryUpDown.Value;
                    //}
                    //else
                    //{
                    modifiedSettings.SuppressColor = false;
                    //}
                    //if (removeObjectsCheckBox.Checked)
                    //{
                    //    modifiedSettings.RemoveObjects = true;
                    //    modifiedSettings.ColorToRemove = (ProcessingSettings.ObjectsColorEnum)colorComboBox.SelectedItem;
                    //    modifiedSettings.ObjectsTypeToRemove = (ProcessingSettings.ObjectsTypeEnum)typeComboBox.SelectedItem;
                    //}
                    //else
                    //{
                    modifiedSettings.RemoveObjects = false;
                    //}
                    modifiedSettings.CorrectDistortions = false;//correctDistortionsCheckBox.Checked;
                    modifiedSettings.RemoveNoise = false;//removeNoiseCheckBox.Checked;
                    //if (noiseModelComboBox.Text == "White noise")
                    //{
                    //    modifiedSettings.NoiseModel = FREngine.NoiseModelEnum.NM_WhiteNoise;
                    //}
                    //else
                    //{
                    //    modifiedSettings.NoiseModel = FREngine.NoiseModelEnum.NM_CorrelatedNoise;
                    //}
                    modifiedSettings.HasLargeCharacters = false;// hasLargeCharactersCheckBox.Checked;
                    modifiedSettings.RemoveMotionBlur = false;//removeMotionBlurCheckBox.Checked;
                    //if (convertToBWCheckBox.Checked)
                    //{
                    modifiedSettings.ConvertToBW = true;
                    modifiedSettings.EnableDithering = true;//enableDitheringCheckBox.Checked;
                    //}
                    //else
                    //{
                    //    modifiedSettings.ConvertToBW = false;
                    //}
                    modifiedSettings.SmoothTexture = true;//smoothTextureCheckBox.Checked;
                    modifiedSettings.EqualizeBrightness = true;// equalizeBrightnessCheckBox.Checked;
                    modifiedSettings.MakeWhiteBackground = true;// makeWhiteBackgroundCheckBox.Checked;

                    processor.WarmUp(sourceImagePath, modifiedSettings);

                    //processor.Process(sourceImagePath, initialSettings);





                    RecognitionStatistics modifiedStatic = processor.Process(sourceImagePath,  modifiedSettings);

                    CustomFile csFile = new CustomFile();
                    foreach (var imagesItem in modifiedStatic.RecognizedText)
                    {
                        //csFile.ImageId = imageID;
                        csFile.PageItems.Add(imagesItem.Page);
                    }
                    modifiedStatic.File = csFile;

                    //WriteXML(csFile, AppDomain.CurrentDomain.BaseDirectory + @"OCR\XML\" + Path.GetFileNameWithoutExtension(sourceImagePath) + ".xml");
                    //if (exportImage)
                    //{
                    //    Export(sourceImagePath, modifiedStatic, drawTable, drawBlock, drawLine);
                    //}
                    return modifiedStatic;
                }
            }
            finally
            {

            }
        }
        public void WriteXML<T>(T obj, string fileName)
        {
            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(fileName)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(fileName));
                }

                System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(obj.GetType());
                System.IO.StreamWriter file = new System.IO.StreamWriter(fileName);
                writer.Serialize(file, obj);
                file.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Export(string fileName, RecognitionStatistics recognitionStatistics, bool drawTable, bool drawBlock, bool drawLine)
        {
            int i = 0;
            if (drawBlock)
            {
                foreach (var imagesItem in recognitionStatistics.PreprocessedImages)
                {

                    var recognizedItem = recognitionStatistics.RecognizedText[i];
                    List<Rectangle> rectangleRowItems;
                    List<Rectangle> rectangleLineItems;
                    List<Rectangle> rectangleBlockItems;
                    List<Rectangle> rectangleTableItems;
                    Init(out rectangleRowItems, out rectangleLineItems, out rectangleBlockItems, out rectangleTableItems);

                    AddRectangeBlock(drawLine, recognizedItem.Page.BlockItems, rectangleBlockItems, rectangleLineItems);
                    AddRectangeTable(drawLine, recognizedItem, rectangleBlockItems, rectangleTableItems, rectangleRowItems, rectangleLineItems);
                    string file = AppDomain.CurrentDomain.BaseDirectory + @"OCR\ALL\" + Path.GetFileNameWithoutExtension(fileName) + "_ALL_" + i + ".jpg";


                    DrawImage(imagesItem, rectangleLineItems, rectangleRowItems, rectangleBlockItems, rectangleTableItems, file);


                    Init(out rectangleRowItems, out rectangleLineItems, out rectangleBlockItems, out rectangleTableItems);
                    AddRectangleLine(drawLine, rectangleLineItems, recognizedItem.Page.LineItems);
                    file = AppDomain.CurrentDomain.BaseDirectory + @"OCR\Line\" + Path.GetFileNameWithoutExtension(fileName) + "_Line_" + i + ".jpg";
                    DrawImage(imagesItem, rectangleLineItems, rectangleRowItems, rectangleBlockItems, rectangleTableItems, file);

                    //Init(out rectangleRowItems, out rectangleLineItems, out rectangleBlockItems, out rectangleTableItems);
                    //AddRectangeBlock(drawLine, recognizedItem.Page.BlockItemsAll, rectangleBlockItems, rectangleLineItems);
                    //file = AppDomain.CurrentDomain.BaseDirectory + @"OCR\" + Path.GetFileNameWithoutExtension(fileName) + "_Block_" + i + ".jpg";
                    //DrawImage(imagesItem, null, null, rectangleBlockItems, null, file);


                    i++;
                }

            }

        }

        private static void Init(out List<Rectangle> rectangleRowItems, out List<Rectangle> rectangleLineItems, out List<Rectangle> rectangleBlockItems, out List<Rectangle> rectangleTableItems)
        {
            rectangleRowItems = new List<Rectangle>();
            rectangleLineItems = new List<Rectangle>();
            rectangleBlockItems = new List<Rectangle>();
            rectangleTableItems = new List<Rectangle>();
        }

        private static void DrawImage(Image imagesItem, List<Rectangle> rectangleLineItems, List<Rectangle> rectangleRowItems, List<Rectangle> rectangleBlockItems, List<Rectangle> rectangleTableItems, string file)
        {
            Bitmap newBitmap = new Bitmap(imagesItem.Width, imagesItem.Height);
            Graphics graphics = Graphics.FromImage(newBitmap);
            graphics.DrawImage(imagesItem, 0, 0);

            using (Graphics g = Graphics.FromImage((Image)newBitmap))
            {
                if (rectangleLineItems != null)
                {
                    foreach (var item in rectangleLineItems)
                    {
                        Pen pen = new Pen(Color.Brown, 1);
                        pen.Alignment = PenAlignment.Inset;
                        g.DrawRectangle(pen, item);
                    }
                }

                if (rectangleBlockItems != null)
                {
                    foreach (var item in rectangleBlockItems)
                    {
                        Pen pen = new Pen(Color.Black, 1.2F);
                        pen.Alignment = PenAlignment.Inset;
                        g.DrawRectangle(pen, item);
                    }
                }

                if (rectangleRowItems != null)
                {
                    foreach (var item in rectangleRowItems)
                    {
                        Pen pen = new Pen(Color.Blue, 1.5F);
                        pen.Alignment = PenAlignment.Inset;
                        g.DrawRectangle(pen, item);
                    }
                }
                if (rectangleTableItems != null)
                {
                    foreach (var item in rectangleTableItems)
                    {
                        Pen pen = new Pen(Color.Red, 2);
                        pen.Alignment = PenAlignment.Inset;
                        g.DrawRectangle(pen, item);
                    }
                }

            }



            if (!Directory.Exists(Path.GetDirectoryName(file)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(file));
            }

            newBitmap.Save(file);
        }

        private static void AddRectangeTable(bool drawLine, RecognizedText recognizedItem, List<Rectangle> rectangleBlockItems, List<Rectangle> rectangleTableColorItems, List<Rectangle> rectangleRowItems, List<Rectangle> rectangleLineItems)
        {
            foreach (var tableItem in recognizedItem.Page.TableItems)
            {
                Rectangle rectangle = new Rectangle()
                {
                    X = tableItem.X,
                    Y = tableItem.Y,
                    Width = tableItem.Width,
                    Height = tableItem.Height,
                };
                rectangleTableColorItems.Add(rectangle);

                foreach (var rowItem in tableItem.RowItems)
                {

                    Rectangle rectangleRow = new Rectangle()
                    {
                        X = rowItem.X,
                        Y = rowItem.Y,
                        Width = rowItem.Width,
                        Height = rowItem.Height,
                    };
                    rectangleRowItems.Add(rectangleRow);
                    AddRectangeBlock(drawLine, rowItem.BlockItems, rectangleBlockItems, rectangleLineItems);
                }

            }
        }

        private static void AddRectangeBlock(bool drawLine, List<CustomBlock> blockItems, List<Rectangle> rectangleBlockItems, List<Rectangle> rectangleLineItems)
        {
            foreach (var blockItem in blockItems)
            {
                Rectangle rectangle = new Rectangle()
                {
                    X = blockItem.X,
                    Y = blockItem.Y,
                    Width = blockItem.Width,
                    Height = blockItem.Height,
                };
                rectangleBlockItems.Add(rectangle);

                List<CustomLine> lineItems = blockItem.LineItems;
                AddRectangleLine(drawLine, rectangleLineItems, lineItems);
            }
        }

        private static void AddRectangleLine(bool drawLine, List<Rectangle> rectangleLineItems, List<CustomLine> lineItems)
        {
            if (drawLine)
            {
                foreach (var LineItem in lineItems)
                {
                    Rectangle rectangleLineItem = new Rectangle()
                    {
                        X = LineItem.X,
                        Y = LineItem.Y,
                        Width = LineItem.Width,
                        Height = LineItem.Height,
                    };
                    rectangleLineItems.Add(rectangleLineItem);
                }
            }

        }


    }
}
