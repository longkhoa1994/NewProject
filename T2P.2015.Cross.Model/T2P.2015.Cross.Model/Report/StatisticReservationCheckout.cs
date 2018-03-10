using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Report
{

    public class P_ReportStatisticReservationCheckout
    {
        public P_StatisticReservationCheckout Total { get; set; }
        public P_StatisticReservationCheckout Month { get; set; }
        public P_StatisticReservationCheckout Week { get; set; }
        public List<P_StatisticReservationCheckout_CodeStopped> ListCode { get; set; }

        public P_ReportStatisticReservationCheckout()
        {
            Total = new P_StatisticReservationCheckout();
            Month = new P_StatisticReservationCheckout();
            Week = new P_StatisticReservationCheckout();
            ListCode = new List<P_StatisticReservationCheckout_CodeStopped>();
        }

    }

    public class P_StatisticReservationCheckout
    {

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private long numberReservation;

        public long NumberReservation
        {
            get { return numberReservation; }
            set { numberReservation = value; }
        }

        private long numberCancel;

        public long NumberCancel
        {
            get { return numberCancel; }
            set { numberCancel = value; }
        }

        private decimal cancelPercent;

        public decimal CancelPercent
        {
            get { return cancelPercent; }
            set { cancelPercent = value; }
        }

        private long numberCheckout;

        public long NumberCheckout
        {
            get { return numberCheckout; }
            set { numberCheckout = value; }
        }

        private long numberStopped;

        public long NumberStopped
        {
            get { return numberStopped; }
            set { numberStopped = value; }
        }

        private decimal stoppedPercent;

        public decimal StoppedPercent
        {
            get { return stoppedPercent; }
            set { stoppedPercent = value; }
        }

        private long immediateInv;

        public long ImmediateInv
        {
            get { return immediateInv; }
            set { immediateInv = value; }
        }

        private decimal immediateInvPercent;

        public decimal ImmediateInvPercent
        {
            get { return immediateInvPercent; }
            set { immediateInvPercent = value; }
        }

        private long firstCollectionHasInv;

        public long FirstCollectionHasInv
        {
            get { return firstCollectionHasInv; }
            set { firstCollectionHasInv = value; }
        }

        private decimal firstCollectionHasInvPercent;

        public decimal FirstCollectionHasInvPercent
        {
            get { return firstCollectionHasInvPercent; }
            set { firstCollectionHasInvPercent = value; }
        }

        private long secondCollectionHasInv;

        public long SecondCollectionHasInv
        {
            get { return secondCollectionHasInv; }
            set { secondCollectionHasInv = value; }
        }

        private decimal secondCollectionHasInvPercent;

        public decimal SecondCollectionHasInvPercent
        {
            get { return secondCollectionHasInvPercent; }
            set { secondCollectionHasInvPercent = value; }
        }

        private long firstCollectionNoInv;

        public long FirstCollectionNoInv
        {
            get { return firstCollectionNoInv; }
            set { firstCollectionNoInv = value; }
        }

        private decimal firstCollectionNoInvPercent;

        public decimal FirstCollectionNoInvPercent
        {
            get { return firstCollectionNoInvPercent; }
            set { firstCollectionNoInvPercent = value; }
        }

        private long secondCollectionNoInv;

        public long SecondCollectionNoInv
        {
            get { return secondCollectionNoInv; }
            set { secondCollectionNoInv = value; }
        }

        private decimal secondCollectionNoInvPercent;

        public decimal SecondCollectionNoInvPercent
        {
            get { return secondCollectionNoInvPercent; }
            set { secondCollectionNoInvPercent = value; }
        }

        private long noCollectionNoInv;

        public long NoCollectionNoInv
        {
            get { return noCollectionNoInv; }
            set { noCollectionNoInv = value; }
        }

        private decimal noCollectionNoInvPercent;

        public decimal NoCollectionNoInvPercent
        {
            get { return noCollectionNoInvPercent; }
            set { noCollectionNoInvPercent = value; }
        }

        private long immediateCorrectInv;

        public long ImmediateCorrectInv
        {
            get { return immediateCorrectInv; }
            set { immediateCorrectInv = value; }
        }

        private decimal immediateCorrectInvPercent;

        public decimal ImmediateCorrectInvPercent
        {
            get { return immediateCorrectInvPercent; }
            set { immediateCorrectInvPercent = value; }
        }

        private long firstRejectionHasInv;

        public long FirstRejectionHasInv
        {
            get { return firstRejectionHasInv; }
            set { firstRejectionHasInv = value; }
        }

        private decimal firstRejectionHasInvPercent;

        public decimal FirstRejectionHasInvPercent
        {
            get { return firstRejectionHasInvPercent; }
            set { firstRejectionHasInvPercent = value; }
        }

        private long firstRejectionNoInv;

        public long FirstRejectionNoInv
        {
            get { return firstRejectionNoInv; }
            set { firstRejectionNoInv = value; }
        }

        private decimal firstRejectionNoInvPercent;

        public decimal FirstRejectionNoInvPercent
        {
            get { return firstRejectionNoInvPercent; }
            set { firstRejectionNoInvPercent = value; }
        }

        private long secondRejectionHasInv;

        public long SecondRejectionHasInv
        {
            get { return secondRejectionHasInv; }
            set { secondRejectionHasInv = value; }
        }

        private decimal secondRejectionHasInvPercent;

        public decimal SecondRejectionHasInvPercent
        {
            get { return secondRejectionHasInvPercent; }
            set { secondRejectionHasInvPercent = value; }
        }

        private long secondRejectionNoInv;

        public long SecondRejectionNoInv
        {
            get { return secondRejectionNoInv; }
            set { secondRejectionNoInv = value; }
        }



        private decimal secondRejectionNoInvPercent;

        public decimal SecondRejectionNoInvPercent
        {
            get { return secondRejectionNoInvPercent; }
            set { secondRejectionNoInvPercent = value; }
        }


        private long numberCostAcceptance;

        public long NumberCostAcceptance
        {
            get { return numberCostAcceptance; }
            set { numberCostAcceptance = value; }
        }

        private long numberFailCostAcceptance;

        public long NumberFailCostAcceptance
        {
            get { return numberFailCostAcceptance; }
            set { numberFailCostAcceptance = value; }
        }

        private decimal failCostAcceptancePercent;

        public decimal FailCostAcceptancePercent
        {
            get { return failCostAcceptancePercent; }
            set { failCostAcceptancePercent = value; }
        }

        private string account;

        public string Account
        {
            get { return account; }
            set { account = value; }
        }

        private long numberFIN;

        public long NumberFIN
        {
            get { return numberFIN; }
            set { numberFIN = value; }
        }

        private long numberProcessingFIN;

        public long NumberProcessingFIN
        {
            get { return numberProcessingFIN; }
            set { numberProcessingFIN = value; }
        }

        private long numberEnrichedFIN;

        public long NumberEnrichedFIN
        {
            get { return numberEnrichedFIN; }
            set { numberEnrichedFIN = value; }
        }

        private long numberSpecialCaseFIN;

        public long NumberSpecialCaseFIN
        {
            get { return numberSpecialCaseFIN; }
            set { numberSpecialCaseFIN = value; }
        }

        public List<P_StatisticReservationCheckout_Stopped> ListStoppedBooking { get; set; }


        public P_StatisticReservationCheckout()
        {
            ListStoppedBooking = new List<P_StatisticReservationCheckout_Stopped>();
          
        }
    }


    public class P_StatisticReservationCheckout_BookingDetail
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

        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        private string stopCode;

        public string StopCode
        {
            get { return stopCode; }
            set { stopCode = value; }
        }

        private long totalRecords;

        public long TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }
    }


    public class P_StatisticReservationCheckout_CostAccesptanceDetail
    {
        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private DateTime sendDate;

        public DateTime SendDate
        {
            get { return sendDate; }
            set { sendDate = value; }
        }


        private string from;

        public string From
        {
            get { return from; }
            set { from = value; }
        }


        private string to;

        public string To
        {
            get { return to; }
            set { to = value; }
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

        private string listTraveler;

        public string ListTraveler
        {
            get { return listTraveler; }
            set { listTraveler = value; }
        }

        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private long totalRecords;

        public long TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

    }



    public class P_StatisticReservationCheckout_FINDetail
    {
        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string documentNo;

        public string DocumentNo
        {
            get { return documentNo; }
            set { documentNo = value; }
        }

        private DateTime salesDate;

        public DateTime SalesDate
        {
            get { return salesDate; }
            set { salesDate = value; }
        }


        private decimal amount;

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private string currencyCode;

        public string CurrencyCode
        {
            get { return currencyCode; }
            set { currencyCode = value; }
        }

        private string errorCode;

        public string ErrorCode
        {
            get { return errorCode; }
            set { errorCode = value; }
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



    public class P_StatisticReservationCheckout_Stopped
    {
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        private long quantity;

        public long Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }

    public class P_StatisticReservationCheckout_CodeStopped 
    {

        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        private long quantityTotal;

        public long QuantityTotal
        {
            get { return quantityTotal; }
            set { quantityTotal = value; }
        }

        private long quantityMonth;

        public long QuantityMonth
        {
            get { return quantityMonth; }
            set { quantityMonth = value; }
        }

        private long quantityWeek;

        public long QuantityWeek
        {
            get { return quantityWeek; }
            set { quantityWeek = value; }
        }
    }


    public enum StatisticReservationCheckoutProcedure
    {
        p_Report_Statistic_Reservation_Checkout,
        p_Report_Statistic_Reservation_Checkout_GetListBooking,
        p_Report_Statistic_Reservation_Checkout_GetListFIN,
        p_Report_Statistic_Reservation_Checkout_GetListCostAcceptance,
        p_Report_Statistic_Reservation_Checkout_GetListStopped,
    }
}
