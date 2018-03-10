using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model.Report;

namespace T2P._2015.Cross.Model.Process
{
    public class P_MonthlyReport:BaseModel
    {
        public List<MonthlyReportByCompanyPlatform> ListMonthlyReport { get; set; }
        public List<InvoiceReportByCompanyPlatform> ListInvoiceReport { get; set; }

        public long ?HotelPlatForm { get; set; }
        public decimal SumInvoiceReport { get; set; }
        public List<NotificationReport> ListNotificationReport { get; set; }
        private long totalRecordNotification;

        public long TotalRecordNotification
        {
            get { return totalRecordNotification; }
            set { totalRecordNotification = value; }
        }
        public List<BillingReport> ListBillingReport { get; set; }

        public string FilePathDownload { get; set; }

        private long totalRecord;

        public long TotalRecord
        {
            get { return totalRecord; }
            set { totalRecord = value; }
        }
    }
}
