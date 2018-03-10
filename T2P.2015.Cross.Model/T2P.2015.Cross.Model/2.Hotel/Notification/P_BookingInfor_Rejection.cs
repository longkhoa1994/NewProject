using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  T2P._2015.Cross.Model
{
   public class P_BookingInfor_Rejection
    {
        private string _travellers;

        public string Travellers
        {
            get { return _travellers; }
            set { _travellers = value; }
        }
        private string _checkOutDate;

        public string CheckOutDate
        {
            get { return _checkOutDate; }
            set { _checkOutDate = value; }
        }
       
    }
}
