using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using T2P._2015.Model;
namespace T2P._2015.Cross.Model
{

    [Serializable]
    public class F_Transaction : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _f_HeaderID;
        public long F_HeaderID
        {
            get { return _f_HeaderID; }
            set { _f_HeaderID = value; }
        }
        private long? _b_AccessID;
        public long? B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }
        private long? _financialID;
        public long? FinancialID
        {
            get { return _financialID; }
            set { _financialID = value; }
        }
        private string _documentNo;
        public string DocumentNo
        {
            get { return _documentNo; }
            set { _documentNo = value; }
        }
        private string _reservationNumber;
        public string ReservationNumber
        {
            get { return _reservationNumber; }
            set { _reservationNumber = value; }
        }

        private DateTime? _checkIn;

        public DateTime? CheckIn
        {
            get { return _checkIn; }
            set { _checkIn = value; }
        }

        private DateTime? _checkOut;

        public DateTime? CheckOut
        {
            get { return _checkOut; }
            set { _checkOut = value; }
        }

        private DateTime _salesDate;
        public DateTime SalesDate
        {
            get { return _salesDate; }
            set { _salesDate = value; }
        }
       
        private decimal _grossAmount;
        public decimal GrossAmount
        {
            get { return _grossAmount; }
            set { _grossAmount = value; }
        }
        private string _currencyCode;
        public string CurrencyCode
        {
            get { return _currencyCode; }
            set { _currencyCode = value; }
        }
        private string _travelerName;

        public string TravelerName
        {
            get { return _travelerName; }
            set { _travelerName = value; }
        }

        private string _hotelName;
        public string HotelName
        {
            get { return _hotelName; }
            set { _hotelName = value; }
        }
        private string _cardNumber;
        public string CardNumber
        {
            get { return _cardNumber; }
            set { _cardNumber = value; }
        }

        private string _financialStatus;

        public string FinancialStatus
        {
            get { return _financialStatus; }
            set { _financialStatus = value; }
        }

        private int _processStatus;
        public int ProcessStatus
        {
            get { return _processStatus; }
            set { _processStatus = value; }
        }
        private decimal? _grossAmountBC;
        public decimal? GrossAmountBC
        {
            get { return _grossAmountBC; }
            set { _grossAmountBC = value; }
        }
        private string _currencyCodeBC;
        public string CurrencyCodeBC
        {
            get { return _currencyCodeBC; }
            set { _currencyCodeBC = value; }
        }
        private decimal? _exchangeRate;
        public decimal? ExchangeRate
        {
            get { return _exchangeRate; }
            set { _exchangeRate = value; }
        }
        private decimal? _exchangeFee;
        public decimal? ExchangeFee
        {
            get { return _exchangeFee; }
            set { _exchangeFee = value; }
        }
        private string _finType;

        public string FinType
        {
            get { return _finType; }
            set { _finType = value; }
        }

        private string _errorCode;

        public string ErrorCode
        {
            get { return _errorCode; }
            set { _errorCode = value; }
        }
        public long I_DataID { get; set; }

        //Apply these field for FIN of Conferma

        private DateTime? _transactionPostDate;

        public DateTime? TransactionPostDate
        {
            get { return _transactionPostDate; }
            set { _transactionPostDate = value; }
        }

        private string _transactionMerchantCountryCode;

        public string TransactionMerchantCountryCode
        {
          get { return _transactionMerchantCountryCode; }
          set { _transactionMerchantCountryCode = value; }
        }

        private string _cardType;

        public string CardType
        {
            get { return _cardType; }
            set { _cardType = value; }
        }

        private long? _cardLastFourDigits;

        public long? CardLastFourDigits
        {
            get { return _cardLastFourDigits; }
            set { _cardLastFourDigits = value; }
        }

        private string _cardIssuer;

        public string CardIssuer
        {
            get { return _cardIssuer; }
            set { _cardIssuer = value; }
        }

        private string _creditHolder;

        public string CreditHolder
        {
            get { return _creditHolder; }
            set { _creditHolder = value; }
        }

        private long? _f_VTITransactionID;

        public long? F_VTITransactionID
        {
            get { return _f_VTITransactionID; }
            set { _f_VTITransactionID = value; }
        }

        private long _f_ImportFileID;

        public long F_ImportFileID
        {
            get { return _f_ImportFileID; }
            set { _f_ImportFileID = value; }
        }

        private long? _errorCodeUpdatedBy;

        public long? ErrorCodeUpdatedBy
        {
            get { return _errorCodeUpdatedBy; }
            set { _errorCodeUpdatedBy = value; }
        }

        private DateTime? _errorCodeUpdatedDate;

        public DateTime? ErrorCodeUpdatedDate
        {
            get { return _errorCodeUpdatedDate; }
            set { _errorCodeUpdatedDate = value; }
		}

        private int? _stopUpdateErrorCode;
        public int? StopUpdateErrorCode
        {
            get { return _stopUpdateErrorCode; }
            set { _stopUpdateErrorCode = value; }
        }
        public long M_F_FileTypeID { get; set; }

        public override string Table { get { return "F_Transaction"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_Transaction_InsertOrUpdate"; } }
    }

    public class F_TransactionImport : F_Transaction
    {
        public F_TransactionAdditionAPC f_TransactionAdditionAPC { get; set; }
    }

    public class F_AmexTransactions : F_Transaction
    {
        public string TransactionNo { get; set; }
        public string FileType { get; set; }
        public bool EnrichmentStatus { get; set; }

        public long TransactionID { get; set; }
        public string CompanyName { get; set; }

        public M_ErrorCode M_ErrorCode { get; set; }

        public string UpdateErrorCodeBy { get; set; }
        public string FormatDateErrorCode { get; set; }
        public string Original_TE { get; set; }
        public string Original_CS { get; set; }
        public string EnrichmentStatus_TE { get; set; }
        public string EnrichmentStatus_CS { get; set; }
        public string ErrorCode_TE { get; set; }
        public string ErrorCode_CS { get; set; }
        public string UpdateErrorCodeBy_TE { get; set; }
        public string UpdateErrorCodeBy_CS { get; set; }
        public DateTime? ErrorCodeUpdatedDate_TE { get; set; }
        public DateTime? ErrorCodeUpdatedDate_CS { get; set; }
        public M_ErrorCode M_ErrorCode_TE { get; set; }
        public M_ErrorCode M_ErrorCode_CS { get; set; }
        public string FormatDateErrorCode_TE { get; set; }
        public string FormatDateErrorCode_CS { get; set; }
        public string OutputFileType_TE { get; set; }
        public string OutputFileType_CS { get; set; }
        public long? TransactionID_TE { get; set; }
        public long? TransactionID_CS { get; set; }
    }

    public class F_AmexFileType : M_F_FileRecord
    {
        private long _m_F_FileRecordID;
        public long M_F_FileRecordID
        {
            get { return _m_F_FileRecordID; }
            set { _m_F_FileRecordID = value; }
        }
        private string _referenceColumn;
        public string ReferenceColumn
        {
            get { return _referenceColumn; }
            set { _referenceColumn = value; }
        }
        private string _fieldName;
        public string FieldName
        {
            get { return _fieldName; }
            set { _fieldName = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private int _pos;
        public int Pos
        {
            get { return _pos; }
            set { _pos = value; }
        }
        private string _format;
        public string Format
        {
            get { return _format; }
            set { _format = value; }
        }
        private string _formatString;
        public string FormatString
        {
            get { return _formatString; }
            set { _formatString = value; }
        }
    }

    public class F_TransactionMatchingWithInvoice : BaseModel
    {
        public long IRowNumber { get; set; }
        public long I_ImageID { get; set; }
        public long I_InvoiceID { get; set; }
        public long B_AccessID { get; set; }
        public decimal IGrossAmount { get; set; }
        public string ICurrencyCode { get; set; }
        public int IResult { get; set; }
        public long FRowNum { get; set; }
        public long F_TransactionID { get; set; }
        public string FType { get; set; }
        public decimal FGrossAmount { get; set; }
        public string FCurrencyCode { get; set; }
        public DateTime FTransactionDate { get; set; }
        public decimal FGrossAmountBC { get; set; }
        public string FCurrencyCodeBC { get; set; }
        public string FDocumentNo { get; set; }
        public int FResult { get; set; }
        public int FCountDebit { get; set; }
        public int FCountCredit { get; set; }
        public bool IsTAccountEquals0 { get; set; }
    }

    public class SkipMatchFinInv : BaseModel
    {
        public string TAccountSide { get; set; }
        public long ID { get; set; }
        public long B_AccessID { get; set; }
        public decimal GrossAmount { get; set; }
        public string CurrencyCode { get; set; }
        public long SingleID { get; set; }
        public long ImageID { get; set; }
        public decimal SingleGrossAmount { get; set; }
        public string SingleCurrencyCode { get; set; }
    }

    public class SkipMatchFinInvSpecialCase : BaseModel
    {
        public long B_AccessID { get; set; }
        public long FinID { get; set; }
        public decimal Fin_GrossAmount { get; set; }
        public string Fin_CurrencyCode { get; set; }
        public long I_ImageID { get; set; }
        public long I_DataID { get; set; }
        public decimal Invoice_GrossAmount { get; set; }
        public string Invoice_CurrencyCode { get; set; }
        public string CaseType { get; set; }
    }

    public class vm_TransactionError
    {
        public FileType FileType { get; set; }
        public long ID { get; set; }
        public string ErrorCode { get; set; }
        public vm_TransactionError()
        {
            FileType = FileType.None;
            ID = 0;
            ErrorCode = string.Empty;
        }
    }

    public class View_Transaction_CommonData
    {
        public List<M_F_FileType> ListFileType;

        public View_Transaction_CommonData()
        {
            ListFileType = new List<M_F_FileType>();
        }
    }

    public enum ImportFIN_Conferma
    {
        DeploymentID = 0,
        TransactionID = 1,
        TransactionDate = 2,
        TransactionPostDate = 3,
        TransactionAccountAmount = 4,
        TransactionAccountCurrency = 5,
        TransactionMerchantAmount = 6,
        TransactionMerchantCurrency = 7,
        TransactionMerchantNarrative = 8,
        TransactionMerchantCountryCode = 9,
        CardType = 10,
        CardLastFourDigits = 11,
        CardIssuer = 12,
        CreditHolder = 13,
        ExchangeRate = 14,
        ExchangeFee = 15,
    }

    public enum FinancialStatus
    {
        New,
        BackCharge,
        DC0,
        Enrich,
        Special
    }

    public enum FileType
    {
        None = 0,
        VTI = 1,
        ATX = 2,
        LARS = 3,
        ATXPlus = 4,
        CSV = 7,
        HotelFormat = 8,
        CDF3 = 9,
        XML = 12,
        GL1076 = 13,
        SBF = 14,
        GL1025 = 15,
        DTR = 16
    }

    public enum ErrorCodeNotEnriched
    {
        NRI = 1,
        CCP = 2,
        IFA = 5,
        CNE = 6,
        DCI = 7,
        DC0 = 8,
        SNL = 9,
        UM1 = 10,
        CTR = 11,
        CLO = 12,
        DSC = 13,
        SND = 14,
        NRB = 15,
        PPT = 16
    }

    public enum F_TransactionColumns
    {
        ID,
        F_HeaderID,
        B_AccessID,
        FinancialID,
        DocumentNo,
        ReservationNumber,
        SalesDate,
        GrossAmount,
        CurrencyCode,
        TravelerName,
        HotelName,
        CardNumber,
        FinancialStatus,
        ProcessStatus,
        GrossAmountBC,
        CurrencyCodeBC,
        ExchangeRate,
        ExchangeFee,
        ErrorCode,
        F_VTITransactionID,
        ErrorCodeUpdatedBy,
        ErrorCodeUpdatedDate,
        StopUpdateErrorCode,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_TransactionProcedure
    {
        p_F_Transaction_GetByReservationNumber,
        p_F_Transaction_GetListByBAccessIDAndStatus,
        p_F_Transaction_Get_ForTAccount,
        p_F_Transaction_GetInfoForCollectionLetter,
        p_F_Transaction_Get_Unmatch_ByInvoiceData,
        p_F_Transaction_GetList_WithoutRelation,
        p_F_Transaction_GetList_WithoutRelation2,
        p_F_Transaction_GetList_WithoutRelation_1N,
        p_F_Transaction_GetList_Relation,
        p_F_Transaction_GetByID,
        p_F_Transaction_Get_ByBooking,
        p_F_Transaction_GetList_ForMatchingWithInvoice,
        p_F_Transaction_GetList_ForMatchingWithReplaceInvoice,
        p_F_Transaction_GetListInfoForNextStepByB_AccessID,
        p_F_Transaction_Get_AirplusErrorCode,
        p_F_Transaction_AirplusErrorCode,
        p_F_Transaction_GetByFinancialID,
        p_F_Transaction_GetListByReservationNumberNullBAccess,
        p_F_Transaction_GetListActive_ByBooking,
        p_F_Transaction_Get_ExportWithTwoCurrenciesByI_DataID,
        p_F_Transaction_GetListForDeleting,
        p_F_Transaction_GetList_ByHeaderID,
        p_F_Transaction_GetList_ByListID,
        p_F_Transaction_GetList_ByListImageID,
        p_P_Validation_GetBy_I_ImageID,
        p_F_Transaction_GetList_ForMatchingWithInvoice_DSC,
        p_F_Transaction_GetList_ForMatchingWithInvoice_SNL,
        p_F_Transaction_GetList_ForMatchingWithInvoice_DC0,
        p_F_Transaction_GetList_ForMatchingWithInvoice_DC0_Auto,
        p_F_Transaction_Get_BackChargeUpdateToProcessing,
        p_F_Transaction_GetList_SendToSC,
        p_F_Transaction_GetByB_AccessID,
        p_F_Transaction_NotMatchFINByB_AccessID,
        p_F_Transaction_GetListNonContract7days_ForCreateSCI,
        p_F_Transaction_UpdatePreStatusFin,
        p_F_Transaction_NotMatchInvoiceByB_AccessID,
        p_F_Transaction_Enrich_FIN_HotelPlatform,
        p_F_Transaction_Check_DuplicatedFIN_Conferma,
        p_F_Transaction_GetListByReservationNumberNullBAccessCFM,
        p_F_Get_List_Transactions,
        p_F_Get_List_Transactions_GetTotal,
        p_F_Transaction_GetGL1076Import,
        p_F_Transaction_GetGL1076Export,
        p_F_Transaction_GetGL1076VTIImport,
        p_F_Transaction_GetGL1076ListPositionExport,
        p_F_Transaction_GetGL1076ListPositionImport,
        p_F_Transaction_GetGL1076VTIListPosition,
        p_F_Transaction_Enrich_FIN_By_PaymentProvider,
        p_F_Transaction_GetList_ByFileType,
        p_F_Transaction_GetByF_E_GL1076_01ID,
        p_F_Transaction_GetByF_I_GL1076_01ID,
        p_F_Transaction_GetList_ByF_ImportFileID,
        p_F_Transaction_GetList_To_UpdateErrorCode,
        p_F_Transaction_GetErrorCode_ByTransactionID,
        p_ATX_Premium_MatchingWithInvoice,
        p_F_Transaction_Structures_ByF_FileTypeID,
        p_F_Transaction_GetByB_AccessID_version_2,
        p_B_Booking_Cancel_GetRefundTransaction,
        p_B_Booking_Cancel_GetLastTransaction,
        p_F_Transaction_GetList_WithoutRelation3,
        p_F_Transaction_GetList_InactiveTransaction_ByTransactionID,
        p_M_F_FileType_GetList_ByPaymentProviderName,
        p_F_Transaction_GetByB_AccessID1,
        p_F_Transaction_Invoice_Skip_Match,
        p_F_Get_List_Transactions2,
        p_F_Get_List_Transactions_GetTotal2,
        p_F_Transaction_GetListTransactionOfBooking_ByReservationNumber_And_CompanyID,
        p_F_Transaction_GetList_For_SkipFin_SpecialCase,
        p_F_Transaction_Get_By_ListId_Only,
        p_F_Transaction_Airplus_ErrorCode,
        p_F_Transaction_Airplus_ErrorCode_Save
    }
    public class F_TransactionList : List<F_Transaction>
    {

    }

    public enum F_TransactionLenght
    {
        length = 716,
    }

    public enum F_TransactionColumnsLength
    {
        ID,
        F_HeaderID,
        B_AccessID,
        FinancialID,
        DocumentNo = 32,
        ReservationNumber = 32,
        SalesDate = 8,
        GrossAmount = 13,
        HotelName = 25,
        CurrencyCode = 3,
        CardNumber = 16,
        ProcessStatus,
        ErrorCodeUpdatedBy,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }


    public class vm_FinError
    {
        public long IDTim { get; set; }
        public FileType FileType { get; set; }
        public long ID { get; set; }
        public string ErrorCode { get; set; }
        public string Comment { get; set; }
        public int StopUpdateErrorCode { get; set; }
        public int ProcessStatus { get; set; }
        public vm_FinError()
        {
            IDTim = 0;
            FileType = FileType.None;
            ID = 0;
            ErrorCode = string.Empty;
            Comment = string.Empty;
            ProcessStatus = 1;
        }
    }

    public class vm_ReactiveFin
    {
        public string FileType { get; set; }
        public long? ID { get; set; }
        public vm_ReactiveFin()
        {
        }
    }

    public class P_SpecialCase_CLO
    {
        public List<F_Transaction> ListF_Transaction { get; set; }

        public B_Comment B_Comment { get; set; }

        public List<B_CommentDetail> ListB_CommentDetail { get; set; }

        public List<P_Invoice_TransferToHistory> ListInvoiceHistory { get; set; }

        public List<P_NextInvoiceStep> ListOldInvoiceNextStep { get; set; }

        public List<P_NextInvoiceStep> ListNewInvoiceNextStep { get; set; }

        public List<I_Image> ListI_Image { get; set; }

        public List<N_Task> ListN_Task { get; set; }

        public List<P_NextFinancialStep> ListP_NextFinancialStep { get; set; }

        public List<P_FinancialStep> ListP_FinancialStep { get; set; }

        public P_SpecialCase_CLO()
        {
            ListF_Transaction = new List<F_Transaction>();
            B_Comment = new B_Comment();
            ListB_CommentDetail = new List<B_CommentDetail>();
            ListInvoiceHistory = new List<P_Invoice_TransferToHistory>();
            ListOldInvoiceNextStep = new List<P_NextInvoiceStep>();
            ListNewInvoiceNextStep = new List<P_NextInvoiceStep>();
            ListI_Image = new List<I_Image>();
            ListN_Task = new List<N_Task>();
            ListP_NextFinancialStep = new List<P_NextFinancialStep>();
            ListP_FinancialStep = new List<P_FinancialStep>();
        }
    }

    public class P_ReactiveFIN
    {
        public List<F_Transaction> ListF_Transaction { get; set; }

        public B_Access B_Access { get; set; }

        public B_Comment B_Comment { get; set; }

        public List<B_CommentDetail> ListB_CommentDetail { get; set; }

        public List<P_FinancialStep> ListP_FinancialStep { get; set; }

        public List<P_NextFinancialStep> ListP_NextFinancialStep { get; set; }

        public List<N_Task> ListN_Task { get; set; }

        public P_ReactiveFIN()
        {
            ListF_Transaction = new List<F_Transaction>();
            B_Access = new B_Access();
            B_Comment = new B_Comment();
            ListB_CommentDetail = new List<B_CommentDetail>();
            ListN_Task = new List<N_Task>();
            ListP_NextFinancialStep = new List<P_NextFinancialStep>();
            ListP_FinancialStep = new List<P_FinancialStep>();
        }
    }
    public class P_ReactiveFINUM1
    {
        public List<F_Transaction> ListF_Transaction { get; set; }

        public B_Comment B_Comment { get; set; }

        public List<B_CommentDetail> ListB_CommentDetail { get; set; }
        public P_ReactiveFINUM1()
        {
            ListF_Transaction = new List<F_Transaction>();
            B_Comment = new B_Comment();
            ListB_CommentDetail = new List<B_CommentDetail>();
        }
    }

    public class P_Transaction_DC0
    {
        private string _bookingNo;

        public string BookingNo
        {
            get { return _bookingNo; }
            set { _bookingNo = value; }
        }

        private long _b_AccessID;

        public long B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }

        private long _fin1_ID;

        public long Fin1_ID
        {
            get { return _fin1_ID; }
            set { _fin1_ID = value; }
        }

        private long _fin2_ID;

        public long Fin2_ID
        {
            get { return _fin2_ID; }
            set { _fin2_ID = value; }
        }

        private decimal _grossAmount;

        public decimal GrossAmount
        {
            get { return _grossAmount; }
            set { _grossAmount = value; }
        }

        private string _currencyCode;

        public string CurrencyCode
        {
            get { return _currencyCode; }
            set { _currencyCode = value; }
        }

        private int _fin1_Result;

        public int Fin1_Result
        {
            get { return _fin1_Result; }
            set { _fin1_Result = value; }
        }

        private int _fin2_Result;

        public int Fin2_Result
        {
            get { return _fin2_Result; }
            set { _fin2_Result = value; }
        }

        private int _totalImage;

        public int TotalImage
        {
            get { return _totalImage; }
            set { _totalImage = value; }
        }
    }
}
