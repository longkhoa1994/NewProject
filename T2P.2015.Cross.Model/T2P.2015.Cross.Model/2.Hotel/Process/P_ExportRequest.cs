using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Process
{
    public class P_ExportRequest
    {
        public long ExportRequestID { get; set; }
        public string CompanyCode { get; set; }
        public int FileType { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
