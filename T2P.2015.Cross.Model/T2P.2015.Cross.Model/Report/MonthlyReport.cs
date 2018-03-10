using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{

    public class MonthlyReportByCompanyPlatform
    {
        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public List<MonthlyReport> ListDetail { get; set; }

        public MonthlyReportByCompanyPlatform()
        {
            ID = 0;
            CompanyName = string.Empty;
            ListDetail = new List<MonthlyReport>();
        }
    }



    public class MonthlyReport 
    {
        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        private string product;

        public string Product
        {
            get { return product; }
            set { product = value; }
        }
        private string productOption;

        public string ProductOption
        {
            get { return productOption; }
            set { productOption = value; }
        }
        private decimal amountBooking;

        public decimal AmountBooking
        {
            get { return amountBooking; }
            set { amountBooking = value; }
        }
        private decimal factor;

        public decimal Factor
        {
            get { return factor; }
            set { factor = value; }
        }
        private decimal totalAmount;

        public decimal TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }
        private DateTime fromDate;

        public DateTime FromDate
        {
            get { return fromDate; }
            set { fromDate = value; }
        }
        private DateTime toDate;

        public DateTime ToDate
        {
            get { return toDate; }
            set { toDate = value; }
        }

        private long m_HotelPlatformID;

        public long M_HotelPlatformID
        {
            get { return m_HotelPlatformID; }
            set { m_HotelPlatformID = value; }
        }

        private string _hotelPlatformName;

        public string HotelPlatformName
        {
            get { return _hotelPlatformName; }
            set { _hotelPlatformName = value; }
        }
    }

    public enum MonthlyReportStoreProcedure
    {
        p_MonthlyReport_Get_MonthlyReport
        
    }
}
