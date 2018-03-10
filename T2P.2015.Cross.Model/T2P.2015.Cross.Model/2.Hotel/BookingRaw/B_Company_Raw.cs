using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.BookingRaw
{
    public class B_Company_Raw
    {
        public int ID { get; set; }

        public Guid ImportID { get; set; }

        public string BookingProcessNo { get; set; }

        public string CompanyName { get; set; }

        public string CompanyShortName { get; set; }

        public string CompanyAddress { get; set; }

        public string CustomerNo { get; set; }

        public string CompanyEmail { get; set; }

        public string ZipCode { get; set; }

        public string CityName { get; set; }

        public string CustomerAccountNumber { get; set; }

        public DateTime? ExpiryDate { get; set; }
       
        public int? M_LanguageID { get; set; }

        public int? M_CountryID { get; set; }

        public int? M_TimeZoneID { get; set; }

        public decimal UpdatedTimezone { get; set; }

        public static string Table = "B_Company_Raw";
    }
}
