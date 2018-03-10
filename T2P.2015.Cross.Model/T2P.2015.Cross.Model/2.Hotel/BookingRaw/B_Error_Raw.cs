using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.BookingRaw
{
    [Serializable]
    public class B_Error_Raw
    {
        public int ID { get; set; }

        public Guid ImportID { get; set; }

        public string BookingProcessNo { get; set; }

        public string Message { get; set; }

        public static string Table = "B_Error_Raw";
    }
}
