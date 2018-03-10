using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.CarRental
{
    public class R_P_Invoice_SuccessfulInvoice
    {
        public string InvoiceNo { get; set; }
        public string ProviderName { get; set; }
        public string ReservationNumber { get; set; }
        public string CompanyName { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? PickupDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string PickupPlace { get; set; }
        public string ReturnPlace { get; set; }
        public long ID { get; set; }

        public long BookingID { get; set; }

        public long BAccessID { get; set; }
        public string PickupCountry { get; set; }
        public string ReturnCountry { get; set; }

    }
}
 