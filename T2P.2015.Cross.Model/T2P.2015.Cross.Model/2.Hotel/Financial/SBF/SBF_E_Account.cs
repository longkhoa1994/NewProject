using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Financial.SBF
{
    public class SBF_E_Account
    {
        public F_E_SBF_2 AccountHeader { get; set; }
        public F_E_SBF_7 AccountTrailer { get; set; }
    }
}
