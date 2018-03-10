﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Financial.SBF
{
    public class SBF_E_Company
    {
        public F_E_SBF_1 CompanyHeader { get; set; }
        public F_E_SBF_8 CompanyTrailer { get; set; }
        public F_Header Header { get; set; }
        public List<SBF_E_Transaction> ListTransactions { get; set; }
    }
}
