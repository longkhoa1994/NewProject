using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_UserOnline
    {
        public string SessionID { get; set; }
        public long UserID { get; set; }
        public string UserName { get; set; }        
        public string IP { get; set; }
        public string FullName { get; set; }
        public string Customer { get; set; }
        public string Role { get; set; }
        public string Duration { get; set; }
        public DateTime DurationTime { get; set; }
        public DateTime LoginTime { get; set; }
        public string Location { get; set; }
        public bool Status { get; set; }
        public string HotelPlatformName { get; set; }
        public long TotalRecords { get; set; }
    }
}
