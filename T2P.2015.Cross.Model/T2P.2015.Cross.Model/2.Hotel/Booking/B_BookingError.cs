using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_BookingError : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _b_HeaderID;
        public long? B_HeaderID
        {
            get { return _b_HeaderID; }
            set { _b_HeaderID = value; }
        }
        private string _bookingNo;
        public string BookingNo
        {
            get { return _bookingNo; }
            set { _bookingNo = value; }
        }
        private string _companyName;
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        private long? _m_HotelplatformID;
        public long? M_HotelplatformID
        {
            get { return _m_HotelplatformID; }
            set { _m_HotelplatformID = value; }
        }
        private string _travelerName;
        public string TravelerName
        {
            get { return _travelerName; }
            set { _travelerName = value; }
        }
        private string _checkIn;
        public string CheckIn
        {
            get { return _checkIn; }
            set { _checkIn = value; }
        }
        private string _checkOut;
        public string CheckOut
        {
            get { return _checkOut; }
            set { _checkOut = value; }
        }
        private string _errorMessage;
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; }
        }
        private string _hotelName;
        public string HotelName
        {
            get { return _hotelName; }
            set { _hotelName = value; }
        }
        public override string Table { get { return "B_BookingError"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_B_BookingError_InsertOrUpdate"; } }
    }
    public enum B_BookingErrorColumns
    {
        ID,
        B_HeaderID,
        BookingNo,
        CompanyName,
        M_HotelplatformID,
        TravelerName,
        CheckIn,
        CheckOut,
        ErrorMessage,
        HotelName,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum B_BookingErrorProcedure
    {

    }
    public class B_BookingErrorList : List<B_BookingError>
    {

    }
}