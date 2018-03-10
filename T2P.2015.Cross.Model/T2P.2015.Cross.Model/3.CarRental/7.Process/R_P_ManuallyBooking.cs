using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._3.CarRental._7.Process
{
    public class R_P_ManuallyBooking : BaseModel
    {
        public long BookingID { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string CustNo { get; set; }
        
        //pickup Date
        public DateTime Date { get; set; }

        //pickup Time
        public string Hours { get; set; }
        public string Min { get; set; }

        public string ResNo { get; set; }

        public string ReturnCity { get; set; }
        public string ReturnCountry { get; set; }
        public string PickupCountryCode { get; set; }
        public string ReturnCountryCode { get; set; }
        public DateTime ReturnDate { get; set; }
        public string ReturnHours { get; set; }
        public string ReturnMin { get; set; }
        public string Comment { get; set; }
        public M_Currency Currency { get; set; }
        public decimal? Price { get; set; }

        public long ProviderID { get; set; }
        public string ProviderName { get; set; }
        public string TravelerEmail { get; set; }
        public string TravelerFirstName { get; set; }
        public string TravelerLastName { get; set; }
        public string ReservationStatus { get; set; }

        public long CompanyID { get; set; }
        public R_M_SippCode CarCategory { get; set; }

        //when select option: Other
        public R_M_SippCode CarCategory2 { get; set; }
        public R_M_Customer CustName { get; set; }
    }
}
