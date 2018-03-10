using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_Image : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _b_AccessID;
        public long? B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }
        private long _m_FileLocationID;
        public long M_FileLocationID
        {
            get { return _m_FileLocationID; }
            set { _m_FileLocationID = value; }
        }
        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }
        private string _pDFFilename;
        public string PDFFilename
        {
            get { return _pDFFilename; }
            set { _pDFFilename = value; }
        }
        private bool? _isCopied;
        public bool? IsCopied
        {
            get { return _isCopied; }
            set { _isCopied = value; }
        }
        private string _comment;
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        private string _commentSC;
        public string CommentSC
        {
            get { return _commentSC; }
            set { _commentSC = value; }
        }

        private long _duplicatedID;
        public long DuplicatedID
        {
            get { return _duplicatedID; }
            set { _duplicatedID = value; }
        }
        
        private string _imageStatus;
        public string ImageStatus
        {
            get { return _imageStatus; }
            set { _imageStatus = value; }
        }
        private string _checkingStatus;
        public string CheckingStatus
        {
            get { return _checkingStatus; }
            set { _checkingStatus = value; }
        }
        private string _bookingNoSC;
        public string BookingNoSC
        {
            get { return _bookingNoSC; }
            set { _bookingNoSC = value; }
        }

        private bool isSuggested;

        public bool IsSuggested
        {
            get { return isSuggested; }
            set { isSuggested = value; }
        }

        public override string Table { get { return "I_Image"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_Image_InsertOrUpdate"; } }
    }
    public enum I_ImageColumns
    {
        ID,
        B_AccessID,
        M_FileLocationID,
        FilePath,
        PDFFilename,
        IsCopied,
        Comment,
        CommentSC,
        DuplicatedID,
        ImageStatus,
        CheckingStatus,
        BookingNoSC,
        IsSuggested,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public class I_Image_ForPreProcessing : I_Image
    {
        private List<I_PageToImage> _listPageToImage;

        public List<I_PageToImage> ListPageToImage
        {
            get { return _listPageToImage; }
            set { _listPageToImage = value; }
        }
    }

    public class I_Image_Extend : I_Image
    {
        public string StepCode { get; set; }
        public int StepStatus { get; set; }
        public string IISPath { get; set; }
        public string LocalPath { get; set; }
        public List<P_InvoiceError> ListErrorCode { get; set; }
        public I_Image_Extend()
        {
            StepCode = string.Empty;
            StepStatus = 0;
            IISPath = string.Empty;
            LocalPath = string.Empty;
            ListErrorCode = new List<P_InvoiceError>();
        }
    }

    public class I_Image_ForUnmatchable : I_Image
    {
        public long M_HotelPlatformID { get; set; }
        public long N_BillingEmailID { get; set; }
        public string Subject { get; set; }
        public string From { get; set; }
        public DateTime ReceivingDate { get; set; }
        public int StepStatus { get; set; }
        public string UserName { get; set; }
        public bool IsExistBookingNo { get; set; }

        public I_Image_ForUnmatchable()
        {
            M_HotelPlatformID = 0;
            N_BillingEmailID = 0;
            Subject = string.Empty;
            From = string.Empty;
            StepStatus = -2;
            UserName = string.Empty;
            IsExistBookingNo = false;
        }

    }


    public enum I_ImageProcedure
    {
        p_I_Image_Get_ByBooking,
        p_I_Image_GetListForward,
        p_I_Image_GetByFileName,
        p_P_Matching_GetImage,      
        p_I_Image_Get_ByID_ForNotification,
        p_I_Image_GetByN_BillingEmailID,
        p_I_Image_GetRelationBy_I_ImageID,
        p_P_Matching_GetListUnmatchable,           
        p_I_Image_Get_ByBooking_WithPath,
        p_I_ImageID_GetListByN_BillingEmailID,
        p_I_Image_GetImageandDataByImageID,
        p_P_Unlock_InvoiceProcess,
        p_P_Lock_Get_ByUserID,
        p_P_Matching_GetNumber,
        p_P_Matching_AddmoreHotelContact,
        p_I_Image_Get_ByID_WithPath,
        p_I_Image_GetListSentTraveler,
        p_I_Image_GetRelationByID,
        p_I_Image_GetListTestTravelerEmail,
        p_I_Image_GetListForDeleting,
        p_I_Image_CIG_NonTIM,
        p_I_Image_CIG_TIM,
        p_I_Image_Get_By_N_BillingEmailID_ForOCR,
        p_I_Image_CheckSuggestHotelTemplate,
        p_P_Matching_GetImage_Duplicated,
        p_P_Matching_GetNumber_Duplicated, 
        p_I_Image_GetList_ByListI_DataID,
        p_I_ImageID_GetListBy_ListN_BillingEmailID,
    }
    public class I_ImageList : List<I_Image>
    {

    }
    public class P_ImageReplaceCorrection 
    {
        private I_Image image;

        public I_Image Image
        {
            get { return image; }
            set { image = value; }
        }

        private string _iISPath;

        public string IISPath
        {
            get { return _iISPath; }
            set { _iISPath = value; }
        }

    }

    public class P_Image_Path : I_Image
    {
        private int _isSpecialCase;

        public int IsSpecialCase
        {
            get { return _isSpecialCase; }
            set { _isSpecialCase = value; }
        }

        private string _iP;

        public string IP
        {
            get { return _iP; }
            set { _iP = value; }
        }

        private string _iISPath;

        public string IISPath
        {
            get { return _iISPath; }
            set { _iISPath = value; }
        }

        private List<P_InvoiceError_Image> _listErrorCode;

        public List<P_InvoiceError_Image> ListErrorCode
        {
            get { return _listErrorCode; }
            set { _listErrorCode = value; }
        }

        private List<P_Image_Path> _listCombinedInvoice;

        public List<P_Image_Path> ListCombinedInvoice
        {
            get { return _listCombinedInvoice; }
            set { _listCombinedInvoice = value; }
        }

        private List<P_Image_Path> _listSplitedInvoice;

        public List<P_Image_Path> ListSplitedInvoice
        {
            get { return _listSplitedInvoice; }
            set { _listSplitedInvoice = value; }
        }

        private string newID;

        public string NewID
        {
            get { return newID; }
            set { newID = value; }
        }

        private string _invoiceNo;

        public string InvoiceNo
        {
            get { return _invoiceNo; }
            set { _invoiceNo = value; }
        }

        private string _groupCombined;

        public string GroupCombined
        {
            get { return _groupCombined; }
            set { _groupCombined = value; }
        }

        private bool _isDeposit;

        public bool IsDeposit
        {
            get { return _isDeposit; }
            set { _isDeposit = value; }
        }
    }

    public class P_InvoiceError_Image : M_InvoiceErrorCode
    {
        private long _i_ImageID;

        public long I_ImageID
        {
            get { return _i_ImageID; }
            set { _i_ImageID = value; }
        }
    };

    public class P_Image_Pdf 
    {
        public long I_ImageID { get; set; }
        public List<N_AttachmentPage_CreatePDF> ListPage { get; set; }
    }
}
