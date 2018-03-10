using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    public class P_AirbnbImportBooking
    {
        public long M_CompanyProcessDetailID { get; set; }
        public long M_CompanyID { get; set; }
        public string CompanyName { get; set; }
        public long M_HotelPlatformID { get; set; }
        public string HotelPlatformName { get; set; }
        public long M_FileLocationID { get; set; }
        public string Airbnb_MailUsername { get; set; }
        public string Airbnb_MailPassword { get; set; }

        public int Airbnb_MailPort { get; set; }

        public bool Airbnb_MailSSL { get; set; }

        public string Airbnb_LoginUsername { get; set; }
        public string Airbnb_LoginPassword { get; set; }

        public string Airbnb_MailServer { get; set; }
        public int LimitFileSize { get; set; }

        public List<P_AirbnbImportBookingItem> P_AirbnbImportBookingItem { get; set; }

        //M_FileLocation M_FileLocation { get; set; }

        //M_HotelPlatform M_HotelPlatform { get; set; }

        public P_AirbnbImportBooking()
        {
            P_AirbnbImportBookingItem = new List<P_AirbnbImportBookingItem>();
        }

    }

    public class P_AirbnbImportBookingItem
    {
        public string EmailFile { get; set; }
        
        public string MessageID { get; set; }
        public string BookingNo { get; set; }

       
    }
}
