using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model._5.Meetago.Process;
using T2P._2015.Cross.Model.History;
using T2P._2015.Cross.Model.View;
using T2P._2015.Model;

namespace T2P._2015.Cross.Model
{
    public class P_InvoiceCorrectionDetail
    {
        public bool IsDuplicatedInvoiceNumber { get; set; }
        public B_Booking DuplicatedBookingNo { get; set; }
        public bool IsSameUser { get; set; }


        public bool IsLock { get; set; }
        public long UserID { get; set; }
        public int StepStatus { get; set; }
        public string TypeCorrect { get; set; }
        public I_Image ReplaceImage { get; set; }
        public bool IsDisableWaitingFIN { get; set; }
        public string Action { get; set; }

        public bool IsShowSaveButton { get; set; }
        public bool IsHasNoTax { get; set; }
        public string ErrorType { get; set; }

        public bool IsSuccessful { get; set; }
        public bool IsStillHasVTI { get; set; }

        public string Message { get; set; }
        public int NotAllowedServiceCode { get; set; }
        public int NotAllowedNOS { get; set; }
        public bool IsCopiedError { get; set; }

        public bool IsTaskServiceDesk { get; set; }
        public string AllowedServiceCode { get; set; }

        public decimal ExchangeRate { get; set; }

        public P_I_Data_Correction InvoiceData { get; set; }

        public List<P_I_ImageCorrection> ListImage { get; set; }
        public List<P_M_InvoiceErrorCode_Correction> ListInvoiceError { get; set; }

        public List<string> ListVTIErrorShowInClient { get; set; }

        public List<F_Transaction_Correction> ListTransaction_Correction { get; set; }
        public List<F_Transaction_Correction> ListTransaction_SkipCorrection { get; set; }

        public List<P_TotalFINAmount> ListSumFINAmount { get; set; }

        public List<P_I_Position_Correction> ListI_Position { get; set; }

        public List<P_I_Tax_Correction> ListI_Tax { get; set; }
        public bool IsReplace { get; set; }

        public bool IsUseOldData { get; set; }
        public bool IsVerifyInvoiceCompanySetup { get; set; }

        public bool IsSendRejeciton { get; set; }
        public bool IsCorrect14 { get; set; }
        public bool IsShowCopy { get; set; }
        public bool IsShowCompanyError { get; set; }
        public bool IsShowHotelError { get; set; }
        public bool IsShowCustomerVATError { get; set; }
        public bool IsInfoInvoice { get; set; }
        public bool IsHasVATError { get; set; }
        public bool IsErrorVATNumberCorrected { get; set; }
        public bool isSave { get; set; }

        public bool IsShowParking { get; set; }

        public bool IsSkipFinAtBeginning { get; set; }

        public bool IsModifiedData { get; set; }

        public bool isMatchFinAtBeginning { get; set; }

        public bool isDeposit { get; set; }

        public bool IsProcessMatchOrSkipFIN { get; set; }
        
        private P_InvoiceCorrect_Result _result;

        public P_InvoiceCorrect_Result Result
        {
            get { return _result; }
            set { _result = value; }
        }

        private List<N_Rejection> _listRejection;

        public List<N_Rejection> ListRejection
        {
            get { return _listRejection; }
            set { _listRejection = value; }
        }

        private List<M_ServiceCode> _listServiceCode;

        public List<M_ServiceCode> ListServiceCode
        {
            get { return _listServiceCode; }
            set { _listServiceCode = value; }
        }

        private List<M_ServiceCodeTax> _listServiceCodeTax;

        public List<M_ServiceCodeTax> ListServiceCodeTax
        {
            get { return _listServiceCodeTax; }
            set { _listServiceCodeTax = value; }
        }

        private List<M_Currency> _listCurrency;

        public List<M_Currency> ListCurrency
        {
            get { return _listCurrency; }
            set { _listCurrency = value; }
        }

        private P_M_InvoiceErrorCode_Correction _copy_ErrorCode;

        public P_M_InvoiceErrorCode_Correction Copy_ErrorCode
        {
            get { return _copy_ErrorCode; }
            set { _copy_ErrorCode = value; }
        }

        private P_M_InvoiceErrorCode_Correction _company_ErrorCode;

        public P_M_InvoiceErrorCode_Correction Company_ErrorCode
        {
            get { return _company_ErrorCode; }
            set { _company_ErrorCode = value; }
        }

        private P_M_InvoiceErrorCode_Correction _hotel_ErrorCode;

        public P_M_InvoiceErrorCode_Correction Hotel_ErrorCode
        {
            get { return _hotel_ErrorCode; }
            set { _hotel_ErrorCode = value; }
        }

        private P_M_InvoiceErrorCode_Correction _customerVAT_ErrorCode;

        public P_M_InvoiceErrorCode_Correction CustomerVAT_ErrorCode
        {
            get { return _customerVAT_ErrorCode; }
            set { _customerVAT_ErrorCode = value; }
        }

        private P_M_InvoiceErrorCode_Correction _infoInvoice_ErrorCode;
        public P_M_InvoiceErrorCode_Correction InfoInvoice_ErrorCode
        {
            get { return _infoInvoice_ErrorCode; }
            set { _infoInvoice_ErrorCode = value; }
        }

        private long finID;

        public long FinID
        {
            get { return finID; }
            set { finID = value; }
        }

        private bool _isHasTypingError;

        public bool IsHasTypingError
        {
            get { return _isHasTypingError; }
            set { _isHasTypingError = value; }
        }

        private I_TypingError _typingError;

        public I_TypingError TypingError
        {
            get { return _typingError; }
            set { _typingError = value; }
        }

        private List<M_Code> _listMistakeCategory;

        public List<M_Code> ListMistakeCategory
        {
            get { return _listMistakeCategory; }
            set { _listMistakeCategory = value; }
        }

        private bool _skipTaxRate;

        public bool SkipTaxRate
        {
            get { return _skipTaxRate; }
            set { _skipTaxRate = value; }
        }

        private bool _skipWrongInvoiceAmount;

        public bool SkipWrongInvoiceAmount
        {
            get { return _skipWrongInvoiceAmount; }
            set { _skipWrongInvoiceAmount = value; }
        }

        private float? _bookingAmountOfWrongInvoiceAmount;

        public float? BookingAmountOfWrongInvoiceAmount
        {
            get { return _bookingAmountOfWrongInvoiceAmount; }
            set { _bookingAmountOfWrongInvoiceAmount = value; }
        }

        private string _bookingCurrencyCode;

        public string BookingCurrencyCode
        {
            get { return _bookingCurrencyCode; }
            set { _bookingCurrencyCode = value; }
        }

        private decimal? _bookingExchangeRate;

        public decimal? BookingExchangeRate
        {
            get { return _bookingExchangeRate; }
            set { _bookingExchangeRate = value; }
        }

        private bool _isEnriched;

        public bool IsEnriched
        {
            get { return _isEnriched; }
            set { _isEnriched = value; }
        }

        private List<B_Traveler> _listB_Traveler;

        public List<B_Traveler> ListB_Traveler
        {
            get { return _listB_Traveler; }
            set { _listB_Traveler = value; }
        }

        public List<P_ContractMapping> ListDataContract { get; set; }

        public List<P_I_PositionMatching> ListPositionMatching { get; set; }
        public List<M_CountryTaxGerMan> ListTaxRateCountry { get; set; }

        public bool IsMeeting
        { get; set; }

        public bool IsSendApprovalLetter
        {
            get;
            set;
        }

        public bool IsWaittingForApproval
        {
            get;
            set;
        }

        public bool HasApproval
        {
            get;
            set;
        }

        public bool IsSkipSNI
        {
            get;
            set;
        }

        public bool IsManualSkipFIN
        {
            get;
            set;
        }

        public bool IsSelfPayment
        {
            get;
            set;
        }

        public bool SkipCheckCurrency
        {
            get;
            set;
        }

        public P_InvoiceCorrectionDetail()
        {
            ListInvoiceError = new List<P_M_InvoiceErrorCode_Correction>();
            ListTransaction_Correction = new List<F_Transaction_Correction>();
            Result = new P_InvoiceCorrect_Result();
            ListServiceCodeTax = new List<M_ServiceCodeTax>();
            ListSumFINAmount = new List<P_TotalFINAmount>();
            InvoiceData = new P_I_Data_Correction();
            ListI_Tax = new List<P_I_Tax_Correction>();
            ListI_Position = new List<P_I_Position_Correction>();
            TypingError = new I_TypingError();
            SkipTaxRate = false;
            SkipWrongInvoiceAmount = false;
            ListDataContract = new List<P_ContractMapping>();
            ListTaxRateCountry = new List<M_CountryTaxGerMan>();
            IsManualSkipFIN = false;
            IsSelfPayment = false;
            SkipCheckCurrency = false;
            ListTransaction_SkipCorrection = new List<F_Transaction_Correction>();
            ListVTIErrorShowInClient = new List<string>();
            isDeposit = false;
        }


    }

    public class P_TotalFINAmount
    {
        private decimal _totalAmount;

        public decimal TotalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; }
        }
        private string _currency;

        public string Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }
    }
    public enum P_InvoiceCorrectionDetailStoreProcedure
    {
        p_M_InvoiceErrorCode_GetByDataID,
        p_InvoiceCorrection_GetData_ByDataID,
        p_InvoiceCorrection_GetData_ByDataID_New,
        p_F_Transaction_GetBy_I_DataID,
        p_F_Transaction_GetBy_I_DataID_ForCorrection,
        p_ErrorText_GetByDataID,
        p_I_Image_GetList_ForCorrection,
        p_InvoiceCorrection_GetData_ByImageID,
        p_M_InvoiceErrorCode_GetByDataIDForCorrection,
        p_M_InvoiceErrorCodeTranslation_GetByID,
        p_InvoiceCorrection_GetNextInvoice,
        p_InvoiceCorrection_Get_LockInvoice_ByUser,
        p_M_InvoiceErrorCode_GetBy_B_AccessID_ForCorrection,
        p_InvoiceCorrection_GetData_ByDataID_AutoService,
        p_I_Image_GetList_ForFaxNumber_Hotel_Input,
        p_I_Image_CheckDeposit
    }

    public class P_I_ImageCorrection
    {
        public long I_ImageID { get; set; }
        public long AttachmentPageID { get; set; }
        public string IISPath { get; set; }
        public string FilePath { get; set; }
        public string ImageFileName { get; set; }
        public string PDFFileName { get; set; }
        public string ImageStatus { get; set; }
        public decimal? Rotate { get; set; }
    }
    public class P_I_ImageCorrectionExtend : P_I_ImageCorrection
    {
        public string InvoiceNoSC { get; set; }
    }

    public class P_I_Data_Correction : I_Data
    {
        //public long I_ImageID { get; set; }

        public long M_ProcessID { get; set; }
        public string IISPath { get; set; }
        public string FilePath { get; set; }
        //public string ImageFileName { get; set; }
        public string ImageStatus { get; set; }
        public bool IsCopied { get; set; }
        public long B_AccessID { get; set; }
        public long B_BookingID { get; set; }

        public string PaymentMethod { get; set; }
        public string BookingNo { get; set; }
        public string HotelPlatformName { get; set; }
        public string HotelPlatformType { get; set; }
        public string CommonProcessName { get; set; }

        // Company Data
        public long M_CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyZipCode { get; set; }
        public string CompanyCityName { get; set; }
        public string CompanyCountryName { get; set; }
        public string CompanyCountryCode { get; set; }
        public string CompanyFlag { get; set; }
        //
        public long M_HotelID { get; set; }
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }
        public string HotelCountryCode { get; set; }
        public string HotelZipCode { get; set; }
        public string HotelCityName { get; set; }
        public string HotelCountryName { get; set; }
		public string HotelSpecialty { get; set; }
        public long M_HotelPlatformID { get; set; }
        public string HotelFlag { get; set; }
        public string VATCode { get; set; }
        public string HotelVAT_MasterData { get; set; }

        public string Comment { get; set; }
        public string CommentParking { get; set; }
        //        
        public string AnswerContent { get; set; }
        
        public long InvoiceReplace { get; set; }

        public long IsSelfCreated { get; set; }

        public bool IsLockOtherInvoice { get; set; }

        public bool IsSameInvoice { get; set; }

        public bool IsBookingCancelValid { get; set; }

		public bool IsExportedVTI { get; set; }

        public string TravelerNames { get; set; }

        public long HotelCountryID { get; set; }

        public long HotelLanguageID { get; set; }

        public string AllowedServiceCode { get; set; }

        public bool IsReplace { get; set; }

        public bool IsSkipFinAtBeginning { get; set; }

        public long B_EventID { get; set; }

        public string EventNo { get; set; }

        public long B_ContractID { get; set; }

        public string ContractFilePath { get; set; }

        public string Booker { get; set; }
    }

    public class P_I_Position_Correction : I_Position
    {
        private bool _isAutoCalculate;       
        public bool IsAutoCalculate
        {
            get { return _isAutoCalculate; }
            set { _isAutoCalculate = value; }
        }

        private bool _isUpdatedServiceCode;

        public bool IsUpdatedServiceCode
        {
            get { return _isUpdatedServiceCode; }
            set { _isUpdatedServiceCode = value; }
        }

        public P_I_Position_Correction()
        {
            IsAutoCalculate = true;
            IsUpdatedServiceCode = false;
        }

        public long ReferID
        {
            get;
            set;
        }

        public int ServiceType
        {
            get;
            set;
        }

        public int RowSpanContract
        {
            get;
            set;
        }

        public P_ContractMapping ContractMapping
        {
            get;
            set;
        }

        public bool OtherInvoice
        {
            get;
            set;
        }

        public bool IsMappingManual { get; set; }
    }

    public class P_I_Tax_Correction : I_Tax
    {
        private bool _isAutoCalculate;

        public bool IsAutoCalculate
        {
            get { return _isAutoCalculate; }
            set { _isAutoCalculate = value; }
        }

        public P_I_Tax_Correction()
        {
            IsAutoCalculate = true;
        }
    }

    public class P_M_InvoiceErrorCode_Correction : M_InvoiceErrorCode
    {

        public bool IsErrorNew { get; set; }
        public long P_InvoiceErrorCodeID { get; set; }

        public long I_PositionID { get; set; }

        public bool IsCorrected { get; set; }

        public bool OtherInvoice { get; set; }

        public string Comment { get; set; }

        public bool IsDisable { get; set; }


    }

    public class F_Transaction_Correction : F_Transaction
    {
        public long P_ValidationID { get; set; }

        public int ValidationResult { get; set; }

        public long I_DataID { get; set; }

        public bool IsMatched { get; set; }

        public bool IsSkipped { get; set; }

        public bool IsDSC { get; set; }

        public bool IsShowExchangeInfo { get; set; }
        public decimal? CalculatedExchange { get; set; }
    }

    public class P_InvoiceDataSet_Hitory
    {

        private P_InvoiceDataSet _oldInvoiceDataSet;

        public P_InvoiceDataSet OldInvoiceDataSet
        {
            get { return _oldInvoiceDataSet; }
            set { _oldInvoiceDataSet = value; }
        }

        private P_InvoiceDataSet _invoiceDataSet;

        public P_InvoiceDataSet InvoiceDataSet
        {
            get { return _invoiceDataSet; }
            set { _invoiceDataSet = value; }
        }

        private P_HistoryInvoiceDataSet _historyDataSet;

        public P_HistoryInvoiceDataSet HistoryDataSet
        {
            get { return _historyDataSet; }
            set { _historyDataSet = value; }
        }

        private List<B_Comment> _listBookingComment;

        public List<B_Comment> ListBookingComment
        {
            get { return _listBookingComment; }
            set { _listBookingComment = value; }
        }

        public P_InvoiceDataSet_Hitory()
        {
            OldInvoiceDataSet = new P_InvoiceDataSet();
            InvoiceDataSet = new P_InvoiceDataSet();
            HistoryDataSet = new P_HistoryInvoiceDataSet();
            ListBookingComment = new List<B_Comment>();
        }
    }

    public class P_InvoiceDataSet
    {
        private I_Data _invoiceData;

        public I_Data InvoiceData
        {
            get { return _invoiceData; }
            set { _invoiceData = value; }
        }

        private List<I_Position> _listPosition;

        public List<I_Position> ListPosition
        {
            get { return _listPosition; }
            set { _listPosition = value; }
        }

        private List<I_Tax> _listTax;

        public List<I_Tax> ListTax
        {
            get { return _listTax; }
            set { _listTax = value; }
        }

        private List<P_InvoiceError> _listError;

        public List<P_InvoiceError> ListError
        {
            get { return _listError; }
            set { _listError = value; }
        }

        private List<P_Validation> _listValidation;

        public List<P_Validation> ListValidation
        {
            get { return _listValidation; }
            set { _listValidation = value; }
        }

        private List<P_I_PositionMatching> _listPositionMatching;

        public List<P_I_PositionMatching> ListPositionMatching
        {
            get { return _listPositionMatching; }
            set { _listPositionMatching = value; }
        }

    }

    public class P_HistoryInvoiceDataSet
    {
        private H_I_Data _invoiceData;

        public H_I_Data InvoiceData
        {
            get { return _invoiceData; }
            set { _invoiceData = value; }
        }

        private List<H_I_Position> _listPosition;

        public List<H_I_Position> ListPosition
        {
            get { return _listPosition; }
            set { _listPosition = value; }
        }

        private List<H_I_Tax> _listTax;

        public List<H_I_Tax> ListTax
        {
            get { return _listTax; }
            set { _listTax = value; }
        }

        private List<H_P_InvoiceError> _listError;

        public List<H_P_InvoiceError> ListError
        {
            get { return _listError; }
            set { _listError = value; }
        }

        private List<H_P_Validation> _listValidation;

        public List<H_P_Validation> ListValidation
        {
            get { return _listValidation; }
            set { _listValidation = value; }
        }

        private List<P_I_PositionMatching> _listPositionMatching;

        public List<P_I_PositionMatching> ListPositionMatching
        {
            get { return _listPositionMatching; }
            set { _listPositionMatching = value; }
        }
    }

    public class P_InvoiceCorrect_Result
    {
        private bool _isErrorTyping;

        public bool IsErrorTyping
        {
            get { return _isErrorTyping; }
            set { _isErrorTyping = value; }
        }

        private bool _isInvalidData;

        public bool IsInvalidData
        {
            get { return _isInvalidData; }
            set { _isInvalidData = value; }
        }

        private bool _isMatchFin;

        public bool IsMatchFin
        {
            get { return _isMatchFin; }
            set { _isMatchFin = value; }
        }

    }

    public class P_Invoice_Data_DSC
    {
        private decimal exchangeRate;

        public decimal ExchangeRate
        {
            get { return exchangeRate; }
            set { exchangeRate = value; }
        }
        private I_Data data;

        public I_Data Data
        {
            get { return data; }
            set { data = value; }
        }
        private List<I_Position> listPosition;

        public List<I_Position> ListPosition
        {
            get { return listPosition; }
            set { listPosition = value; }
        }

        private List<I_Tax> listTax;

        public List<I_Tax> ListTax
        {
            get { return listTax; }
            set { listTax = value; }
        }

        public P_Invoice_Data_DSC()
        {
            listPosition = new List<I_Position>();
            listTax = new List<I_Tax>();
        }
    }

    public class P_Invoice_CommonData
    {
        public List<M_InvoiceErrorCode> ListErrorCode
        {
            get;
            set;
        }
        public P_Invoice_CommonData()
        {
            ListErrorCode = new List<M_InvoiceErrorCode>();
        }
    }

    public class P_Invoice_Contract
    {
        public List<B_Room> ListRoom
        {
            get;
            set;
        }

        public List<B_Package> ListPackage
        {
            get;
            set;
        }

        public P_Invoice_Contract()
        {
            ListRoom = new List<B_Room>();
            ListPackage = new List<B_Package>();
        }
    }

    public class P_Validation_Amount_Booking_Invoice
    {
        public long B_AccessID { get; set; }
        public float TotalInvoiceAmount { get; set; }
        public float TotalBookingAmount { get; set; }
        public string BookingCurrencyCode { get; set; }
    }


    public enum TypeCorrection
    {
        InvoiceError,
        WaitingForFIN,
        Rejection,
        Parking,
        InvalidData,
        IncorrectFin,
    }
}
