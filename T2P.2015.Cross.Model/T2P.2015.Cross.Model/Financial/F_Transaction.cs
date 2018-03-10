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
        public override string Table { get { return "F_Transaction"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_Transaction_InsertOrUpdate"; } }
    }

    public class F_TransactionImport : F_Transaction
    {
        public F_TransactionAdditionAPC f_TransactionAdditionAPC { get; set; }
    }

    public class F_TransactionMatchingWithInvoice : BaseModel
    {
        public long IRowNumber { get; set; }
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

    public enum FinancialStatus
    { 
        New,
        BackCharge,
        DC0
    }

    public enum FileType
    {
        None = 0,
        VTI = 1,
        ATX = 2,
        LARS = 3,
        ATXPlus = 4,
        CSV = 7
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
        p_F_Transaction_GetList_ForMatchingWithInvoice_DSC,
        p_F_Transaction_GetList_ForMatchingWithInvoice_SNL,
        p_F_Transaction_GetList_ForMatchingWithInvoice_DC0,
        p_F_Transaction_Get_BackChargeUpdateToProcessing,
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
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }


    public class vm_FinError
    {
        public FileType FileType { get; set; }
        public long ID { get; set; }
        public string ErrorCode { get; set; }
        public string Comment { get; set; }
        public vm_FinError()
        {
            FileType = FileType.None;
            ID = 0;
            ErrorCode = string.Empty;
            Comment = string.Empty;
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
}
