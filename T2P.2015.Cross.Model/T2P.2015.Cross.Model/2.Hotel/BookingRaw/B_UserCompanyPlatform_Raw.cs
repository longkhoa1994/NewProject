using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.BookingRaw
{
    [Serializable]
    public class B_UserCompanyPlatform_Raw
    {
        public int ID { get; set; }

        public Guid ImportID { get; set; }

        public int? A_UserProfileID { get; set; }

        public int? M_CompanyID { get; set; }

        public int? M_HotelPlatformID { get; set; }

        public int? Permission { get; set; }

        public static string Table = "B_UserCompanyPlatform_Raw";
    }
}
