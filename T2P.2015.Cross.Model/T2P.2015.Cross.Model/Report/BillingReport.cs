using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    public class BillingReport:BaseModel
    {
        private long b_AccessID;

        public long B_AccessID
        {
            get { return b_AccessID; }
            set { b_AccessID = value; }
        }
        private long i_DataID;

        public long I_DataID
        {
            get { return i_DataID; }
            set { i_DataID = value; }
        }
        private string invoiceNo;

        public string InvoiceNo
        {
            get { return invoiceNo; }
            set { invoiceNo = value; }
        }
        private string customerNo;

        public string CustomerNo
        {
            get { return customerNo; }
            set { customerNo = value; }
        }
        private string reservationNo;

        public string ReservationNo
        {
            get { return reservationNo; }
            set { reservationNo = value; }
        }
        private string hotelName;

        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }
        private string hotelNumber;

        public string HotelNumber
        {
            get { return hotelNumber; }
            set { hotelNumber = value; }
        }
        private DateTime checkInDate;

        public DateTime CheckInDate
        {
            get { return checkInDate; }
            set { checkInDate = value; }
        }
        private DateTime checkOutDate;

        public DateTime CheckOutDate
        {
            get { return checkOutDate; }
            set { checkOutDate = value; }
        }
        private string guestName;

        public string GuestName
        {
            get { return guestName; }
            set { guestName = value; }
        }

        private string hotelPlatformName;

        public string HotelPlatformName
        {
            get { return hotelPlatformName; }
            set { hotelPlatformName = value; }
        }

        private string _dBI_PK;

        public string DBI_PK
        {
            get { return _dBI_PK; }
            set { _dBI_PK = value; }
        }
        private string _dBI_KS;

        public string DBI_KS
        {
            get { return _dBI_KS; }
            set { _dBI_KS = value; }
        }
        private string _dBI_DS;

        public string DBI_DS
        {
            get { return _dBI_DS; }
            set { _dBI_DS = value; }
        }
        private string _dBI_AE;

        public string DBI_AE
        {
            get { return _dBI_AE; }
            set { _dBI_AE = value; }
        }
        private string _dBI_IK;

        public string DBI_IK
        {
            get { return _dBI_IK; }
            set { _dBI_IK = value; }
        }
        private string _dBI_BD;

        public string DBI_BD
        {
            get { return _dBI_BD; }
            set { _dBI_BD = value; }
        }
        private string _dBI_PR;

        public string DBI_PR
        {
            get { return _dBI_PR; }
            set { _dBI_PR = value; }
        }
        private string _dBI_AU;

        public string DBI_AU
        {
            get { return _dBI_AU; }
            set { _dBI_AU = value; }
        }
        private string _dBI_AK;

        public string DBI_AK
        {
            get { return _dBI_AK; }
            set { _dBI_AK = value; }
        }
        private string _dBI_RZ;

        public string DBI_RZ
        {
            get { return _dBI_RZ; }
            set { _dBI_RZ = value; }
        }
        private long totalRecordBilling;

        public long TotalRecordBilling
        {
            get { return totalRecordBilling; }
            set { totalRecordBilling = value; }
        }

       

    }
    public enum BillingStoreProcedure
    {
        p_MonthlyReport_Get_BillingReport
    }
}
