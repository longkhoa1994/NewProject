using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._5.Meetago.Booking
{
    public class B_AdditionalData : BaseModel
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public enum B_AdditionalDataProcedure
    {
        p_B_AdditionalData_GetBy_B_BookingDetailID
    }
}
