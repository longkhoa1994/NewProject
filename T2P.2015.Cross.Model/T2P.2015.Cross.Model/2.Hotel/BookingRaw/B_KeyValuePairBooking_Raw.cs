using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.BookingRaw
{
    public class B_KeyValuePairBooking_Raw
    {
        public int ID { get; set; }

        public Guid ImportID { get; set; }

        public string BookingProcessNo { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }

        public static string Table = "B_KeyValuePairBooking_Raw";
    }
}
