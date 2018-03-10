using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Process
{
    public class P_DownloadCenter_ArchiveAirplusFile
    {
        public List<P_DownloadCenter_ArchiveRequestDetail> listArchiveRequestDetail;
    }

    public class P_DownloadCenter_ArchiveRequestDetail
    {
        public I_ArchiveRequestDetail archiveRequestDetail;
        public List<I_ArchiveRequestFileDetail> listRequestFileDetail;
    }

    public class P_DownloadCenter_Numbers
    {
        public string FilePath { get; set; }
        public long FinancialID { get; set; }
        public string BookingNo { get; set; }
        public string InvoiceNo { get; set; }
        public long F_ImportFileID { get; set; }
    }
}
