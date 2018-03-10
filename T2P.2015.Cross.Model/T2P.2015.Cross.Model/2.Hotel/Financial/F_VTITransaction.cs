using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_VTITransaction : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _f_VTISummaryID;

        public long F_VTISummaryID
        {
            get { return _f_VTISummaryID; }
            set { _f_VTISummaryID = value; }
        }

        private long _i_DataID;

        public long I_DataID
        {
            get { return _i_DataID; }
            set { _i_DataID = value; }
        }

        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private string _documentNo;

        public string DocumentNo
        {
            get { return _documentNo; }
            set { _documentNo = value; }
        }

        private string _deliveryType;

        public string DeliveryType
        {
            get { return _deliveryType; }
            set { _deliveryType = value; }
        }

        private string _kKTI;

        public string KKTI
        {
            get { return _kKTI; }
            set { _kKTI = value; }
        }

        private DateTime _salesDateTime;

        public DateTime SalesDateTime
        {
            get { return _salesDateTime; }
            set { _salesDateTime = value; }
        }

        private string _cardNumber;

        public string CardNumber
        {
            get { return _cardNumber; }
            set { _cardNumber = value; }
        }

        private string _contractNumber;

        public string ContractNumber
        {
            get { return _contractNumber; }
            set { _contractNumber = value; }
        }

        private decimal _transactionCurrencyCode;

        public decimal TransactionCurrencyCode
        {
            get { return _transactionCurrencyCode; }
            set { _transactionCurrencyCode = value; }
        }

        private decimal? _billingCurrencyCode;

        
        public decimal? BillingCurrencyCode
        {
            get { return _billingCurrencyCode; }
            set { _billingCurrencyCode = value; }
        }

        private decimal _transactionAmount;

        public decimal TransactionAmount
        {
            get { return _transactionAmount; }
            set { _transactionAmount = value; }
        }

        private decimal? _billingCurrencyAmount;


        public decimal? BillingCurrencyAmount
        {
            get { return _billingCurrencyAmount; }
            set { _billingCurrencyAmount = value; }
        }

        private decimal? _exchangeRate;

        
        public decimal? ExchangeRate
        {
            get { return _exchangeRate; }
            set { _exchangeRate = value; }
        }

        private decimal _numberOfAdditionalInformationSet;

        public decimal NumberOfAdditionalInformationSet
        {
            get { return _numberOfAdditionalInformationSet; }
            set { _numberOfAdditionalInformationSet = value; }
        }

        private decimal _processingKey;

        public decimal ProcessingKey
        {
            get { return _processingKey; }
            set { _processingKey = value; }
        }

        private decimal _specialFeatureKey;

        public decimal SpecialFeatureKey
        {
            get { return _specialFeatureKey; }
            set { _specialFeatureKey = value; }
        }

        private decimal _entryType;

        public decimal EntryType
        {
            get { return _entryType; }
            set { _entryType = value; }
        }

        private decimal _pINAbility;

        public decimal PINAbility
        {
            get { return _pINAbility; }
            set { _pINAbility = value; }
        }

        private string _noApproval;

        
        public string NoApproval
        {
            get { return _noApproval; }
            set { _noApproval = value; }
        }

        private string _pTC;

        
        public string PTC
        {
            get { return _pTC; }
            set { _pTC = value; }
        }

        private string _cIM;

        
        public string CIM
        {
            get { return _cIM; }
            set { _cIM = value; }
        }

        private string _terminalID;

        
        public string TerminalID
        {
            get { return _terminalID; }
            set { _terminalID = value; }
        }

        private string _sTAN;

        
        public string STAN
        {
            get { return _sTAN; }
            set { _sTAN = value; }
        }

        private string _pOSTerminalType;

        public string POSTerminalType
        {
            get { return _pOSTerminalType; }
            set { _pOSTerminalType = value; }
        }

        private decimal? _expiryDate;

        
        public decimal? ExpiryDate
        {
            get { return _expiryDate; }
            set { _expiryDate = value; }
        }

        private string _cardholderName;

        
        public string CardholderName
        {
            get { return _cardholderName; }
            set { _cardholderName = value; }
        }

        private string _sale;

        
        public string Sale
        {
            get { return _sale; }
            set { _sale = value; }
        }

        private int _vTIStatus;

        public int VTIStatus
        {
            get { return _vTIStatus; }
            set { _vTIStatus = value; }
        }

        private string _comment;

        
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }


        private string _enrichFileType;


        public string EnrichFileType
        {
            get { return _enrichFileType; }
            set { _enrichFileType = value; }
        }


        private long _f_TransactionID;


        public long F_TransactionID
        {
            get { return _f_TransactionID; }
            set { _f_TransactionID = value; }
        }



        public override string Table { get { return "F_VTITransaction"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_F_VTITransaction_InsertOrUpdate"; } }
    }

    public enum F_VTITransactionColumns
    {
        ID,
        F_VTISummaryID,
        I_DataID,
        Type,
        DocumentNo,
        DeliveryType,
        KKTI,
        SalesDateTime,
        CardNumber,
        ContractNumber,
        TransactionCurrencyCode,
        BillingCurrencyCode,
        TransactionAmount,
        BillingCurrencyAmount,
        ExchangeRate,
        NumberOfAdditionalInformationSet,
        ProcessingKey,
        SpecialFeatureKey,
        EntryType,
        PINAbility,
        NoApproval,
        PTC,
        CIM,
        TerminalID,
        STAN,
        POSTerminalType,
        ExpiryDate,
        CardholderName,
        Sale,
        VTIStatus,
        Comment,
        EnrichFileType,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum F_VTITransactionProcedure
    {
        p_F_VTITransaction_Create,
        p_F_VTITransaction_GetByI_DataID,
        p_F_VTITransaction_GetListForDeleting,
        p_F_VTITransaction_GetByI_ImageID
    }

    public class F_VTITransactionList : List<F_VTITransaction>
    {
    }
}