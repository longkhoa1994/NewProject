using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model.Process;

namespace T2P._2015.Cross.Model.Report
{
    public class CallLog
    {
        private int rowNum;
        public int RowNum
        {
            get { return rowNum; }
            set { rowNum = value; }
        }
        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private DateTime callDate;

        public DateTime CallDate
        {
            get { return callDate; }
            set { callDate = value; }
        }

      
        private string hotelName;

        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }

        private string hotelNo;

        public string HotelNo
        {
            get { return hotelNo; }
            set { hotelNo = value; }
        }

        private string hotelAddress;

        public string HotelAddress
        {
            get { return hotelAddress; }
            set { hotelAddress = value; }
        }

        private string countryName;

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        private string countryCode;

        public string CountryCode
        {
            get { return countryCode; }
            set { countryCode = value; }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }


        private string contact;

        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }

       
        private string caller;

        public string Caller
        {
            get { return caller; }
            set { caller = value; }
        }

        private string callDateExport;

        public string CallDateExport
        {
            get { return callDateExport; }
            set { callDateExport = value; }
        }

        private string hotelPlatformName;

        public string HotelPlatformName
        {
            get { return hotelPlatformName; }
            set { hotelPlatformName = value; }
        }


        private long numberOfBookings;

        public long NumberOfBookings
        {
            get { return numberOfBookings; }
            set { numberOfBookings = value; }
        }


        private long totalRecords;

        public long TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

        private bool isShowListBooking;

        public bool IsShowListBooking
        {
            get { return isShowListBooking; }
            set { isShowListBooking = value; }
        }

        public List<P_BookingOfCall> ListBooking { get; set; }

        public CallLog()
        {
            ListBooking = new List<P_BookingOfCall>();
            IsShowListBooking = false;
        }

        public List<CallVolumeByCaller> ListCallVolumeByCaller { get; set; }

        public List<CallVolumeByHotel> ListCallVolumeByHotel { get; set; }

        public List<CallVolumeByCountry> ListCallVolumeByCountry { get; set; }

        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
    }


    public class P_BookingOfCall
    {
        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private long b_AccessID;
        public long B_AccessID
        {
            get { return b_AccessID; }
            set { b_AccessID = value; }
        }

        private string bookingNo;

        public string BookingNo
        {
            get { return bookingNo; }
            set { bookingNo = value; }
        }

        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
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

        private string booker;

        public string Booker
        {
            get { return booker; }
            set { booker = value; }
        }

        private string listTraveler;

        public string ListTraveler
        {
            get { return listTraveler; }
            set { listTraveler = value; }
        }

        private long n_PhoneCallID;

        public long N_PhoneCallID
        {
            get { return n_PhoneCallID; }
            set { n_PhoneCallID = value; }
        }

        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        private long? b_EventID;

        public long? B_EventID
        {
            get { return b_EventID; }
            set { b_EventID = value; }
        }

    }

    public class CallLog1 
    {
        private int rowNum;
        public int RowNum
        {
            get { return rowNum; }
            set { rowNum = value; }
        }
        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private long b_AccessID;
        public long B_AccessID
        {
            get { return b_AccessID; }
            set { b_AccessID = value; }
        }

        private DateTime callDate;

        public DateTime CallDate
        {
            get { return callDate; }
            set { callDate = value; }
        }

        private string bookingNo;

        public string BookingNo
        {
            get { return bookingNo; }
            set { bookingNo = value; }
        }

        private string hotelName;

        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }

        private string countryName;

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        private string countryCode;

        public string CountryCode
        {
            get { return countryCode; }
            set { countryCode = value; }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }


        private string contact;

        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
        private string caller;

        public string Caller
        {
            get { return caller; }
            set { caller = value; }
        }

        private string callDateExport;

        public string CallDateExport
        {
            get { return callDateExport; }
            set { callDateExport = value; }
        }

        private string hotelPlatformName;

        public string HotelPlatformName
        {
            get { return hotelPlatformName; }
            set { hotelPlatformName = value; }
        }


        private long totalRecords;

        public long TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

        public List<CallVolumeByCaller> ListCallVolumeByCaller { get; set; }

        public List<CallVolumeByHotel> ListCallVolumeByHotel { get; set; }

        public List<CallVolumeByCountry> ListCallVolumeByCountry { get; set; }

    }

    public class CallVolumeByCaller 
    {
        private int? rowNum;
        public int? RowNum
        {
            get { return rowNum; }
            set { rowNum = value; }
        }

        private string caller;

        public string Caller
        {
            get { return caller; }
            set { caller = value; }
        }

        private int numberOfCall;
        public int NumberOfCall
        {
            get { return numberOfCall; }
            set { numberOfCall = value; }
        }

        private decimal percent;

        public decimal Percent
        {
            get { return percent; }
            set { percent = value; }
        }

    }

    public class CallVolumeByHotel 
    {
        private int? rowNum;
        public int? RowNum
        {
            get { return rowNum; }
            set { rowNum = value; }
        }

        private string hotelName;

        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }

        private string countryName;

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        private int numberOfCall;
        public int NumberOfCall
        {
            get { return numberOfCall; }
            set { numberOfCall = value; }
        }

        private decimal percent;

        public decimal Percent
        {
            get { return percent; }
            set { percent = value; }
        }

    }

    public class CallVolumeByCountry
    {
        private int? rowNum;
        public int? RowNum
        {
            get { return rowNum; }
            set { rowNum = value; }
        }

        private string countryName;

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

     
        private int numberOfCall;
        public int NumberOfCall
        {
            get { return numberOfCall; }
            set { numberOfCall = value; }
        }

        private decimal percent;

        public decimal Percent
        {
            get { return percent; }
            set { percent = value; }
        }

    }

    public class CallLogExport
    {
        //Call volume by Caller
        public int? Caller_RowNum {get; set;}
        public string Caller_Caller {get; set;}
        public int? Caller_NumberOfCall {get; set;}
        public decimal? Caller_PerCent {get; set;} 
        //Call volume by Hotel
        public int? Hotel_RowNum {get; set;}
        public string Hotel_HotelName { get; set; }
        public string Hotel_CountryName { get; set; }
        public int? Hotel_NumberOfCall {get; set;}
        public decimal? Hotel_Percent {get; set;}
        //Call volume by Country
        public int? Country_RowNum {get; set;}
        public string Country_CountryName { get; set; }
        public int? Country_NumberOfCall {get; set;}
        public decimal? Country_Percent {get; set;}

        //Call volume
        public int RowNum {get; set;}
        public string CallDateExport { get; set; }
        public string BookingNo { get; set; }
        public string HotelName { get; set; }
        public string CountryName { get; set; }
        public string Phone { get; set; }
        public string Contact { get; set; }
        public string Comment { get; set; }
        public string Caller { get; set; }

        public string HotelPlatformName { get; set; }
    }

    public enum CallLogExportColumns
    {
        //Call volume by Caller
        Caller_RowNum,
        Caller_Caller,
        Caller_NumberOfCall,
        Caller_PerCent,
        //Call volume by Hotel
        Hotel_RowNum,
        Hotel_HotelName,
        Hotel_CountryName,
        Hotel_NumberOfCall,
        Hotel_Percent,
        //Call volume by Country
        Country_RowNum,
        Country_CountryName,
        Country_NumberOfCall,
        Country_Percent,

        //Call volume
        RowNum,
        CallDateExport,
        BookingNo,
        HotelName,
        CountryName,
        Phone,
        Contact,
        Comment,
        Caller,
        HotelPlatformName
    }

    public class P_HotelOfCall
    {
        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }      

        private string hotelName;
        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }

        private string hotelNo;
        public string HotelNo
        {
            get { return hotelNo; }
            set { hotelNo = value; }
        }

        public List<P_HotelNumber> ListHotelNumber { get; set; }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string countryName;
        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        private string countryCode;
        public string CountryCode
        {
            get { return countryCode; }
            set { countryCode = value; }
        }

        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public DateTime LastCall { get; set;}

        private int numberOfCall;
        public int NumberOfCall
        {
            get { return numberOfCall; }
            set { numberOfCall = value; }
        }

        public long TotalRecords {get;set;}

        public P_HotelOfCall()
        {
            ListHotelNumber = new List<P_HotelNumber>();
        }
    }

}
