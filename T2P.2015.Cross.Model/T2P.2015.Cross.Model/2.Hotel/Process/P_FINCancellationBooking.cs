using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Process
{
    [Serializable]
    public class P_FINCancellationBooking : P_NextFinancialStep
    {
        public bool IsUsedToCancelBooking { get; set; }
        public long B_AccessID { get; set; }
        public string BookingStatus { get; set; }
    }
}
