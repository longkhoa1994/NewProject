using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Financial.GL1025
{
    public class GL1025_FileExport
    {
        public GL1025_E_File File { get; set; }
        public List<GL1025_E_Market> ListMarket { get; set; }
    }

    public class GL1025_E_File
    {
        public F_E_GL1025_0 FileHeader { get; set; }
        public F_E_GL1025_9 FileTrailer { get; set; }
    }

    public class GL1025_E_Market
    {
        public F_E_GL1025_8 Market { get; set; }
        public List<GL1025_E_Transaction> ListTransaction { get; set; }
    }

    public class GL1025_E_Transaction
    {
        public F_E_GL1025_1 TransactionDetail { get; set; }
        public F_E_GL1025_2 CardMemberSummary { get; set; }
        public F_E_GL1025_3 PreAuthData { get; set; }
    }
}
