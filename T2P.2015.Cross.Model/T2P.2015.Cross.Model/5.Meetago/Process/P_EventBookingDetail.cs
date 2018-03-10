using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._5.Meetago.Process
{
    public class P_EventBookingDetail
    {
        public bool isEditPermission { get; set; }
        public List<A_UserProfile> ListUser { get; set; }
        public List<M_Code> ListStopCode { get; set; }
        public bool useDC0 { get; set; }
        public bool useSNL { get; set; }
        public bool useSND { get; set; }
        public bool useDCI { get; set; }
        public bool useSCI { get; set; } 
        public List<P_EventInfomation> ListEventInformation { get; set; }
    }
}
