using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_VTIZIB : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _f_VTITransactionID;

        public long F_VTITransactionID
        {
            get { return _f_VTITransactionID; }
            set { _f_VTITransactionID = value; }
        }

        private decimal _groupnumber;

        public decimal Groupnumber
        {
            get { return _groupnumber; }
            set { _groupnumber = value; }
        }

        private string _documentNumber;

        public string DocumentNumber
        {
            get { return _documentNumber; }
            set { _documentNumber = value; }
        }

        private string _transactionType;

        public string TransactionType
        {
            get { return _transactionType; }
            set { _transactionType = value; }
        }

        private string _serviceOrigInd;

        
        public string ServiceOrigInd
        {
            get { return _serviceOrigInd; }
            set { _serviceOrigInd = value; }
        }

        private string _hotelName;

        public string HotelName
        {
            get { return _hotelName; }
            set { _hotelName = value; }
        }

        private string _hotelStreet;

        public string HotelStreet
        {
            get { return _hotelStreet; }
            set { _hotelStreet = value; }
        }

        private string _hotel;

        public string Hotel
        {
            get { return _hotel; }
            set { _hotel = value; }
        }

        private string _hotelCity;

        public string HotelCity
        {
            get { return _hotelCity; }
            set { _hotelCity = value; }
        }

        private string _hotelCountryCode;

        public string HotelCountryCode
        {
            get { return _hotelCountryCode; }
            set { _hotelCountryCode = value; }
        }

        private string _vATNumberHotel;

        public string VATNumberHotel
        {
            get { return _vATNumberHotel; }
            set { _vATNumberHotel = value; }
        }

        private string _hotelChain;

        public string HotelChain
        {
            get { return _hotelChain; }
            set { _hotelChain = value; }
        }

        private string _guestName;

        public string GuestName
        {
            get { return _guestName; }
            set { _guestName = value; }
        }

        private string _companyName;

        
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        private string _invoiceNumber;

        
        public string InvoiceNumber
        {
            get { return _invoiceNumber; }
            set { _invoiceNumber = value; }
        }

        private DateTime _checkinDate;

        
        public DateTime CheckinDate
        {
            get { return _checkinDate; }
            set { _checkinDate = value; }
        }

        private DateTime _checkoutDate;

        
        public DateTime CheckoutDate
        {
            get { return _checkoutDate; }
            set { _checkoutDate = value; }
        }

        private int _roomNights;

        public int RoomNights
        {
            get { return _roomNights; }
            set { _roomNights = value; }
        }

        private decimal? _roomAmount;

        
        public decimal? RoomAmount
        {
            get { return _roomAmount; }
            set { _roomAmount = value; }
        }

        private string _bookingCode;

        public string BookingCode
        {
            get { return _bookingCode; }
            set { _bookingCode = value; }
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

        private DateTime? _dBI_BD;

        
        public DateTime? DBI_BD
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

        private DateTime? _eventStart;

        
        public DateTime? EventStart
        {
            get { return _eventStart; }
            set { _eventStart = value; }
        }

        private DateTime? _eventEnd;

        
        public DateTime? EventEnd
        {
            get { return _eventEnd; }
            set { _eventEnd = value; }
        }

        private string _eventName;

        
        public string EventName
        {
            get { return _eventName; }
            set { _eventName = value; }
        }

        private string _eventLocation;

        
        public string EventLocation
        {
            get { return _eventLocation; }
            set { _eventLocation = value; }
        }

        private string _eventZipCode;

        
        public string EventZipCode
        {
            get { return _eventZipCode; }
            set { _eventZipCode = value; }
        }

        private decimal? _participantCount;

        
        public decimal? ParticipantCount
        {
            get { return _participantCount; }
            set { _participantCount = value; }
        }

        private string _cRSBookingCode;

        
        public string CRSBookingCode
        {
            get { return _cRSBookingCode; }
            set { _cRSBookingCode = value; }
        }

        private string _bookingChannel;

        
        public string BookingChannel
        {
            get { return _bookingChannel; }
            set { _bookingChannel = value; }
        }

        private string _orderNumber;

        
        public string OrderNumber
        {
            get { return _orderNumber; }
            set { _orderNumber = value; }
        }

        private string _customerNo;

        
        public string CustomerNo
        {
            get { return _customerNo; }
            set { _customerNo = value; }
        }

        private decimal _tXNMwStBetrag;

        public decimal TXNMwStBetrag
        {
            get { return _tXNMwStBetrag; }
            set { _tXNMwStBetrag = value; }
        }

        private decimal _tXNNettoBetrag;

        public decimal TXNNettoBetrag
        {
            get { return _tXNNettoBetrag; }
            set { _tXNNettoBetrag = value; }
        }

        private string _comment;

        
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        public override string Table { get { return "F_VTIZIB"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_F_VTIZIB_InsertOrUpdate"; } }
    }

    public enum F_VTIZIBColumns
    {
        ID,
        F_VTITransactionID,
        Groupnumber,
        DocumentNumber,
        TransactionType,
        ServiceOrigInd,
        HotelName,
        HotelStreet,
        Hotel,
        HotelCity,
        HotelCountryCode,
        VATNumberHotel,
        HotelChain,
        GuestName,
        CompanyName,
        InvoiceNumber,
        CheckinDate,
        CheckoutDate,
        RoomNights,
        RoomAmount,
        BookingCode,
        DBI_PK,
        DBI_KS,
        DBI_DS,
        DBI_AE,
        DBI_IK,
        DBI_BD,
        DBI_PR,
        DBI_AU,
        DBI_AK,
        DBI_RZ,
        EventStart,
        EventEnd,
        EventName,
        EventLocation,
        EventZipCode,
        ParticipantCount,
        CRSBookingCode,
        BookingChannel,
        OrderNumber,
        CustomerNo,
        TXNMwStBetrag,
        TXNNettoBetrag,
        Comment,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum F_VTIZIBProcedure
    {
        p_F_VTIZIB_Create,
        p_F_VTIZIB_GetListForDeleting,
    }

    public class F_VTIZIBList : List<F_VTIZIB>
    {
    }
}