using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_DuplicatedHotel
    {
        public M_Hotel Hotel { get; set; }
        public List<M_HotelProcess> ListHotelProcess { get; set; }

        public P_DuplicatedHotel()
        {
            Hotel = new M_Hotel();
            ListHotelProcess = new List<M_HotelProcess>();
        }
    }
}
