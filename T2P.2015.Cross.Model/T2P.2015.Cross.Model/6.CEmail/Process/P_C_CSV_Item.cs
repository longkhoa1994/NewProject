using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._6.CEmail.Process
{
    public class P_C_CSV : C_CSV_Header
    {
        private string _emailBI;
        public string EmailBI
        {
            get { return _emailBI; }
            set { _emailBI = value; }
        }
        public long C_BI_ItemID { get; set; }
        
        public ICollection<C_CSV_Item> CSVItems { get; set; }
    }

    public class P_C_CSV_Header : C_CSV_Header 
    {
        public C_Export_CSV CSVExportFileInfo { get; set; }
        public List<string> FileData { get; set; }
        public string StoredFilePath { get; set; }

        private string _emailBI;
        public string EmailBI
        {
            get { return _emailBI; }
            set { _emailBI = value; }
        }
        public P_C_CSV_Header()
        {
            CSVExportFileInfo = new C_Export_CSV();
        }
    }

    public class P_C_Header : C_Header
    {
        public C_Export_Header CSVExportHeader { get; set; }
        public ICollection<P_C_CSV_Header> Files { get; set; }
        public ICollection<C_Image> Images { get; set; }

        public P_C_Header()
        {
            CSVExportHeader = new C_Export_Header();
        }
    }
}
