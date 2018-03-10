using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Financial.Tamara
{
    public class TransactionRecordEN : F_TamaraTransaction
    {
        public string Filler { get; set; }
        public string Filler1 { get; set; }
        public string Filler2 { get; set; }
        public TransactionRecordEN()
        {
            Filler = string.Empty;
            Filler1 = string.Empty;
            Filler2 = string.Empty;
        }
    }
}

