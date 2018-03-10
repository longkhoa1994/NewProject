using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Report
{
    public class P_MonthlyReport
    {
        public List<MonthlyReport> ListMonthlyReport {get;set;}
        public List<InvoiceReport> ListInvoiceReport { get; set; }
        public List<NotificationReport> ListNotificationReport { get; set; }
        public List<BillingReport> ListBillingReport { get; set; }
    }
}
