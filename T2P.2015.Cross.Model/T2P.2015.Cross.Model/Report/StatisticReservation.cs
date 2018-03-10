using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Report
{
    public class P_StatisticReservation
    {
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private int position;

        public int Position
        {
            get { return position; }
            set { position = value; }
        }
        private int numberOfBooking;

        public int NumberOfBooking
        {
            get { return numberOfBooking; }
            set { numberOfBooking = value; }
        }

        private decimal numberOfBookingPercent;

        public decimal NumberOfBookingPercent
        {
            get { return numberOfBookingPercent; }
            set { numberOfBookingPercent = value; }
        }

        private int stoppedBooking;

        public int StoppedBooking
        {
            get { return stoppedBooking; }
            set { stoppedBooking = value; }
        }
        private decimal stoppedPercent;

        public decimal StoppedPercent
        {
            get { return stoppedPercent; }
            set { stoppedPercent = value; }
        }
        private int withInvoice;

        public int WithInvoice
        {
            get { return withInvoice; }
            set { withInvoice = value; }
        }
        private decimal withInvoicePercent;

        public decimal WithInvoicePercent
        {
            get { return withInvoicePercent; }
            set { withInvoicePercent = value; }
        }
        private int withoutInvoice;

        public int WithoutInvoice
        {
            get { return withoutInvoice; }
            set { withoutInvoice = value; }
        }
        private decimal withoutInvoicePercent;

        public decimal WithoutInvoicePercent
        {
            get { return withoutInvoicePercent; }
            set { withoutInvoicePercent = value; }
        }
        private int numberOfCall;

        public int NumberOfCall
        {
            get { return numberOfCall; }
            set { numberOfCall = value; }
        }
        private decimal numberOfCallPerCent;

        public decimal NumberOfCallPercent
        {
            get { return numberOfCallPerCent; }
            set { numberOfCallPerCent = value; }
        }



        private int receivedINVWithRemind;

        public int ReceivedINVWithRemind
        {
            get { return receivedINVWithRemind; }
            set { receivedINVWithRemind = value; }
        }

        private decimal receivedINVWithRemindPercent;

        public decimal ReceivedINVWithRemindPercent
        {
            get { return receivedINVWithRemindPercent; }
            set { receivedINVWithRemindPercent = value; }
        }

        private decimal receivedINVWithRemindPercentAll;

        public decimal ReceivedINVWithRemindPercentAll
        {
            get { return receivedINVWithRemindPercentAll; }
            set { receivedINVWithRemindPercentAll = value; }
        }

        private int receivedINVWithoutRemind;

        public int ReceivedINVWithoutRemind
        {
            get { return receivedINVWithoutRemind; }
            set { receivedINVWithoutRemind = value; }
        }

        private decimal receivedINVWithoutRemindPercent;

        public decimal ReceivedINVWithoutRemindPercent
        {
            get { return receivedINVWithoutRemindPercent; }
            set { receivedINVWithoutRemindPercent = value; }
        }


        private decimal receivedINVWithoutRemindPercentAll;

        public decimal ReceivedINVWithoutRemindPercentAll
        {
            get { return receivedINVWithoutRemindPercentAll; }
            set { receivedINVWithoutRemindPercentAll = value; }
        }

        private int receivedINVWithCollection1;

        public int ReceivedINVWithCollection1
        {
            get { return receivedINVWithCollection1; }
            set { receivedINVWithCollection1 = value; }
        }

        private decimal receivedINVWithCollection1Percent;

        public decimal ReceivedINVWithCollection1Percent
        {
            get { return receivedINVWithCollection1Percent; }
            set { receivedINVWithCollection1Percent = value; }
        }


        private decimal receivedINVWithCollection1PercentAll;

        public decimal ReceivedINVWithCollection1PercentAll
        {
            get { return receivedINVWithCollection1PercentAll; }
            set { receivedINVWithCollection1PercentAll = value; }
        }

        private int receivedINVWithCollection2;

        public int ReceivedINVWithCollection2
        {
            get { return receivedINVWithCollection2; }
            set { receivedINVWithCollection2 = value; }
        }

        private decimal receivedINVWithCollection2Percent;

        public decimal ReceivedINVWithCollection2Percent
        {
            get { return receivedINVWithCollection2Percent; }
            set { receivedINVWithCollection2Percent = value; }
        }

        private decimal receivedINVWithCollection2PercentAll;

        public decimal ReceivedINVWithCollection2PercentAll
        {
            get { return receivedINVWithCollection2PercentAll; }
            set { receivedINVWithCollection2PercentAll = value; }
        }

        private string aliasProcess;

        public string AliasProcess
        {
            get { return aliasProcess; }
            set { aliasProcess = value; }
        }

        private long hotelPlatformID;

        public long HotelPlatformID
        {
            get { return hotelPlatformID; }
            set { hotelPlatformID = value; }
        }
    }


    public class P_StatisticReservationDetail
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
        private string bookingStatus;

        public string BookingStatus
        {
            get { return bookingStatus; }
            set { bookingStatus = value; }
        }
        private long m_CompanyID;

        public long CompanyID
        {
            get { return m_CompanyID; }
            set { m_CompanyID = value; }
        }
        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        private long m_HotelPlatformID;

        public long M_HotelPlatformID
        {
            get { return m_HotelPlatformID; }
            set { m_HotelPlatformID = value; }
        }

        private string hotelPlatformName;

        public string HotelPlatformName
        {
            get { return hotelPlatformName; }
            set { hotelPlatformName = value; }
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

        private long totalRecords;

        public long TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

    }


    public class P_StatisticReservationDetailCall
    {
        private string hotelPlatformName;

        public string HotelPlatformName
        {
            get { return hotelPlatformName; }
            set { hotelPlatformName = value; }
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
        private string contact;

        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string caller;

        public string Caller
        {
            get { return caller; }
            set { caller = value; }
        }
        private int numberOfBookings;

        public int NumberOfBookings
        {
            get { return numberOfBookings; }
            set { numberOfBookings = value; }
        }

        private bool isShowListBooking;

        public bool IsShowListBooking
        {
            get { return isShowListBooking; }
            set { isShowListBooking = value; }
        }

        


        private long totalRecords;

        public long TotalRecords 
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }


        public List<P_BookingOfCall> ListBooking { get; set; }

        public P_StatisticReservationDetailCall()
        {
            IsShowListBooking = false;
            ListBooking = new List<P_BookingOfCall>();
        }
    }

    public enum StatisticReservationStoreProcedure
    {
        p_Report_Reservation_Statistic,
        p_Report_Reservation_Statistic_GetListBooking,
        p_Report_Reservation_Statistic_GetListPhoneCall,
    }
}
