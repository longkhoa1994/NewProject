using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.BookingRaw
{
    public class B_Pos_Raw
    {
        public int ID { get; set; }

        public Guid ImportID { get; set; }

        public string BookingProcessNo { get; set; }

        public string RequesterID { get; set; }

        public string CompanyID { get; set; }

        public string CompanyName { get; set; }

        public string VatIdentificationNumber { get; set; }

        public string BookingChannelType { get; set; }

        public static string Table = "B_Pos_Raw";
    }
}
