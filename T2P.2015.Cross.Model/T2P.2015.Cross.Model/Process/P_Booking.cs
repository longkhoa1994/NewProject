using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_BookingSearch
    {
        private long _companyParentID;

        public long CompanyParentID
        {
            get { return _companyParentID; }
            set { _companyParentID = value; }
        }

        private long _companyProcessID;

        public long CompanyProcessID
        {
            get { return _companyProcessID; }
            set { _companyProcessID = value; }
        }

        private string _checkingStatus;

        public string CheckingStatus
        {
            get { return _checkingStatus; }
            set { _checkingStatus = value; }
        }

        private string _parentCompanyName;

        public string ParentCompanyName
        {
            get { return _parentCompanyName; }
            set { _parentCompanyName = value; }
        }

        private string _parentCompanyShortName;

        public string ParentCompanyShortName
        {
            get { return _parentCompanyShortName; }
            set { _parentCompanyShortName = value; }
        }

        private long totalRecord;

        public long TotalRecord
        {
            get { return totalRecord; }
            set { totalRecord = value; }
        }

        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private long bookingID;

        public long BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }

        private string bookingNo;

        public string BookingNo
        {
            get { return bookingNo; }
            set { bookingNo = value; }
        }
        private string companyName;

        private string companyList;

        public string CompanyList
        {
            get { return companyList; }
            set { companyList = value; }
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        private string companyShortName;

        public string CompanyShortName
        {
            get { return companyShortName; }
            set { companyShortName = value; }
        }

        private long companyID;

        public long CompanyID
        {
            get { return companyID; }
            set { companyID = value; }
        }

        private string customerNo;

        public string CustomerNo
        {
            get { return customerNo; }
            set { customerNo = value; }
        }

        private string subID;

        public string SubID
        {
            get { return subID; }
            set { subID = value; }
        }

        private string hotelNo;

        private string hotelList;

        public string HotelList
        {
            get { return hotelList; }
            set { hotelList = value; }
        }

        public string HotelNo
        {
            get { return hotelNo; }
            set { hotelNo = value; }
        }
        private string hotelName;

        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }
        private DateTime checkIn;

        public DateTime CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }
        }
        private DateTime checkOut;

        public DateTime CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }
        private string travelerName;

        public string TravelerName
        {
            get { return travelerName; }
            set { travelerName = value; }
        }

        private string travelerID;

        public string TravelerID
        {
            get { return travelerID; }
            set { travelerID = value; }
        }

        private string bC1;

        public string BC1
        {
            get { return bC1; }
            set { bC1 = value; }
        }
        private string bC2;

        public string BC2
        {
            get { return bC2; }
            set { bC2 = value; }
        }
        private string bSP;

        public string BSP
        {
            get { return bSP; }
            set { bSP = value; }
        }
        private string bCA;

        public string BCA
        {
            get { return bCA; }
            set { bCA = value; }
        }
        private string fC1;

        public string FC1
        {
            get { return fC1; }
            set { fC1 = value; }
        }
        private string fC2;

        public string FC2
        {
            get { return fC2; }
            set { fC2 = value; }
        }
        private string iR1;

        public string IR1
        {
            get { return iR1; }
            set { iR1 = value; }
        }
        private string iR2;

        public string IR2
        {
            get { return iR2; }
            set { iR2 = value; }
        }
        private string noOfInvoice;

        public string NoOfInvoice
        {
            get { return noOfInvoice; }
            set { noOfInvoice = value; }
        }
        private string noOfFin;

        public string NoOfFin
        {
            get { return noOfFin; }
            set { noOfFin = value; }
        }

        private string bookingStatus;

        public string BookingStatus
        {
            get { return bookingStatus; }
            set { bookingStatus = value; }
        }

        private string bookerName;

        public string BookerName
        {
            get { return bookerName; }
            set { bookerName = value; }
        }

        private string _paymentMethod;

        public string PaymentMethod
        {
            get { return _paymentMethod; }
            set { _paymentMethod = value; }
        }

        private string _hotelPlatformName;

        public string HotelPlatformName
        {
            get { return _hotelPlatformName; }
            set { _hotelPlatformName = value; }
        }
    }

    public class P_BookingSearch_Company
    {
        private string _parentCompanyName;

        public string ParentCompanyName
        {
            get { return _parentCompanyName; }
            set { _parentCompanyName = value; }
        }

        private string _parentCompanyShortName;

        public string ParentCompanyShortName
        {
            get { return _parentCompanyShortName; }
            set { _parentCompanyShortName = value; }
        }

        private string _companyName;

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        private long _companyID;

        public long CompanyID
        {
            get { return _companyID; }
            set { _companyID = value; }
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

        private List<P_BookingSearch> _listBooking;

        public List<P_BookingSearch> ListBooking
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

    public class P_Booking_Detail_Extend : B_BookingDetail
    {
        private long _travelerID;

        public long TravelerID
        {
            get { return _travelerID; }
            set { _travelerID = value; }
        }

        private string _salutation;

        public string Salutation
        {
            get { return _salutation; }
            set { _salutation = value; }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
    }

    public class P_Booking_Detail : B_BookingDetail
    {
        private List<P_Booking_Detail_Traveler> _listTraveler;

        public List<P_Booking_Detail_Traveler> ListTraveler
        {
            get { return _listTraveler; }
            set { _listTraveler = value; }
        }
    }

    public class P_Booking_Detail_Traveler
    {
        private long _travelerID;

        public long TravelerID
        {
            get { return _travelerID; }
            set { _travelerID = value; }
        }

        private string _salutation;

        public string Salutation
        {
            get { return _salutation; }
            set { _salutation = value; }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
    }
}
