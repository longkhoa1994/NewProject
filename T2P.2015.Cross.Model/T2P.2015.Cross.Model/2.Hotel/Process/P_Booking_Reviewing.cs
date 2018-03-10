using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Process
{
    public class P_Booking_Reviewing : BaseModel
    {
        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string _bookingNo;

        public string BookingNo
        {
            get { return _bookingNo; }
            set { _bookingNo = value; }
        }

        private DateTime _receivedDate;

        public DateTime ReceivedDate
        {
            get { return _receivedDate; }
            set { _receivedDate = value; }
        }

        private string _fKey;

        public string FKey
        {
            get { return _fKey; }
            set { _fKey = value; }
        }

        private string _kKey;

        public string KKey
        {
            get { return _kKey; }
            set { _kKey = value; }
        }

        private string _companyName;

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        //private string _companyAddress;

        //public string CompanyAddress
        //{
        //    get { return _companyAddress; }
        //    set { _companyAddress = value; }
        //}

        private string _street;

        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }
        private string _zipCode;

        public string ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }
        private string _cityName;

        public string CityName
        {
            get { return _cityName; }
            set { _cityName = value; }
        }

        private long _totalRecords;

        public long TotalRecords
        {
            get { return _totalRecords; }
            set { _totalRecords = value; }
        }

        private bool isCheck;

        public bool IsCheck
        {
            get { return isCheck; }
            set { isCheck = value; }
        }
    }

    public enum P_Booking_ReviewingProcedure
    {
        p_P_Booking_Reviewing_GetSearch,
        p_P_Booking_Reviewing_Action
    }

    public class ListBookingReview
    {
        private List<P_Booking_Reviewing> _listBooking;

        public List<P_Booking_Reviewing> ListBooking
        {
            get { return _listBooking; }
            set { _listBooking = value; }
        }


        private long _totalRecords;
        public long TotalRecords
        {
            get { return _totalRecords; }
            set { _totalRecords = value; }
        }
    }
}
