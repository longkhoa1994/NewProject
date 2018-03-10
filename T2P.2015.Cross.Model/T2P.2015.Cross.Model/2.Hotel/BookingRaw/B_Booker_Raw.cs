using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.BookingRaw
{
    public class B_Booker_Raw
    {
        public int ID { get; set; }

        public Guid ImportID { get; set; }

        public string BookingProcessNo { get; set; }

        public string Salutation { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Street { get; set; }

        public string ZipCode { get; set; }

        public string CityName { get; set; }

        public string CountryCode { get; set; }
        
        public int? M_CountryID { get; set; }

        public static string Table = "B_Booker_Raw";
    }
}
