﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Financial.SBF
{
    public class SBF_E_Transaction
    {
        public F_Transaction Transaction { get; set; }
        public F_E_SBF_5 TransactionDetail { get; set; }
        public SBF_E_Account Account { get; set; }
        public List<F_E_SBF_4> ListTransactionAddendum { get; set; }
        public List<F_E_SBF_6> ListTransactionAddendumAmea { get; set; }
    }
}
