using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Report
{


    public class InvoiceReportByCompanyPlatform
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

        private string companyAddress;

        public string CompanyAddress
        {
            get { return companyAddress; }
            set { companyAddress = value; }
        }

        private long totalInvoice;

        public long TotalInvoice
        {
            get { return totalInvoice; }
            set { totalInvoice = value; }
        }

        public  List<InvoiceReportByPlatform> ListDataByPlatform {get; set;}

        public List<InvoiceReportByCompanyPlatform> ListChildCompany { get; set; }

        public InvoiceReportByCompanyPlatform()
        {
            ID = 0;
            CompanyName = string.Empty;
            CompanyAddress = string.Empty;
            TotalInvoice = 0;
            ListDataByPlatform = new List<InvoiceReportByPlatform>();
            ListChildCompany = new List<InvoiceReportByCompanyPlatform>();
        }
    }

    public class InvoiceReportByPlatform
    {
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

        private long m_ProcessID;
        public long M_ProcessID
        {
            get { return m_ProcessID; }
            set { m_ProcessID = value; }
        }

        private string project;

        public string Project
        {
            get { return project; }
            set { project = value; }
        }

        private long countImage;

        public long CountImage
        {
            get { return countImage; }
            set { countImage = value; }
        }

    }


    public class InvoiceReport 
    {
        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string _hotelPlatformName;

        public string HotelPlatformName
        {
            get { return _hotelPlatformName; }
            set { _hotelPlatformName = value; }
        }

        private long parentID;

        public long ParentID
        {
            get { return parentID; }
            set { parentID = value; }
        }

        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        private string companyAddress;

        public string CompanyAddress
        {
            get { return companyAddress; }
            set { companyAddress = value; }
        }
        private long countImage;

        public long CountImage
        {
            get { return countImage; }
            set { countImage = value; }
        }
        private string project;

        public string Project
        {
            get { return project; }
            set { project = value; }
        }

        private long m_ProccessID;
        public long M_ProccessID
        {
            get { return m_ProccessID; }
            set { m_ProccessID = value; }
        }


        private long m_HotelPlatformID;
        public long M_HotelPlatformID
        {
            get { return m_HotelPlatformID; }
            set { m_HotelPlatformID = value; }
        }


        private long totalInvoice;

        public long TotalInvoice
        {
            get { return totalInvoice; }
            set { totalInvoice = value; }
        }


        public List<InvoiceReport> ListChildCompany { get; set; }
    }

    public enum InvoiceReportStoreProcedure
    {
        p_MonthlyReport_Get_InvoiceReport
        
    }
}
