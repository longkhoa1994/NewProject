using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Financial.SBF
{
    public class SBF_I_Account
    {
        public F_I_SBF_2 AccountHeader { get; set; }
        public F_I_SBF_7 AccountTrailer { get; set; }   
    }
}
