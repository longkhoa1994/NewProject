using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.BookingRaw
{
    public class B_Traveler_Raw
    {
        public int ID { get; set; }

        public Guid ImportID { get; set; }

        public string BookingProcessNo { get; set; }

        public string BookingNo { get; set; }

        public string Salutation { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FirstName_Latin { get; set; }

        public string LastName_Latin { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public int? M_TravelerID { get; set; }

        public static string Table = "B_Traveler_Raw";
    }
}
