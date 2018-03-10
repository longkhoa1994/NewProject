using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Financial.Tamara
{
    public class HeaderRecordMA : F_TamaraHeader
    {
        public HeaderRecordMA()
        {
            AcquirerProcessingPage = "002";
            FileType = "M";
            SICCode = "MA";
        }
    }
}
