using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.CarRental
{
    public class R_P_SuccessfulInvoice_Header
    {
        public string InvoiceNumber { get; set; }
        public DateTime? InvoiceDate{get;set;}
        public string CarGroup { get; set; }
        public DateTime? PickUpTime { get; set; }
        public DateTime? ReturnTime { get; set; }
        public string ReservationNumber { get; set; }
     
        public string PickUpLocation { get; set; }
        public string ReturnLocation { get; set; }
        public string PickupCountry { get; set; }

        public string ReturnCountry { get; set; }
        public string BookingNo { get; set; }
        public string ProviderName { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyEmail { get; set; }
        public string Logo { get; set; }
        public string CompanyZIPCode { get; set; }

        public string CompanyCity { get; set; }

        public string CompanyCountry { get; set; }
        public string IISPath { get; set; }

        public string ImagePath { get; set; }

        public string FilePath { get; set; }

        public string ImageFilename { get; set; }

        public string FullPath { get; set; }
        public long BAccessID { get; set; }

        public string CustomerNumber { get; set; }

        public string RentalNumber { get; set; }
    }
}
