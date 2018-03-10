using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Process
{
    [Serializable]
    public class P_CancellationBooking
    {
        private long b_AccessID;    

        public long B_AccessID
        {
          get { return b_AccessID; }
          set { b_AccessID = value; }
        }
        public decimal TotalInvAmount {get;set;}
        public decimal TotalFinAmount { get; set; }
        public int TotalFinRecord { get; set; }
    }
}
