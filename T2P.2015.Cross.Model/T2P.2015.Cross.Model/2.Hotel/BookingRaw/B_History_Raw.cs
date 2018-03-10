using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.BookingRaw
{
    public class B_History_Raw
    {
        public int ID { get; set; }

        public Guid ImportID { get; set; }

        public string BookingProcessNo { get; set; }

        public string BookingNo { get; set; }

        public string FollowingBookingNo { get; set; }

        public string PaymentMethod { get; set; }

        public DateTime? BookingDate { get; set; }

        public DateTime? CancellationDate { get; set; }

        public DateTime? CheckInDate { get; set; }

        public DateTime? CheckOutDate { get; set; }

        public int NumberOfSingleRooms { get; set; }

        public int NumberOfDoubleRooms { get; set; }

        public string GuaranteeType { get; set; }

        public decimal? TaxAmount { get; set; }

        public decimal? CancellationFee { get; set; }

        public string CurrencyCode { get; set; }

        public DateTime? CancellationDeadline { get; set; }

        public decimal? BookingDeposit { get; set; }

        public bool BookingDepositRequired { get; set; }

        public static string Table = "B_History_Raw";
    }
}
