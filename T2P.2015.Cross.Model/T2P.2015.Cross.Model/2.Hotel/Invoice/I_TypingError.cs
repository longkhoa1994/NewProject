using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_TypingError : BaseModel
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

        private long? _i_DataID;
        public long? I_DataID
        {
            get { return _i_DataID; }
            set { _i_DataID = value; }
        }

        private long? _m_CodeID;

        public long? M_CodeID
        {
            get { return _m_CodeID; }
            set { _m_CodeID = value; }
        }
        
        private string _comment;
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        private long? _detectedBy;
        public long? DetectedBy
        {
            get { return _detectedBy; }
            set { _detectedBy = value; }
        }
        private DateTime _detectedDate;
        public DateTime DetectedDate
        {
            get { return _detectedDate; }
            set { _detectedDate = value; }
        }
        private string _feedback;
        public string Feedback
        {
            get { return _feedback; }
            set { _feedback = value; }
        }
        private string _errorStatus;
        public string ErrorStatus
        {
            get { return _errorStatus; }
            set { _errorStatus = value; }
        }
        public override string Table { get { return "I_TypingError"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_TypingError_InsertOrUpdate"; } }

        private string _category;
        [NotInsert]
        [NotUpdate]
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
    }
    public enum I_TypingErrorColumns
    {
        ID,
        I_ImageID,
        I_DataID,
        Category,
        Comment,
        DetectedBy,
        DetectedDate,
        Feedback,
        ErrorStatus,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
        M_CodeId
    }
    public enum I_TypingErrorProcedure
    {
        p_I_TypingError_GetByI_DataID,
        p_I_TypingError_Get_Search,
    }
    public class I_TypingErrorList : List<I_TypingError>
    {

    }
    public class P_TypingError : I_TypingError
    {
        private string _bookingNo;
        public string BookingNo
        {
            get { return _bookingNo; }
            set { _bookingNo = value; }
        }

        private string _invoiceNo;
        public string InvoiceNo
        {
            get { return _invoiceNo; }
            set { _invoiceNo = value; }
        }

        private string _companyName;
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        private string _hotelName;
        public string HotelName
        {
            get { return _hotelName; }
            set { _hotelName = value; }
        }

        private string _hotelPlatformName;
        public string HotelPlatformName
        {
            get { return _hotelPlatformName; }
            set { _hotelPlatformName = value; }
        }

        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        private long _totalRecords;

        public long TotalRecords
        {
            get { return _totalRecords; }
            set { _totalRecords = value; }
        }

        private long _b_AccessID;

        public long B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }

        private string _imageStatus;

        public string ImageStatus
        {
            get { return _imageStatus; }
            set { _imageStatus = value; }
        }

        private int _currentTab;
        public int CurrentTab
        {
            get { return _currentTab; }
            set { _currentTab = value; }
        }

     
    }
}