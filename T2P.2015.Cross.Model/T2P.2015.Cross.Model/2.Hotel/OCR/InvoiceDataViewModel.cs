using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Utility.OCR;

namespace T2P._2015.Cross.Model.OCR.Queue
{
    [Serializable]

    public class InvoiceOCR
    {
        public long I_ImageID { get; set; }
        public List<InvoicePath> InvoicePathItems { get; set; }
        public DateTime ImageCreatedDate { get; set; }
        public InvoiceOCR()
        { 
            InvoicePathItems = new List<InvoicePath>();
        }
    }

    public class InvoicePath
    {
        public string PDFPath { get; set; }
        public string ImagePath { get; set; }
    }

    [Serializable]
    public class InvoiceXML
    {

        public string OCRFilePath { get; set; }
        public long I_ImageID { get; set; }
        public decimal OCRDuration { get; set; }

        public DateTime ImageCreatedDate { get; set; }

        public int ImageRotation { get; set; }
        public decimal ImageWidth { get; set; }
        public decimal ImageHeight { get; set; }
        public decimal ImageSkewAngle { get; set; }
        public CustomFile CustomFile { get; set; }
    }

    [Serializable]
    public class InvoiceData
    {
        public long I_ImageID { get; set; }
        public int ImageRotation { get; set; }

        public List<I_Suggestion> BookingSuggestionsList { get; set; }
        public I_SuggestHeader HeaderSuggestion { get; set; }
        public List<I_SuggestPosition> PositionSuggestionsList { get; set; }
        public List<I_SuggestTax> TaxSuggestionsList { get; set; }

        public InvoiceData()
        {
            BookingSuggestionsList = new List<I_Suggestion>();
            HeaderSuggestion = new I_SuggestHeader();
            PositionSuggestionsList = new List<I_SuggestPosition>();
            TaxSuggestionsList = new List<I_SuggestTax>();
        }
    }

}
