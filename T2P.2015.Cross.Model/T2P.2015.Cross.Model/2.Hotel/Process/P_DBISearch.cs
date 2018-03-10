using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model.View;

namespace T2P._2015.Cross.Model._2.Hotel.Process
{
    public class P_DBI_Request : V_Pagination
    {
        public int MaximumRecords { get; set; }
        public string Action { get; set; }
        public string DBI { get; set; }
        public string ReservationNumber { get; set; }
        public string HotelName { get; set; }
        public string HotelNumber { get; set; }
        public string TravelerName { get; set; }
        public DateTime? CheckInFrom { get; set; }
        public DateTime? CheckInTo { get; set; }
        public DateTime? CheckOutFrom { get; set; }
        public DateTime? CheckOutTo { get; set; }
        public string CompanyName { get; set; }
        public long CompanyID { get; set; }
        public long ParentCompanyID { get; set; }

        public List<string> Status { get; set; }

        public P_DBI_Request()
        {
            DBI = string.Empty;
            ReservationNumber = string.Empty;
            HotelName = string.Empty;
            HotelNumber = string.Empty;
            TravelerName = string.Empty;
            CheckInFrom = null;
            CheckInTo = null;
            CheckOutFrom = null;
            CheckOutTo = null;
        }
    }

    public class P_DBI_Permission
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class P_DBI_Data : P_DBI_TravelerDBI_Data
    {
        public string PathFileExport { get; set; }
        public string ReservationNumber { get; set; }
        public long B_AccessID { get; set; }
        public long M_HotelID { get; set; }
        public string HotelName { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public string ResAmount { get; set; }
        public string InvAmount { get; set; }
        //public string TravelerDBI { get; set; }
        public List<P_DBI_TravelerDBI_Data> ListTravelerDBI { get; set; }
        public string Status { get; set; }
        public long CompanyParentID { get; set; }
        public long CompanyProcessID { get; set; }
        public string CompanyName { get; set; }
        public long CompanyID { get; set; }
        public string CompanyAlias { get; set; }
        public string CustomerNo { get; set; }
        public string SubID { get; set; }
        public int ValidateFkey { get; set; }

        public P_DBI_Data() 
        {
            ListTravelerDBI = new List<P_DBI_TravelerDBI_Data>();
        }
    }

    public class P_DBI_TravelerDBI_Data
    {
        public string TravelerName { get; set; }
        public string PK { get; set; }
        public string KS { get; set; }
        public string DS { get; set; }
        public string AE { get; set; }
        public string IK { get; set; }
        public DateTime? BD { get; set; }
        public string PR { get; set; }
        public string AU { get; set; }
        public string RZ { get; set; }
    }

    public class P_DBI_Search_Company
    {
        private string _pathFileExport;

        public string PathFileExport
        {
            get { return _pathFileExport; }
            set { _pathFileExport = value; }
        }

        private string _parentCompanyName;

        public string ParentCompanyName
        {
            get { return _parentCompanyName; }
            set { _parentCompanyName = value; }
        }

        private string _companyAlias;

        public string CompanyAlias
        {
            get { return _companyAlias; }
            set { _companyAlias = value; }
        }

        private long _companyID;

        public long CompanyID
        {
            get { return _companyID; }
            set { _companyID = value; }
        }

        private string _companyName;
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }


        private string _customerNo;

        public string CustomerNo
        {
            get { return _customerNo; }
            set { _customerNo = value; }
        }

        private string _subID;

        public string SubID
        {
            get { return _subID; }
            set { _subID = value; }
        }

        public List<P_DBI_Data> _listData;

        public List<P_DBI_Data> ListData
        {
            get { return _listData; }
            set { _listData = value; }
        }



    }

}
