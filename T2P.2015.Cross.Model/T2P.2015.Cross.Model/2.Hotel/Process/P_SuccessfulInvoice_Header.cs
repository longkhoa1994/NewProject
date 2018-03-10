
using System;
namespace T2P._2015.Cross.Model.Process
{
    public class P_SuccessfulInvoice_Header
    {
        public long HotelID { get; set; }
        public string HotelName { get; set; }

        public string HoteAddress { get; set; }

        public string HotelZIPCode { get; set; }

        public string HotelCity { get; set; }

        public string HotelCountry { get; set; }

        public string InvoiceNo { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public string VATIdenNumber { get; set; }

        public string TAXIdenNumber { get; set; }

        public DateTime? CheckInDate { get; set; }

        public DateTime? CheckOutDate { get; set; }

        public string BookingNo { get; set; }
        public long BookingID { get; set; }
        public long B_EventID { get; set; }
        public long BAccessID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAlias { get; set; }
        public string CompanyAddress { get; set; }

        public string CompanyZIPCode { get; set; }

        public string CompanyCity { get; set; }

        public string CompanyCountry { get; set; }
        public string IISPath { get; set; }

        public string ImagePath { get; set; }

        public string FilePath { get; set; }

        public string ImageFilename { get; set; }

        public string FullPath { get; set; }
    }
}
