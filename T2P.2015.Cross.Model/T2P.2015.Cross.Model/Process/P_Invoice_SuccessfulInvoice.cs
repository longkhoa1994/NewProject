

using System;
namespace T2P._2015.Cross.Model.Process
{
    public class P_Invoice_SuccessfulInvoice
    {
        public string InvoiceNo { get; set; }

        public string ReservationNumber { get; set; }

        public string HotelName { get; set; }

        public string CompanyName { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public DateTime? CheckInDate { get; set; }

        public DateTime? CheckOutDate { get; set; }

        public long ID { get; set; }

        public long BookingID { get; set; }

        public long BAccessID { get; set; }

        public string HotelPlatformName { get; set; }
    }
}
