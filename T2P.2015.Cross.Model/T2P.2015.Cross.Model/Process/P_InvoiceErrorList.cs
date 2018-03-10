using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_ListTypeError
    {
        private string bookingNo;

        public string BookingNo
        {
            get { return bookingNo; }
            set { bookingNo = value; }
        }
        private int isParking;

        public int IsParking
        {
            get { return isParking; }
            set { isParking = value; }
        }
        private string imageStatus;

        public string ImageStatus
        {
            get { return imageStatus; }
            set { imageStatus = value; }
        }
    }
    public class P_InvoiceErrorList
    {
        private string _commentedBy;

        public string CommentedBy
        {
            get { return _commentedBy; }
            set { _commentedBy = value; }
        }

        private DateTime? _commentedDate;

        public DateTime? CommentedDate
        {
            get { return _commentedDate; }
            set { _commentedDate = value; }
        }

        private bool isTabInvoiceError;

        public bool IsTabInvoiceError
        {
            get { return isTabInvoiceError; }
            set { isTabInvoiceError = value; }
        }
        private bool isTabRejection;

        public bool IsTabRejection
        {
            get { return isTabRejection; }
            set { isTabRejection = value; }
        }
        private bool isTabWaitingFIN;

        public bool IsTabWaitingFIN
        {
            get { return isTabWaitingFIN; }
            set { isTabWaitingFIN = value; }
        }
        private bool isTabParking;

        public bool IsTabParking
        {
            get { return isTabParking; }
            set { isTabParking = value; }
        }
        private LockInvoice invoiceLock;

        public LockInvoice InvoiceLock
        {
            get { return invoiceLock; }
            set { invoiceLock = value; }
        }

       

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        private long totalRecord;

        public long TotalRecord
        {
            get { return totalRecord; }
            set { totalRecord = value; }
        }

        private long _b_AccessID;

        public long B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }

        private int isParking;

        public int IsParking
        {
            get { return isParking; }
            set { isParking = value; }
        }
        private long _invoiceID;

        public long InvoiceID
        {
            get { return _invoiceID; }
            set { _invoiceID = value; }
        }
        private string _invoiceNumber;

        private long _imageID;

        public long ImageID
        {
            get { return _imageID; }
            set { _imageID = value; }
        }
        private string _imageStatus;

        public string ImageStatus
        {
            get { return _imageStatus; }
            set { _imageStatus = value; }
        }
        private string _nextInvoiceStep;

        public string NextInvoiceStep
        {
            get { return _nextInvoiceStep; }
            set { _nextInvoiceStep = value; }
        }
        public string InvoiceNumber
        {
            get { return _invoiceNumber; }
            set { _invoiceNumber = value; }
        }
        private long _bookingID;

        public long BookingID
        {
            get { return _bookingID; }
            set { _bookingID = value; }
        }
        private string reservationNumber;

        public string ReservationNumber
        {
            get { return reservationNumber; }
            set { reservationNumber = value; }
        }

        
        private string _hotelName;

        public string HotelName
        {
            get { return _hotelName; }
            set { _hotelName = value; }
        }
        private string _companyName;

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        private DateTime? _checkInDate;

        public DateTime? CheckInDate
        {
            get { return _checkInDate; }
            set { _checkInDate = value; }
        }
        private DateTime? _checkOutDate;

        public DateTime? CheckOutDate
        {
            get { return _checkOutDate; }
            set { _checkOutDate = value; }
        }
        
        private string _iR1;

        public string IR1
        {
            get { return _iR1; }
            set { _iR1 = value; }
        }
        private string _iR2;

        public string IR2
        {
            get { return _iR2; }
            set { _iR2 = value; }
        }
        private string _iLC;

        public string ILC
        {
            get { return _iLC; }
            set { _iLC = value; }
        }
        private string _error_1;

        public string Error_1
        {
            get { return _error_1; }
            set { _error_1 = value; }
        }
        private string _error_2;

        public string Error_2
        {
            get { return _error_2; }
            set { _error_2 = value; }
        }
        private string _error_3;

        public string Error_3
        {
            get { return _error_3; }
            set { _error_3 = value; }
        }
        private int _stepStatus;

        public int StepStatus
        {
            get { return _stepStatus; }
            set { _stepStatus = value; }
        }

        private bool _isShowError14;

        public bool IsShowError14
        {
            get { return _isShowError14; }
            set { _isShowError14 = value; }
        }

        private int page;

        public int Page
        {
            get { return page; }
            set { page = value; }
        }

        private int pageSize;

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value; }
        }

        private string orderBy;

        public string OrderBy
        {
            get { return orderBy; }
            set { orderBy = value; }
        }

        private string orderDirection;

        public string OrderDirection
        {
            get { return orderDirection; }
            set { orderDirection = value; }
        }

        private bool _isLocked;

        public bool IsLocked
        {
            get { return _isLocked; }
            set { _isLocked = value; }
        }
        
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        
        private DateTime _updatedDate;

        public DateTime UpdatedDate
        {
            get { return _updatedDate; }
            set { _updatedDate = value; }
        }
        private long _updatedBy;

        public long UpdatedBy
        {
            get { return _updatedBy; }
            set { _updatedBy = value; }
        }

        private bool _isDuplicated;

        public bool IsDuplicated
        {
            get { return _isDuplicated; }
            set { _isDuplicated = value; }
        }

        private string _comment;

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        private string _hotelPlatformName;

        public string HotelPlatformName
        {
            get { return _hotelPlatformName; }
            set { _hotelPlatformName = value; }
        }


        
    }
    public class LockInvoice
    {
        private bool _isLocked;

        public bool IsLocked
        {
            get { return _isLocked; }
            set { _isLocked = value; }
        }
        private string _stepSattus;

        public string StepSattus
        {
            get { return _stepSattus; }
            set { _stepSattus = value; }
        }
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        private long _i_ImageID;

        public long I_ImageID
        {
            get { return _i_ImageID; }
            set { _i_ImageID = value; }
        }
        private DateTime _updatedDate;

        public DateTime UpdatedDate
        {
            get { return _updatedDate; }
            set { _updatedDate = value; }
        }
        private long _updatedBy;

        public long UpdatedBy
        {
            get { return _updatedBy; }
            set { _updatedBy = value; }
        }
    }
    public enum P_InvoiceErrorListProcedure
    {
        p_InvoiceCorrection_Get_ListSearch,
        p_InvoiceCorrection_Get_ListSearchWaitingForFIN,
        p_InvoiceCorrection_Get_ListSearchParking,
        p_InvoiceCorrection_CheckTypeError_ListSearch
    }
}
