using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Process
{
    public class P_DeliveryImage_Conferma
    {
        public long I_ImageID { get; set; }
        public string FilePath { get; set; }
        public string PDFFilename { get; set; }
        public string BookingNo { get; set; }
        public long M_CompanyID { get; set; }
        public string CompanyName { get; set; }
        public long ParentID { get; set; }
        public long M_LanguageID { get; set; }
        public long M_ProcessID { get; set; }
        public string AirPlusLogo { get; set; }
        public string T2PLogo { get; set; }
        public string HotelLogo { get; set; }
        public string CompanyLogo { get; set; }
        public string MailServer { get; set; }
        public string MailUsername { get; set; }
        public string MailPassword { get; set; }
        public string M_HotelPlatformName { get; set; }
        public string FaxNumber { get; set; }
        public long M_HotelPlatformID { get; set; }
        public string InvoiceRecipientEmail { get; set; }
    }
}
