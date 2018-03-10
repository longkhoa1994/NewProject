using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using T2P._2015.Cross.Enum;

namespace T2P._2015.Cross.Model
{
    public class F_DisplayHistoryFile 
    {
        public long ImportFileID { get; set; }
        public string CurrencyCode { get; set; }
        public string Username { get; set; }
        public string FileName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ResNo { get; set; }
        public string Amount { get; set; }
        public string IsDebit { get; set; }
        public string HotelName { get; set; }
        public string FinancialStatus { get; set; }
        public string FilePath { get; set; }
        public int FileStatus { get; set; }
        public long CompanyDeliveryID { get; set; }
        public long ExportFileID { get; set; }
        public string ConvertFileName { get; set; }
        public long ExportFileHistoryID { get; set; }
    }

    public class ReponseDisplayHistory
    {
        public long key { get; set; }
        public List<F_DisplayHistoryFile> history { get; set; }
    }
}