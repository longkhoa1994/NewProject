using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.CarRental._4.Report
{
    [Serializable]
    public class RC_MonthlyReport
    {
        public List<RC_CustomerReport> CustomerReport;

        public string ReportFilePath;

        public int TotalRecords;

        public RC_MonthlyReport()
        {
            CustomerReport = new List<RC_CustomerReport>();
            ReportFilePath = string.Empty;
            TotalRecords = 0;
        }
    }

    public class RC_CustomerReport
    {
        private long _customerId;
        public long CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        private string _customerName;
        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }

        private decimal _amount;
        public decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        private decimal? _factor;
        public decimal? Factor
        {
            get { return _factor; }
            set { _factor = value; }
        }

        public decimal TotalAmount;
        public DateTime FromDate;
        public DateTime ToDate;

        public RC_CustomerReport()
        {

        }
    }

    public enum RC_CustomerReportProcedure
    {
        p_R_R_CustomerReport_GetMonthlyReport
    }

}
