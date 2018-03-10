using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._6.CEmail
{
    public class C_DownloadEmail
    {
        public C_BIReport_Header BIReportHeader { get; set; }

        public List<C_BIReport_Item> ListBIReportItem { get; set; }

        public C_DownloadEmail()
        {           
            BIReportHeader = new C_BIReport_Header();
            ListBIReportItem = new List<C_BIReport_Item>();
            
        }
    }
}
