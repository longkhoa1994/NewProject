using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.BookingRaw
{
    public class B_Rate_Raw
    {
        public int ID { get; set; }

        public Guid ImportID { get; set; }

        public string BookingProcessNo { get; set; }

        public string BookingNo { get; set; }

        public decimal Price { get; set; }

        public string CurrencyCode { get; set; }

        public float VATRate { get; set; }

        public int RateTimeAmount { get; set; }

        public string RateTimeUnit { get; set; }

        public string RoomCategory { get; set; }

        public static string Table = "B_Rate_Raw";
    }
}
