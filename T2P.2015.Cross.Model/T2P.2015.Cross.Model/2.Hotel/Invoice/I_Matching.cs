using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_Matching : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _i_ImageID;
        public long? I_ImageID
        {
            get { return _i_ImageID; }
            set { _i_ImageID = value; }
        }
        private long? _m_HotelPlatformID;
        public long? M_HotelPlatformID
        {
            get { return _m_HotelPlatformID; }
            set { _m_HotelPlatformID = value; }
        }
        private string _hotelPlatformName;
        public string HotelPlatformName
        {
            get { return _hotelPlatformName; }
            set { _hotelPlatformName = value; }
        }
        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        private long? _n_BillingEmailID;
        public long? N_BillingEmailID
        {
            get { return _n_BillingEmailID; }
            set { _n_BillingEmailID = value; }
        }
        private string _emailSubject;
        public string EmailSubject
        {
            get { return _emailSubject; }
            set { _emailSubject = value; }
        }
        private string _fromAddress;
        public string FromAddress
        {
            get { return _fromAddress; }
            set { _fromAddress = value; }
        }
        private string _toAddress;
        public string ToAddress
        {
            get { return _toAddress; }
            set { _toAddress = value; }
        }
        private DateTime? _receivedDate;
        public DateTime? ReceivedDate
        {
            get { return _receivedDate; }
            set { _receivedDate = value; }
        }
        private long? _b_AccessID;
        public long? B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }
        private string _bookingNo;
        public string BookingNo
        {
            get { return _bookingNo; }
            set { _bookingNo = value; }
        }
        private long? _m_HotelID;
        public long? M_HotelID
        {
            get { return _m_HotelID; }
            set { _m_HotelID = value; }
        }
        private string _hotelName;
        public string HotelName
        {
            get { return _hotelName; }
            set { _hotelName = value; }
        }
        private long? _m_CompanyID;
        public long? M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }
        private string _companyName;
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        private long? _m_TravelerID;
        public long? M_TravelerID
        {
            get { return _m_TravelerID; }
            set { _m_TravelerID = value; }
        }
        private string _travelerName;
        public string TravelerName
        {
            get { return _travelerName; }
            set { _travelerName = value; }
        }
        private DateTime? _checkinFrom;
        public DateTime? CheckinFrom
        {
            get { return _checkinFrom; }
            set { _checkinFrom = value; }
        }
        private DateTime? _checkinTo;
        public DateTime? CheckinTo
        {
            get { return _checkinTo; }
            set { _checkinTo = value; }
        }
        private DateTime? _checkoutFrom;
        public DateTime? CheckoutFrom
        {
            get { return _checkoutFrom; }
            set { _checkoutFrom = value; }
        }
        private DateTime? _checkoutTo;
        public DateTime? CheckoutTo
        {
            get { return _checkoutTo; }
            set { _checkoutTo = value; }
        }
        private string _comment;
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        private string _imagePages;
        public string ImagePages
        {
            get { return _imagePages; }
            set { _imagePages = value; }
        }
        private bool? _isGateway;
        public bool? IsGateway
        {
            get { return _isGateway; }
            set { _isGateway = value; }
        }
        private int? _priority;
        public int? Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }

        private string _faxNumber;

        public string FaxNumber
        {
            get { return _faxNumber; }
            set { _faxNumber = value; }
        }

        public override string Table { get { return "I_Matching"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_Matching_InsertOrUpdate"; } }
    }
    public enum I_MatchingColumns
    {
        ID,
        I_ImageID,
        M_HotelPlatformID,
        HotelPlatformName,
        Type,
        N_BillingEmailID,
        EmailSubject,
        FromAddress,
        ToAddress,
        ReceivedDate,
        B_AccessID,
        BookingNo,
        M_HotelID,
        HotelName,
        M_CompanyID,
        CompanyName,
        M_TravelerID,
        TravelerName,
        CheckinFrom,
        CheckinTo,
        CheckoutFrom,
        CheckoutTo,
        Comment,
        ImagePages,
        IsGateway,
        Priority,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum I_MatchingProcedure
    {
        p_I_Matching_Get_By_I_ImageID,
        p_I_Matching_Check_Exsit_I_ImageID
    }
    public class I_MatchingList : List<I_Matching>
    {

    }
}