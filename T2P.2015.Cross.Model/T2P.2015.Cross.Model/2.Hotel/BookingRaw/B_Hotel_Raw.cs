using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.BookingRaw
{
    public class B_Hotel_Raw
    {
        public int ID { get; set; }

        public Guid ImportID { get; set; }

        public string BookingProcessNo { get; set; }

        public string HotelNo { get; set; }

        public string HotelName { get; set; }

        public string Street { get; set; }

        public string HotelName_Latin { get; set; }

        public string Street_Latin { get; set; }

        public string ZipCode { get; set; }

        public string CityName { get; set; }

        public string CityName_Latin { get; set; }

        public string CountryName { get; set; }

        public string CountryCode { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public string FormatPhone { get; set; }

        public string FormatFax { get; set; }

        public string Email { get; set; }
       
        public bool IsSendingEmail { get; set; }

        public bool IsSendingFax { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public string CommunicationLanguages { get; set; }

        public string Timezone { get; set; }

        public decimal UpdatedTimezone { get; set; }

        public int? M_LanguageID { get; set; }

        public int? M_CountryID { get; set; }

        public int? M_TimeZoneID { get; set; }

        public static string Table = "B_Hotel_Raw";
    }
}
