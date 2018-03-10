using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_History : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _b_BookingID;

        public long B_BookingID
        {
            get { return _b_BookingID; }
            set { _b_BookingID = value; }
        }

        private string _bookingNo;

        public string BookingNo
        {
            get { return _bookingNo; }
            set { _bookingNo = value; }
        }

        private string _followingBookingNo;

        
        public string FollowingBookingNo
        {
            get { return _followingBookingNo; }
            set { _followingBookingNo = value; }
        }

        private string _paymentMethod;

        public string PaymentMethod
        {
            get { return _paymentMethod; }
            set { _paymentMethod = value; }
        }

        private DateTime? _bookingDate;

        
        public DateTime? BookingDate
        {
            get { return _bookingDate; }
            set { _bookingDate = value; }
        }

        private DateTime? _cancellationDate;

        
        public DateTime? CancellationDate
        {
            get { return _cancellationDate; }
            set { _cancellationDate = value; }
        }

        private DateTime _checkInDate;

        public DateTime CheckInDate
        {
            get { return _checkInDate; }
            set { _checkInDate = value; }
        }

        private DateTime _checkOutDate;

        public DateTime CheckOutDate
        {
            get { return _checkOutDate; }
            set { _checkOutDate = value; }
        }

        private int _numberOfSingleRooms;

        public int NumberOfSingleRooms
        {
            get { return _numberOfSingleRooms; }
            set { _numberOfSingleRooms = value; }
        }

        private int _numberOfDoubleRooms;

        public int NumberOfDoubleRooms
        {
            get { return _numberOfDoubleRooms; }
            set { _numberOfDoubleRooms = value; }
        }

        private string _guaranteeType;

        public string GuaranteeType
        {
            get { return _guaranteeType; }
            set { _guaranteeType = value; }
        }

        private decimal _taxAmount;

        public decimal TaxAmount
        {
            get { return _taxAmount; }
            set { _taxAmount = value; }
        }

        private decimal _cancellationFee;

        public decimal CancellationFee
        {
            get { return _cancellationFee; }
            set { _cancellationFee = value; }
        }

        private string _currencyCode;

        public string CurrencyCode
        {
            get { return _currencyCode; }
            set { _currencyCode = value; }
        }

        private DateTime? _cancellationDeadline;

        
        public DateTime? CancellationDeadline
        {
            get { return _cancellationDeadline; }
            set { _cancellationDeadline = value; }
        }

        private decimal? _bookingDeposit;

        
        public decimal? BookingDeposit
        {
            get { return _bookingDeposit; }
            set { _bookingDeposit = value; }
        }

        private bool? _bookingDepositRequired;

        
        public bool? BookingDepositRequired
        {
            get { return _bookingDepositRequired; }
            set { _bookingDepositRequired = value; }
        }

        public override string Table { get { return "B_History"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_B_History_InsertOrUpdate"; } }
    }

    public enum B_HistoryColumns
    {
        ID,
        B_BookingID,
        BookingNo,
        FollowingBookingNo,
        PaymentMethod,
        BookingDate,
        CancellationDate,
        CheckInDate,
        CheckOutDate,
        NumberOfSingleRooms,
        NumberOfDoubleRooms,
        GuaranteeType,
        TaxAmount,
        CancellationFee,
        CurrencyCode,
        CancellationDeadline,
        BookingDeposit,
        BookingDepositRequired,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_HistoryProcedure
    {
        p_B_History_Get_By_B_BookingID,
        p_B_History_GetListForDeleting,
    }

    public class B_HistoryList : List<B_History>
    {
    }
}