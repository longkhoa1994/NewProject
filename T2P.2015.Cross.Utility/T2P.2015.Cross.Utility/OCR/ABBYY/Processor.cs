// © 2013 ABBYY Production LLC
// SAMPLES code is property of ABBYY, exclusive rights are reserved. 
//
// DEVELOPER is allowed to incorporate SAMPLES into his own APPLICATION and modify it under 
// the  terms of  License Agreement between  ABBYY and DEVELOPER.


// ABBYY FineReader Engine 11 Sample

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.ComponentModel;
using T2P._2015.Cross.Utility.OCR.ABBYY;
//using System.Windows.Forms;

namespace T2P._2015.Cross.Utility.OCR
{
    public class EnumToStringByDescription : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return (sourceType.Equals(typeof(System.Enum)));
        }
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return (destinationType.Equals(typeof(String)));
        }
        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (!destinationType.Equals(typeof(String)))
            {
                throw new ArgumentException("Can only convert to string.", "destinationType");
            }
            if (!value.GetType().BaseType.Equals(typeof(System.Enum)))
            {
                throw new ArgumentException("Can only convert an instance of enum.", "value");
            }
            string name = value.ToString();
            object[] attrs = value.GetType().GetField(name).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return (attrs.Length > 0) ? ((DescriptionAttribute)attrs[0]).Description : name;
        }
    }

    class ProcessingSettings
    {
        public bool IsRecognize = true;
        public string Language = "English";

        // --- General preprocessing transformations

        public bool CropImage = false;
        public bool EnhanceLocalContrast = false;
        public bool DeskewImage = false;

        // How engine detects image orientation
        [TypeConverter(typeof(EnumToStringByDescription))]
        public enum OrientationCorrectionMode
        {
            [Description("None")]
            None,
            [Description("Automatic")]
            Automatic,
            [Description("Rotate 90 CW")]
            Rotate90CW,
            [Description("Rotate 90 CCW")]
            Rotate90CCW,
            [Description("Rotate 180 Upside Down")]
            Rotate180UpsideDown,
            [Description("Mirror Horizontally")]
            MirrorHorizontally
        };
        public OrientationCorrectionMode CorrectOrientationMode = OrientationCorrectionMode.None;

        public bool RemoveGarbage = false;
        // Garbage area in pixels. -1 means detect garbage size automatically
        public int GarbageSize = -1;

        // Tell engine to change resolution to specified value
        // If these variables are less than or equal to zero, resolution is detected automatically
        public bool CorrectResolution = false;
        public int NewResolution = 0;
        public bool SplitPages = false;
        public bool SplitBusinessCards = false;

        // --- Color filtering

        public bool InvertImage = false;

        public bool SuppressColor = false;
        // Hue in HSL representation to suppress
        public byte HslHueToSuppress = 0;
        public byte HslSaturationBoundaryToSuppress = 1;

        public bool RemoveObjects = false;
        public enum ObjectsColorEnum { Red, Green, Blue, Yellow };
        public ObjectsColorEnum ColorToRemove = ObjectsColorEnum.Red;
        public enum ObjectsTypeEnum { Full, Background, Stamp };
        public ObjectsTypeEnum ObjectsTypeToRemove = ObjectsTypeEnum.Full;

        // --- Camera OCR transformations

        public bool CorrectDistortions = false;

        public bool RemoveNoise = false;
        public FREngine.NoiseModelEnum NoiseModel = FREngine.NoiseModelEnum.NM_WhiteNoise;
        public bool HasLargeCharacters = false;

        public bool RemoveMotionBlur = false;

        // --- Visual enhancements

        public bool ConvertToBW = false;
        public bool EnableDithering = false; // Not yet in the API

        public bool SmoothTexture = false; // Not yet in the API

        public bool EqualizeBrightness = false;
        public bool MakeWhiteBackground = false;
    }

    struct PageRect
    {
        public int PageIndex;
        public System.Drawing.Rectangle Rect;
        public PageRect(int pageIndex, int x, int y, int w, int h)
        {
            PageIndex = pageIndex;
            Rect = new System.Drawing.Rectangle(x, y, w, h);
        }
    }

    public class RecognitionStatistics
    {
        // Total number of characters recognized in document
        public int TotalCharsCount;
        // Total number of suspicious characters in document
        public int SuspiciousCharsCount;
        // Total processing time
        public TimeSpan TotalProcessingTime;
        // Processed Image
        public System.Drawing.Image[] PreprocessedImages;

        // Recognized text for each page
        public List<RecognizedText> RecognizedText = new List<RecognizedText>();
        // Source page indices
        public int[] SourcePageIndices;
        public CustomFile File;
        public static RecognitionStatistics operator +(RecognitionStatistics a, RecognitionStatistics b)
        {
            RecognitionStatistics result = new RecognitionStatistics();
            result.TotalCharsCount = a.TotalCharsCount + b.TotalCharsCount;
            result.SuspiciousCharsCount = a.SuspiciousCharsCount + b.SuspiciousCharsCount;
            if (a.RecognizedText.Count > 0)
                result.RecognizedText = a.RecognizedText;
            else if (b.RecognizedText.Count > 0)
                result.RecognizedText = b.RecognizedText;
            return result;
        }
    }

    class Processor : IDisposable
    {
        // Event that is called when next step is performed
        public delegate void StepChangedEventHandler(string description);
        public event StepChangedEventHandler StepChangedEvent;

        public Processor()
        {
        }

        public void Dispose()
        {
            if (engineLoader != null)
            {
                engineLoader.Dispose();
                engineLoader = null;
            }
        }

        public void LoadEngine()
        {
            if (engineLoader == null)
            {
                setStep("Loading engine...");
                engineLoader = new EngineLoader();
            }
        }

        // Warm-up recognition engine
        // It's good to call warm-up with all settings enabled
        public void WarmUp(string imagePath, ProcessingSettings settings)
        {
            LoadEngine();
            setStep("Warming up...");
            engine.LoadModule(FREngine.FREngineModuleEnum.FREM_ImageSupport);
            engine.LoadModule(FREngine.FREngineModuleEnum.FREM_Recognizer);
            engine.LoadModule(FREngine.FREngineModuleEnum.FREM_DocumentAnalyzer);
            engine.LoadModule(FREngine.FREngineModuleEnum.FREM_EuropeanPatterns);
        }
        public List<int> DetectRotate(string imagePath)
        {
            List<int> result = new List<int>();
            FREngine.PrepareImageMode pim = engine.CreatePrepareImageMode();
            FREngine.DocumentProcessingParams dpp = engine.CreateDocumentProcessingParams();
            FREngine.PageProcessingParams ppp = dpp.PageProcessingParams;

            var rotation = detectOrientation(imagePath, pim, ppp);
            foreach (var item in rotation)
            {
                int rotate = 0;
                switch (item)
                {
                    case FREngine.RotationTypeEnum.RT_Clockwise: rotate = 90; break;
                    case FREngine.RotationTypeEnum.RT_Upsidedown: rotate = 180; break;
                    case FREngine.RotationTypeEnum.RT_Counterclockwise: rotate = 270; break;
                    default: break;
                }
                result.Add(rotate);
            }
            return result;

        }
        public RecognitionStatistics Process(string imagePath, ProcessingSettings settings)
        {
            DateTime startTime = System.DateTime.Now;

            setStep("Applying profile...");
            engine.LoadPredefinedProfile("DocumentConversion_Accuracy");

            setStep("Applying settings...");
            FREngine.PrepareImageMode pim = engine.CreatePrepareImageMode();
            FREngine.DocumentProcessingParams dpp = engine.CreateDocumentProcessingParams();
            FREngine.PageProcessingParams ppp = dpp.PageProcessingParams;

            ppp.RecognizerParams.SetPredefinedTextLanguage(settings.Language);
            disableAllModifications(pim, ppp);

            pim.AutoOverwriteResolution = false;
            if (settings.CorrectResolution)
            {
                if (settings.NewResolution == 0)
                {
                    pim.AutoOverwriteResolution = true;
                }
                else if (settings.NewResolution > 0)
                {
                    pim.OverwriteResolution = true;
                    pim.XResolutionToOverwrite = settings.NewResolution;
                    pim.YResolutionToOverwrite = settings.NewResolution;
                }
            }

            if (settings.ConvertToBW)
            {
                pim.DiscardColorImage = true;
            }
            if (settings.DeskewImage)
            {
                pim.CorrectSkew = true;
            }

            // Detect orientation for all pages
            setStep("Detecting orientation...");
            FREngine.RotationTypeEnum[] rotation = null;
            if (settings.CorrectOrientationMode == ProcessingSettings.OrientationCorrectionMode.Automatic)
            {
                rotation = detectOrientation(imagePath, pim, ppp);
            }

            setStep("Loading image...");

            // Create document
            FREngine.FRDocument frDocument = engine.CreateFRDocument();
            RecognitionStatistics recognitionStats = new RecognitionStatistics();
            try
            {
                // Add image file to document
                frDocument.AddImageFile(imagePath, pim, null);

                if (frDocument.Pages.Count == 0)
                {
                    throw new Exception("No pages in a file");
                }

                setStep("Performing image modification...");
                for (int pageIndex = 0; pageIndex < frDocument.Pages.Count; pageIndex++)
                {
                    FREngine.IFRPage frPage = frDocument.Pages[pageIndex];
                    FREngine.RotationTypeEnum pageRotation = FREngine.RotationTypeEnum.RT_UnknownRotation;
                    if (rotation != null && pageIndex < rotation.Length)
                    {
                        pageRotation = rotation[pageIndex];
                    }

                    applyGeometricalTransformations(frPage, ppp, settings, pageRotation);

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    frPage.Flush(true);
                }

                int[] sourcePageIndices = splitImage(frDocument, ppp, settings);

                for (int pageIndex = 0; pageIndex < frDocument.Pages.Count; pageIndex++)
                {
                    FREngine.IFRPage frPage = frDocument.Pages[pageIndex];
                    applyImageTransformations(frPage, settings);

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    frPage.Flush(true);
                }

                if (settings.IsRecognize)
                {
                    setStep("Recognizing image...");
                    frDocument.Process(dpp);
                }

                setStep("Applying visual enhancements...");
                for (int pageIndex = 0; pageIndex < frDocument.Pages.Count; pageIndex++)
                {
                    FREngine.IFRPage frPage = frDocument.Pages[pageIndex];
                    applyVisualEnhancements(frPage, settings);

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    frPage.Flush(true);
                }

                TimeSpan processingTime = DateTime.Now - startTime;

                setStep("Computing statistics...");

                recognitionStats = computeStatistics(frDocument);
                recognitionStats.TotalProcessingTime = processingTime;
                recognitionStats.SourcePageIndices = sourcePageIndices;

                setStep("Retrieving images...");
                for (int pageIndex = 0; pageIndex < frDocument.Pages.Count; pageIndex++)
                {
                    if (recognitionStats.PreprocessedImages == null)
                    {
                        recognitionStats.PreprocessedImages = new System.Drawing.Image[frDocument.Pages.Count];
                    }
                    FREngine.IFRPage frPage = frDocument.Pages[pageIndex];
                    recognitionStats.PreprocessedImages[pageIndex] = getImageFromPage(frPage);

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    frPage.Flush(false);
                }



                //frDocument.Export(AppDomain.CurrentDomain.BaseDirectory + "FileSample2.xml", FREngine.FileExportFormatEnum.FEF_XML, null);

                //frDocument.Export(AppDomain.CurrentDomain.BaseDirectory + "FileSample2.txt", FREngine.FileExportFormatEnum.FEF_TextUnicodeDefaults, null);

            }
            finally
            {
                frDocument.Close();
            }

            return recognitionStats;
        }

        private void checkProcessingSettingsForImage(FREngine.ImageColorTypeEnum imageColorType, ref ProcessingSettings settings)
        {
            string unavailableOperations = "";
            if (imageColorType == FREngine.ImageColorTypeEnum.ICT_BlackWhite)
            {
                if (settings.RemoveNoise)
                {
                    settings.RemoveNoise = false;
                    unavailableOperations += "Remove noise, ";
                }
                if (settings.RemoveMotionBlur)
                {
                    settings.RemoveMotionBlur = false;
                    unavailableOperations += "Remove motion blur, ";
                }
                if (settings.EqualizeBrightness)
                {
                    settings.EqualizeBrightness = false;
                    unavailableOperations += "Equalize brightness, ";
                }
                if (settings.EnhanceLocalContrast)
                {
                    settings.EnhanceLocalContrast = false;
                    unavailableOperations += "Enhance local contrast, ";
                }
                if (settings.SuppressColor)
                {
                    settings.SuppressColor = false;
                    unavailableOperations += "Suppress color, ";
                }
                if (settings.RemoveObjects)
                {
                    settings.RemoveObjects = false;
                    unavailableOperations += "Remove objects, ";
                }
                if (unavailableOperations != "")
                {
                    unavailableOperations = unavailableOperations.Remove(unavailableOperations.Length - 2, 2);
                    unavailableOperations = "These operations will not be applied to a black-and-white image: " + unavailableOperations;
                }
            }
            else if (imageColorType == FREngine.ImageColorTypeEnum.ICT_Gray)
            {
                if (settings.SuppressColor)
                {
                    settings.SuppressColor = false;
                    unavailableOperations += "Suppress color, ";
                }
                if (settings.RemoveObjects)
                {
                    settings.RemoveObjects = false;
                    unavailableOperations += "Remove objects, ";
                }
                if (unavailableOperations != "")
                {
                    unavailableOperations = unavailableOperations.Remove(unavailableOperations.Length - 2, 2);
                    unavailableOperations = "These operations will not be applied to a gray image: " + unavailableOperations;
                }
            }
            if (unavailableOperations != "")
            {
                //MessageBox.Show(null, unavailableOperations, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private System.Drawing.Image getImageFromPage(FREngine.IFRPage frPage)
        {
            FREngine.IImageDocument imageDocument = frPage.ImageDocument;
            FREngine.IImage image = null;
            switch (imageDocument.ImageColorType)
            {
                case FREngine.ImageColorTypeEnum.ICT_BlackWhite:
                    image = imageDocument.BlackWhiteImage; break;
                case FREngine.ImageColorTypeEnum.ICT_Gray:
                case FREngine.ImageColorTypeEnum.ICT_Color:
                    image = imageDocument.ColorImage; break;
            }

            FREngine.IHandle hBitmap = image.GetBitmap(null);
            System.Drawing.Image newImage = System.Drawing.Image.FromHbitmap(hBitmap.Handle);
            hBitmap.CloseHandle();

            return newImage;
        }

        private void disableAllModifications(FREngine.PrepareImageMode pim, FREngine.PageProcessingParams ppp)
        {
            pim.CorrectSkew = false;
            pim.CorrectSkewMode = 0;
            pim.AutoOverwriteResolution = false;

            ppp.PagePreprocessingParams.CorrectShadowsAndHighlights = FREngine.ThreeStatePropertyValueEnum.TSPV_No;
            ppp.PagePreprocessingParams.CorrectOrientation = false;
            ppp.PagePreprocessingParams.CorrectInvertedImage = false;
            ppp.PagePreprocessingParams.GeometryCorrectionMode = FREngine.GeometryCorrectionModeEnum.GCM_DontCorrect;
            ppp.PagePreprocessingParams.ResolutionCorrectionMode = FREngine.ResolutionCorrectionModeEnum.RCM_DontCorrect;
            ppp.PagePreprocessingParams.CorrectSkew = FREngine.ThreeStatePropertyValueEnum.TSPV_No;
        }

        // Detect orientation of all pages in a document
        // Return array with orientations for all pages
        private FREngine.RotationTypeEnum[] detectOrientation(string imagePath, FREngine.PrepareImageMode _prepareImageMode,
            FREngine.PageProcessingParams pageProcessingParams)
        {
            // Correct skew during loading
            FREngine.PrepareImageMode prepareImageMode = engine.CreatePrepareImageMode();
            prepareImageMode.CopyFrom(_prepareImageMode);
            prepareImageMode.CorrectSkew = true;
            prepareImageMode.CorrectSkewMode = correctSkewFlags;

            FREngine.RotationTypeEnum[] rotations = null;
            FREngine.FRDocument frDocument = engine.CreateFRDocument();
            try
            {
                frDocument.AddImageFile(imagePath, prepareImageMode, null);

                // Get orientation for every page
                int pagesCount = frDocument.Pages.Count;
                rotations = new FREngine.RotationTypeEnum[pagesCount];
                for (int pageIndex = 0; pageIndex < pagesCount; pageIndex++)
                {
                    FREngine.IFRPage frPage = frDocument.Pages[pageIndex];
                    FREngine.TextOrientation textOrientation = frPage.DetectOrientation(null, pageProcessingParams.ObjectsExtractionParams,
                        pageProcessingParams.RecognizerParams);
                    rotations[pageIndex] = FREngine.RotationTypeEnum.RT_UnknownRotation;
                    if (textOrientation != null)
                    {
                        rotations[pageIndex] = textOrientation.RotationType;
                    }
                    frPage.Flush(false);
                }
            }
            finally
            {
                frDocument.Close();
            }

            return rotations;
        }

        private void applyGeometricalTransformations(FREngine.IFRPage page, FREngine.IPageProcessingParams ppp, ProcessingSettings settings,
            FREngine.RotationTypeEnum detectedRotation)
        {
            checkProcessingSettingsForImage(page.ImageDocument.ImageColorType, ref settings);

            if (settings.CropImage)
            {
                page.ImageDocument.CropImage();
            }
            if (settings.EnhanceLocalContrast)
            {
                page.ImageDocument.EnhanceLocalContrast();
            }

            if (settings.CorrectOrientationMode != ProcessingSettings.OrientationCorrectionMode.None && detectedRotation != FREngine.RotationTypeEnum.RT_NoRotation)
            {
                FREngine.RotationTypeEnum rotation = FREngine.RotationTypeEnum.RT_NoRotation;
                bool mirror = false;
                if (detectedRotation != FREngine.RotationTypeEnum.RT_UnknownRotation)
                {
                    switch (detectedRotation)
                    {
                        case FREngine.RotationTypeEnum.RT_Clockwise:
                            rotation = FREngine.RotationTypeEnum.RT_Counterclockwise;
                            break;
                        case FREngine.RotationTypeEnum.RT_Upsidedown:
                            rotation = FREngine.RotationTypeEnum.RT_Upsidedown;
                            break;
                        case FREngine.RotationTypeEnum.RT_Counterclockwise:
                            rotation = FREngine.RotationTypeEnum.RT_Clockwise;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (settings.CorrectOrientationMode)
                    {
                        case ProcessingSettings.OrientationCorrectionMode.Rotate90CW:
                            rotation = FREngine.RotationTypeEnum.RT_Clockwise;
                            break;
                        case ProcessingSettings.OrientationCorrectionMode.Rotate180UpsideDown:
                            rotation = FREngine.RotationTypeEnum.RT_Upsidedown;
                            break;
                        case ProcessingSettings.OrientationCorrectionMode.Rotate90CCW:
                            rotation = FREngine.RotationTypeEnum.RT_Counterclockwise;
                            break;
                        case ProcessingSettings.OrientationCorrectionMode.MirrorHorizontally:
                            mirror = true;
                            break;
                        default:
                            break;
                    }
                }

                page.ImageDocument.Transform(rotation, mirror, false);
            }

            if (settings.InvertImage)
            {
                page.ImageDocument.Transform(FREngine.RotationTypeEnum.RT_NoRotation, false, true);
            }

            if (settings.CorrectDistortions)
            {
                page.CorrectGeometricalDistortions(ppp.ObjectsExtractionParams);
            }

            if (settings.DeskewImage)
            {
                page.ImageDocument.CorrectSkew(correctSkewFlags);
            }
        }

        private int[] splitImage(FREngine.IFRDocument frDoc, FREngine.IPageProcessingParams ppp, ProcessingSettings settings)
        {
            FREngine.PageSplittingParams pageSplittingParams = engine.CreatePageSplittingParams();
            pageSplittingParams.SplitType = FREngine.PageSplitTypeEnum.PST_None;
            if (settings.SplitPages)
            {
                pageSplittingParams.SplitType = FREngine.PageSplitTypeEnum.PST_DoublePageSplit;
            }
            else if (settings.SplitBusinessCards)
            {
                pageSplittingParams.SplitType = FREngine.PageSplitTypeEnum.PST_BusinessCardSplit;
            }
            else
            {
                int[] emptyPageIndices = new int[1];
                emptyPageIndices[0] = 0;
                return emptyPageIndices;
            }
            if (settings.CorrectOrientationMode != ProcessingSettings.OrientationCorrectionMode.None)
            {
                ppp.PagePreprocessingParams.CorrectOrientation = true;
            }

            engine.MultiProcessingParams.MultiProcessingMode = FREngine.MultiProcessingModeEnum.MPM_Sequential;
            FREngine.SplitRegions splitRegions = frDoc.SplitPages(null, pageSplittingParams, ppp.ObjectsExtractionParams);
            engine.MultiProcessingParams.MultiProcessingMode = FREngine.MultiProcessingModeEnum.MPM_Auto;

            int[] sourcePageIndices = new int[frDoc.Pages.Count];
            for (int pageIndex = 0; pageIndex < sourcePageIndices.Length; pageIndex++)
            {
                sourcePageIndices[pageIndex] = -1;
            }

            foreach (FREngine.SplitRegion item in splitRegions)
            {
                FREngine.IFRPage frPage = frDoc.Pages[item.CurrentPageIndex];
                sourcePageIndices[item.CurrentPageIndex] = item.SourcePageIndex;

                if (settings.CropImage)
                {
                    frPage.ImageDocument.CropImage();
                }

                if (settings.CorrectDistortions)
                {
                    frPage.CorrectGeometricalDistortions(ppp.ObjectsExtractionParams);
                }

                if (settings.DeskewImage)
                {
                    frPage.ImageDocument.CorrectSkew(correctSkewFlags);
                }

                frPage.Flush(true);
            }

            for (int pageIndex = 0; pageIndex < sourcePageIndices.Length; pageIndex++)
            {
                if (sourcePageIndices[pageIndex] == -1)
                {
                    sourcePageIndices[pageIndex] = pageIndex == 0 ? 0 : sourcePageIndices[pageIndex - 1] + 1;
                }
            }
            return sourcePageIndices;
        }

        private void applyImageTransformations(FREngine.IFRPage page, ProcessingSettings settings)
        {
            checkProcessingSettingsForImage(page.ImageDocument.ImageColorType, ref settings);

            if (settings.RemoveGarbage)
            {
                page.ImageDocument.RemoveGarbage(null, settings.GarbageSize);
            }

            if (settings.RemoveNoise)
            {
                page.ImageDocument.RemoveNoise(settings.NoiseModel, settings.HasLargeCharacters);
            }

            if (settings.RemoveMotionBlur)
            {
                page.ImageDocument.RemoveMotionBlur(null);
            }

            if (settings.SuppressColor)
            {
                page.ImageDocument.SuppressColorObjects(settings.HslHueToSuppress, settings.HslSaturationBoundaryToSuppress);
            }

            if (settings.RemoveObjects)
            {
                FREngine.ObjectsColorEnum colorToRemove = FREngine.ObjectsColorEnum.OC_Blue;
                switch (settings.ColorToRemove)
                {
                    case ProcessingSettings.ObjectsColorEnum.Red:
                        colorToRemove = FREngine.ObjectsColorEnum.OC_Red; break;
                    case ProcessingSettings.ObjectsColorEnum.Green:
                        colorToRemove = FREngine.ObjectsColorEnum.OC_Green; break;
                    case ProcessingSettings.ObjectsColorEnum.Blue:
                        colorToRemove = FREngine.ObjectsColorEnum.OC_Blue; break;
                    case ProcessingSettings.ObjectsColorEnum.Yellow:
                        colorToRemove = FREngine.ObjectsColorEnum.OC_Yellow; break;
                }

                FREngine.ObjectsTypeEnum objectsTypeToRemove = FREngine.ObjectsTypeEnum.OT_Background;
                switch (settings.ObjectsTypeToRemove)
                {
                    case ProcessingSettings.ObjectsTypeEnum.Full:
                        objectsTypeToRemove = FREngine.ObjectsTypeEnum.OT_Full; break;
                    case ProcessingSettings.ObjectsTypeEnum.Background:
                        objectsTypeToRemove = FREngine.ObjectsTypeEnum.OT_Background; break;
                    case ProcessingSettings.ObjectsTypeEnum.Stamp:
                        objectsTypeToRemove = FREngine.ObjectsTypeEnum.OT_Stamp; break;
                }

                page.ImageDocument.RemoveColorObjects(null, colorToRemove, objectsTypeToRemove);
            }
        }

        private void applyVisualEnhancements(FREngine.IFRPage page, ProcessingSettings settings)
        {
            checkProcessingSettingsForImage(page.ImageDocument.ImageColorType, ref settings);

            if (settings.EqualizeBrightness)
            {
                page.ImageDocument.EqualizeBrightness(settings.MakeWhiteBackground);
            }

            if (settings.SmoothTexture)
            {
                page.ImageDocument.SmoothTexture();
            }

            if (settings.ConvertToBW && settings.EnableDithering)
            {
                page.ImageDocument.DitherImage(FREngine.DitheringMethodEnum.DM_FloydSteinberg);
            }
        }

        private RecognitionStatistics computeStatistics(FREngine.IFRDocument frDocument)
        {
            RecognitionStatistics result = new RecognitionStatistics();
            result.RecognizedText = new List<RecognizedText>();

            CustomFile file = new CustomFile();


            for (int pageIndex = 0; pageIndex < frDocument.Pages.Count; pageIndex++)
            {
                FREngine.IFRPage frPage = frDocument.Pages[pageIndex];
                FREngine.ILayout layout = frPage.Layout;
                int blocksCount = layout.Blocks.Count;
                for (int blockIndex = 0; blockIndex < blocksCount; blockIndex++)
                {
                    FREngine.IBlock block = layout.Blocks[blockIndex];

                    result += computeStatisticsForBlock(pageIndex, block);


                }



                result.RecognizedText.Add(new RecognizedText(frPage, pageIndex));

                frPage.Flush(false);
            }
            return result;
        }

        private RecognitionStatistics computeStatisticsForBlock(int pageIndex, FREngine.IBlock block)
        {
            RecognitionStatistics result = new RecognitionStatistics();
            if (block.Type == FREngine.BlockTypeEnum.BT_Table)
            {
                FREngine.TableBlock tableBlock = block.GetAsTableBlock();
                for (int iCell = 0; iCell < tableBlock.Cells.Count; iCell++)
                {
                    result += computeStatisticsForBlock(pageIndex, tableBlock.Cells[iCell].Block);
                }
            }
            else if (block.Type == FREngine.BlockTypeEnum.BT_Text)
            {
                FREngine.ITextBlock textBlock = block.GetAsTextBlock();

                int paragraphsCount = textBlock.Text.Paragraphs.Count;
                for (int iPar = 0; iPar < paragraphsCount; iPar++)
                {
                    FREngine.IParagraph par = textBlock.Text.Paragraphs[iPar];
                    string text = par.Text;
                    result.TotalCharsCount += text.Length;
                    FREngine.CharParams charParams = engine.CreateCharParams();
                    for (int iChar = 0; iChar < text.Length; iChar++)
                    {
                        par.GetCharParams(iChar, charParams);
                        if (charParams.IsSuspicious)
                        {
                            result.SuspiciousCharsCount++;
                        }
                    }
                }
            }

            return result;
        }

        private void setStep(string description)
        {
            if (StepChangedEvent != null)
            {
                StepChangedEvent(description);
            }
        }

        private int correctSkewFlags = (int)FREngine.CorrectSkewModeEnum.CSM_CorrectSkewByHorizontalText +
            (int)FREngine.CorrectSkewModeEnum.CSM_CorrectSkewByVerticalText;
        private EngineLoader engineLoader;


        private FREngine.IEngine engine
        {
            get
            {
                if (engineLoader == null)
                {
                    LoadEngine();
                }
                return engineLoader.Engine;
            }
        }
    }
}
