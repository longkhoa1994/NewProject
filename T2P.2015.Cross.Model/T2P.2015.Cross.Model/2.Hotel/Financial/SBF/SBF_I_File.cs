using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Financial.SBF
{
    public class SBF_I_File
    {
        public F_I_SBF_0_0 FileHeader { get; set; }
        public F_I_SBF_0_0000000 FileTrailer { get; set; }
    }
}
