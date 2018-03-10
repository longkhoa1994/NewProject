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

        private bool isTabFinalCheck;
        public bool IsTabFinalCheck
        {
            get { return isTabFinalCheck; }
            set { isTabFinalCheck = value; }
        }

        private bool isTabApproval;
        public bool IsTabApproval
        {
            get { return isTabApproval; }
            set { isTabApproval = value; }
        }

        private bool isTabSupervisor;

        public bool IsTabSupervisor
        {
            get { return isTabSupervisor; }
            set { isTabSupervisor = value; }
        }

        private bool isTabQACorrection;

        public bool IsTabQACorrection
        {
            get { return isTabQACorrection; }
            set { isTabQACorrection = value; }
        }

        private bool isTabLastSuccessfulInvoice;

         public bool IsTabLastSuccessfulInvoice
        {
            get { return isTabLastSuccessfulInvoice; }
            set { isTabLastSuccessfulInvoice = value; }
        }        

        private string _request;
        public string Request
        {
            get { return _request; }
            set { _request = value; }
        }


        private string _reply;
        public string Reply
        {
            get { return _reply; }
            set { _reply = value; }
        }



        private string _answer;
        public string Answer
        {
            get { return _answer; }
            set { _answer = value; }
        }

        private DateTime _requestDate;
        public DateTime RequestDate
        {
            get { return _requestDate; }
            set { _requestDate = value; }
        }

        private DateTime _replyDate;
        public DateTime ReplyDate
        {
            get { return _replyDate; }
            set { _replyDate = value; }
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

        private string _question;
        public string Question
        {
            get { return _question; }
            set { _question = value; }
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
        private string _invoiceNumber;
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

        private long _companyID;

        public long CompanyID
        {
            get { return _companyID; }
            set { _companyID = value; }
        }

        private long _i_DataID;

        public long I_DataID
        {
            get { return _i_DataID; }
            set { _i_DataID = value; }
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

        private string _error_6;

        public string Error_6
        {
            get { return _error_6; }
            set { _error_6 = value; }
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

        private DateTime? _processedDate;

        public DateTime? ProcessedDate
        {
            get { return _processedDate; }
            set { _processedDate = value; }
        }

        private string _processedBy;

        public string ProcessedBy
        {
            get { return _processedBy; }
            set { _processedBy = value; }
        }

        private string _eventNo;

        public string EventNo
        {
            get { return _eventNo; }
            set { _eventNo = value; }
        }

        private long _b_EventID;

        public long B_EventID
        {
            get { return _b_EventID; }
            set { _b_EventID = value; }
        }

        private long? countLetter;
        public long? CountLetter
        {
            get { return countLetter; }
            set { countLetter = value; }
        }

        
    }

    public class ListSupervisor
    {
        public List<P_InvoiceErrorList> ListInvoiceErrorSupervisor { get; set; }
        public long TotalRecord { get; set; }
        public ListSupervisor()
        {
            ListInvoiceErrorSupervisor = new List<P_InvoiceErrorList>();
            TotalRecord = 0;
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

    public class ExtendLockInvoice : LockInvoice
    {
        public long UserLockID { get; set; }
        public string FullName { get; set; }
        public bool isLockUserOther { get; set; }
        public bool IsAutoServiceKeep { get; set; }
        public bool IsSuccessfulInvoice { get; set; }
        public bool InvoiceDel { get; set; }
    }
    public enum P_InvoiceErrorListProcedure
    {
        p_InvoiceCorrection_Get_ListSearch,
        p_InvoiceCorrection_Get_ListSearchWaitingForFIN,
        p_InvoiceCorrection_Get_ListSearchParking,
        p_InvoiceCorrection_CheckTypeError_ListSearch,

        //List Invoice Correction 2
        p_InvoiceCorrection_Get_List_Error,
        p_InvoiceCorrection_Get_List_Error_Count,
        p_InvoiceCorrection_Get_List_Parking,
        p_InvoiceCorrection_Get_List_Parking_Count,
        p_InvoiceCorrection_Get_List_Rejection,
        p_InvoiceCorrection_Get_List_Rejection_Count,
        p_InvoiceCorrection_Get_List_Waiting,
        p_InvoiceCorrection_Get_List_Waiting_Count,

        p_InvoiceCorrection_Get_List_FinalCheck,
        p_InvoiceCorrection_Get_List_FinalCheck_Count,

        p_InvoiceCorrection_Get_List_Approval,
        p_InvoiceCorrection_Get_List_Approval_Count,

        p_InvoiceCorrection_Get_List_Error_Supervisor,
        p_InvoiceCorrection_Get_List_Error_Supervisor_Count,

        p_InvoiceCorrection_Get_List_LastError,
        p_InvoiceCorrection_Get_List_LastError_Count,
        p_InvoiceCorrection_Get_List_LastError_ReadyForNextStep,
        p_InvoiceCorrection_Check_Keep_AutoService,        

                   
        p_InvoiceCorrection_Get_List_FINError
    }
}
