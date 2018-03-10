using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Notification
{
    public class N_CostAcceptanceCancellation:BaseModel
    {
        public string Fax { get; set; }
        public long M_CompanyID { get; set; }
        public long BookingID { get; set; }
        public string BookingNo { get; set; }
        public string HotelName { get; set; }
        public string TravelerName { get; set; }
        public string BookingNumberInterval { get; set; }
        public string BookingNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string VCCNo { get; set; }
        public DateTime SentDate { get; set; }
        public string IISPath { get; set; }
    }
}
