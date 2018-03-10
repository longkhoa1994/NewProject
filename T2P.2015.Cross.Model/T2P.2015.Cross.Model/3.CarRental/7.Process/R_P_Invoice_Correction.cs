using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    public class R_P_Invoice_CorrectionList
    {
        private long _invoiceID;

        public long InvoiceID
        {
            get { return _invoiceID; }
            set { _invoiceID = value; }
        }

        private string _invoiceNo;

        public string InvoiceNo
        {
            get { return _invoiceNo; }
            set { _invoiceNo = value; }
        }

        private long _imageID;

        public long ImageID
        {
            get { return _imageID; }
            set { _imageID = value; }
        }

        private long _b_AccessID;

        public long B_AccessID
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

        private string _carProviderName;

        public string CarProviderName
        {
            get { return _carProviderName; }
            set { _carProviderName = value; }
        }

        private string _companyName;

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }


        private DateTime _receivedDate;

        public DateTime ReceivedDate
        {
            get { return _receivedDate; }
            set { _receivedDate = value; }
        }

        private DateTime? _pickUpTime;

        public DateTime? PickUpTime
        {
            get { return _pickUpTime; }
            set { _pickUpTime = value; }
        }


        private DateTime? _returnTime;

        public DateTime? ReturnTime
        {
            get { return _returnTime; }
            set { _returnTime = value; }
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

        private string _comment;

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        private string _userNameLock;

        public string UserNameLock
        {
            get { return _userNameLock; }
            set { _userNameLock = value; }
        }

        private int _totalRecords;

        public int TotalRecords
        {
            get { return _totalRecords; }
            set { _totalRecords = value; }
        }

    }

    public class R_P_Invoice_Correction : R_I_Data
    {
        private long _r_RG_RateGridID;

        public long R_RG_RateGridID
        {
            get { return _r_RG_RateGridID; }
            set { _r_RG_RateGridID = value; }
        }

        private long? _r_I_ImageIdOld;

        public long? R_I_ImageIdOld
        {
            get { return _r_I_ImageIdOld; }
            set { _r_I_ImageIdOld = value; }
        }

        private long replaceID;

        public long ReplaceID
        {
            get { return replaceID; }
            set { replaceID = value; }
        }


        private DateTime _pickupDate;

        public DateTime PickupDate
        {
            get { return _pickupDate; }
            set { _pickupDate = value; }
        }

        private DateTime _returnDate;

        public DateTime ReturnDate
        {
            get { return _returnDate; }
            set { _returnDate = value; }
        }

        private DateTime _bookedDate;

        public DateTime BookedDate
        {
            get { return _bookedDate; }
            set { _bookedDate = value; }
        }

        private string _pickupCountryCode;

        public string PickupCountryCode
        {
            get { return _pickupCountryCode; }
            set { _pickupCountryCode = value; }
        }

        private string _returnCountryCode;

        public string ReturnCountryCode
        {
            get { return _returnCountryCode; }
            set { _returnCountryCode = value; }
        }


        private long _b_AccessID;

        public long B_AccessID
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

        private string _companyName;

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        private string _companyAddress;

        public string CompanyAddress
        {
            get { return _companyAddress; }
            set { _companyAddress = value; }
        }

        private string _companyZipCode;

        public string CompanyZipCode
        {
            get { return _companyZipCode; }
            set { _companyZipCode = value; }
        }

        private string _companyCityName;

        public string CompanyCityName
        {
            get { return _companyCityName; }
            set { _companyCityName = value; }
        }

        private string _companyCountryName;

        public string CompanyCountryName
        {
            get { return _companyCountryName; }
            set { _companyCountryName = value; }
        }

        private string _companyCountryCode;

        public string CompanyCountryCode
        {
            get { return _companyCountryCode; }
            set { _companyCountryCode = value; }
        }

        private string _logoProviderURL;

        public string LogoProviderURL
        {
            get { return _logoProviderURL; }
            set { _logoProviderURL = value; }
        }

        private long _m_CompanyID;

        public long M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }

        private string _pickupHour;

        public string PickupHour
        {
            get { return _pickupHour; }
            set { _pickupHour = value; }
        }

        private string _pickupMinute;

        public string PickupMinute
        {
            get { return _pickupMinute; }
            set { _pickupMinute = value; }
        }

        private string _returnHour;

        public string ReturnHour
        {
            get { return _returnHour; }
            set { _returnHour = value; }
        }

        private string _returnMinute;

        public string ReturnMinute
        {
            get { return _returnMinute; }
            set { _returnMinute = value; }
        }

        private string _carProviderName;

        public string CarProviderName
        {
            get { return _carProviderName; }
            set { _carProviderName = value; }
        }

        private long _carProviderID;

        public long CarProviderID
        {
            get { return _carProviderID; }
            set { _carProviderID = value; }
        }

        private string _fullPath;

        public string FullPath
        {
            get { return _fullPath; }
            set { _fullPath = value; }
        }

        private string _descriptionSippCode;

        public string DescriptionSippCode
        {
            get { return _descriptionSippCode; }
            set { _descriptionSippCode = value; }
        }

        private string _descriptionCarGroup;

        public string DescriptionCarGroup
        {
            get { return _descriptionCarGroup; }
            set { _descriptionCarGroup = value; }
        }

        private string _sippCode;

        public string SippCode
        {
            get { return _sippCode; }
            set { _sippCode = value; }
        }


        private string _carGroup;

        public string CarGroup
        {
            get { return _carGroup; }
            set { _carGroup = value; }
        }

        public string Type { get; set; }

        private string action;

        public string Action
        {
            get { return action; }
            set { action = value; }
        }

        private string commentDebit;
        public string CommentDebit
        {
            get { return commentDebit; }
            set { commentDebit = value; }
        }

        private bool _hasRateGrid;
        public bool HasRateGrid
        {
            get { return _hasRateGrid; }
            set { _hasRateGrid = value; }
        }

        private bool _hasClaim;
        public bool HasClaim
        {
            get { return _hasClaim; }
            set { _hasClaim = value; }
        }

        private bool _hasICR;
        public bool HasICR
        {
            get { return _hasICR; }
            set { _hasICR = value; }
        }

        private string _currencyRateGrid;
        public string CurrencyRateGrid
        {
            get { return _currencyRateGrid; }
            set { _currencyRateGrid = value; }
        }

        private bool _isChangeCurrency;
        public bool IsChangeCurrency
        {
            get { return _isChangeCurrency; }
            set { _isChangeCurrency = value; }
        }

        private bool _isCheckCarGroup;
        public bool IsCheckCarGroup
        {
            get { return _isCheckCarGroup; }
            set { _isCheckCarGroup = value; }
        }

        private string _carCategory;
        public string CarCategory
        {
            get { return _carCategory; }
            set { _carCategory = value; }
        }

        private string _carProcess;

        public string CarProcess
        {
            get { return _carProcess; }
            set { _carProcess = value; }
        }

        private long _spendTimeReturnCar;

        public long SpendTimeReturnCar
        {
            get { return _spendTimeReturnCar; }
            set { _spendTimeReturnCar = value; }
        }

        private bool _hasSippOrGroup;

        public bool HasSippOrGroup
        {
            get { return _hasSippOrGroup; }
            set { _hasSippOrGroup = value; }
        }

        private bool _isWaittingForApproval;

        public bool IsWaittingForApproval
        {
            get { return _isWaittingForApproval; }
            set { _isWaittingForApproval = value; }
        }

        private bool _hasApproval;

        public bool HasApproval
        {
            get { return _hasApproval; }
            set { _hasApproval = value; }
        }
        public bool HasErrorIIA { get; set; }

        private string _companyProcess;

        public string CompanyProcess
        {
            get { return _companyProcess; }
            set { _companyProcess = value; }
        }
        public long BufferTime { get; set; }
        public decimal GrossAmountOriginal { get; set; }
        public decimal TotalNet { get; set; }
        public decimal TotalTax { get; set; }
        public decimal TotalGross { get; set; }
        public R_P_Validation Validation { get; set; }

        public R_F_Transaction FinFake { get; set; }

        public List<R_P_Invoice_Correction_Service> ListService { get; set; }

        public List<R_I_Tax> ListTax { get; set; }

        public List<R_I_Error> ListInvoiceError { get; set; }

        public List<R_F_Transaction> ListFin { get; set; }

        public List<R_RG_RateGridVAT> ListVAT { get; set; }

        public List<R_I_Error> PrevInvoiceErrorsList { get; set; }

        public List<P_Image_Data> ListInvoiceOriginal { get; set; }

        public List<P_MapService> ListMapService { get; set; }

        public List<R_M_InvoiceErrorCode> ListErrorCode { get; set; }

        public List<R_M_Surcharge> ListSurcharge { get; set; }

        public List<R_P_CarGroupSippCode> ListCarGroupSippCode { get; set; }

        public List<R_RG_RateGridDetail> ListRateGrid { get; set; }

        public string PickupStation { get; set; }
        //public string RateGrid { get; set; }

        public R_P_Invoice_Correction()
        {
            SpendTimeReturnCar = 0;
            ListService = new List<R_P_Invoice_Correction_Service>();
            ListTax = new List<R_I_Tax>();
            ListInvoiceError = new List<R_I_Error>();
            ListFin = new List<R_F_Transaction>();
            PrevInvoiceErrorsList = new List<R_I_Error>();
            ListInvoiceOriginal = new List<P_Image_Data>();
            ListVAT = new List<R_RG_RateGridVAT>();
            ListMapService = new List<P_MapService>();
            ListErrorCode = new List<R_M_InvoiceErrorCode>();
            ListSurcharge = new List<R_M_Surcharge>();
            ListCarGroupSippCode = new List<R_P_CarGroupSippCode>();
        }
    }

    public class R_P_Invoice_Correction_Service : R_I_Service
    {
        private long correctServiceID;

        public long CorrectServiceID
        {
            get { return correctServiceID; }
            set { correctServiceID = value; }
        }

        private string correctInvoiceNumber;

        public string CorrectInvoiceNumber
        {
            get { return correctInvoiceNumber; }
            set { correctInvoiceNumber = value; }
        }
        private long correctInvoiceID;

        public long CorrectInvoiceID
        {
            get { return correctInvoiceID; }
            set { correctInvoiceID = value; }
        }

        private long correctImageID;

        public long CorrectImageID
        {
            get { return correctImageID; }
            set { correctImageID = value; }
        }

        private string imageStatus;

        public string ImageStatus
        {
            get { return imageStatus; }
            set { imageStatus = value; }
        }

        private bool changeByTraveler;

        public bool ChangeByTraveler
        {
            get { return changeByTraveler; }
            set { changeByTraveler = value; }
        }

        private bool isManualError;

        public bool IsManualError
        {
            get { return isManualError; }
            set { isManualError = value; }
        }

        public string ErrorText { get; set; }

    }

    public class P_Image_Data
    {
        public long ID { get; set; }
        public string InvoiceNumber { get; set; }
        public string ImageStatus { get; set; }
        public long R_I_DataID { get; set; }
        public bool IsSpecialCase { get; set; }
        public string FullPath { get; set; }
        public List<R_I_Error> ListError { get; set; }
    }

    public class P_MapService
    {
        public long DebitID { get; set; }
        public long CreditID { get; set; }
    }

    public enum R_P_InvoiceCorrectionProcedure
    {
        p_R_InvoiceCorrection_Get_ListSearch,
        p_R_I_GetForCorrection
    }


    public class InvoiceErrorViewModel
    {
        public List<R_I_Error> PrevInvoiceErrorsList;

        public List<R_I_Error> InvoiceErrorsList;

        public InvoiceErrorViewModel()
        {
            PrevInvoiceErrorsList = new List<R_I_Error>();
            InvoiceErrorsList = new List<R_I_Error>();
        }
    }


}
