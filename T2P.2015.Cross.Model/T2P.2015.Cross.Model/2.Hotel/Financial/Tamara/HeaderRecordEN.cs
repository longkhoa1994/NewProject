using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Financial.Tamara
{
    public class HeaderRecordEN : F_TamaraHeader
    {
        public string BosId { get; set; }
        public HeaderRecordEN()
        {
            AcquirerProcessingPage = "001";
            FileType = "E";
            SICCode = "EN";
            BosId = string.Empty;
        }
    }
}
