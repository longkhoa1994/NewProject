using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._5.Meetago.Process
{
    public class P_ContractListingItem
    {
        public long EventID { get; set; }
        public string EventNo { get; set; }
        public string EventTitle { get; set; }
        public long HotelID { get; set; }
        public string HotelNo { get; set; }
        public string HotelName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string RequestLanguage { get; set; }
        public string StatusID { get; set; }
        public long ContractID { get; set; }
        public long BookingID { get; set; }
        public DateTime ContractDate { get; set; }
        public bool Commissionable { get; set; }
        public string OfferNo { get; set; }
        public DateTime OfferDate { get; set; }
        public long Verification { get; set; }
        public long BookerID { get; set; }
        public string BookerFirstName { get; set; }
        public string BookerLastName { get; set; }
        public DateTime PackageDate { get; set; }
        public int PackageQuantityContract { get; set; }
        public float PackagePricePerPerson { get; set; }
        public string RoomType { get; set; }
        public int RoomQuantityContract { get; set; }
        public float RoomPricePerNight { get; set; }
    }
}
