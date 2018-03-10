using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Financial.Tamara
{
    public class TamaraModel
    {
        public F_TamaraHeader Header { get; set; }
        public List<F_TamaraTransaction> ListTransactions { get; set; }
        public F_TamaraTrailer Trailer { get; set; }
        public TamaraModel(F_TamaraFileType type)
        {
            if (type == F_TamaraFileType.EN)
                Header = new HeaderRecordEN();
            if (type == F_TamaraFileType.MA)
                Header = new HeaderRecordMA();
            ListTransactions = new List<F_TamaraTransaction>();
            Trailer = new F_TamaraTrailer(type);
        }
    }
}
