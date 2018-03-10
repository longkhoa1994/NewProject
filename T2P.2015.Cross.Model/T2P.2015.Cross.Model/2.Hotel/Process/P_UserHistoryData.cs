using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_UserHistoryData
    {
        public List<A_UserProfile> ListUserProfile { get; set; }
        public List<P_UserLoginHistory> ListUserHistory { get; set; }
    }
}
