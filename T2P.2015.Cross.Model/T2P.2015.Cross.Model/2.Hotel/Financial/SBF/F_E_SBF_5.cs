using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_SBF_5 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        public long F_E_SBF_2ID { get; set; }
		
        private long? _f_TransactionID;
        public long? F_TransactionID
        {
            get { return _f_TransactionID; }
            set { _f_TransactionID = value; }
        }
        private string _recordTypeID;
        public string RecordTypeID
        {
            get { return _recordTypeID; }
            set { _recordTypeID = value; }
        }
        private string _acctNum;
        public string AcctNum
        {
            get { return _acctNum; }
            set { _acctNum = value; }
        }
        private DateTime? _postDate;
        public DateTime? PostDate
        {
            get { return _postDate; }
            set { _postDate = value; }
        }
        private DateTime? _transDate;
        public DateTime? TransDate
        {
            get { return _transDate; }
            set { _transDate = value; }
        }
        private string _merchDesc;
        public string MerchDesc
        {
            get { return _merchDesc; }
            set { _merchDesc = value; }
        }
        private string _sourceCurrCode;
        public string SourceCurrCode
        {
            get { return _sourceCurrCode; }
            set { _sourceCurrCode = value; }
        }
        private string _billCurrCode;
        public string BillCurrCode
        {
            get { return _billCurrCode; }
            set { _billCurrCode = value; }
        }
		
        private decimal? _foreignCurrAmt;
        public decimal? ForeignCurrAmt
        {
            get { return _foreignCurrAmt; }
            set { _foreignCurrAmt = value; }
        }
        private string _refNum;
        public string RefNum
        {
            get { return _refNum; }
            set { _refNum = value; }
        }
        private string _mccCode;
        public string MccCode
        {
            get { return _mccCode; }
            set { _mccCode = value; }
        }
        private decimal? _transAmt;
        public decimal? TransAmt
		{
            get { return _transAmt; }
            set { _transAmt = value; }
        }
        private string _transCode;
        public string TransCode
        {
            get { return _transCode; }
            set { _transCode = value; }
        }
        private string _merchCity;
        public string MerchCity
        {
            get { return _merchCity; }
            set { _merchCity = value; }
        }
        private string _merchState;
        public string MerchState
        {
            get { return _merchState; }
            set { _merchState = value; }
        }
        private string _merchIcaCode;
        public string MerchIcaCode
        {
            get { return _merchIcaCode; }
            set { _merchIcaCode = value; }
        }
        private string _merchCountry;
        public string MerchCountry
        {
            get { return _merchCountry; }
            set { _merchCountry = value; }
        }
		
        private decimal? _salesTax;
        public decimal? SalesTax
		{
            get { return _salesTax; }
            set { _salesTax = value; }
        }
        private string _salesTaxFlag;
        public string SalesTaxFlag
        {
            get { return _salesTaxFlag; }
            set { _salesTaxFlag = value; }
        }
        private string _purchID;
        public string PurchID
        {
            get { return _purchID; }
            set { _purchID = value; }
        }
        private string _memoInd;
        public string MemoInd
        {
            get { return _memoInd; }
            set { _memoInd = value; }
        }
        private string _ticketNum;
        public string TicketNum
        {
            get { return _ticketNum; }
            set { _ticketNum = value; }
        }
        private string _debitCredit;
        public string DebitCredit
        {
            get { return _debitCredit; }
            set { _debitCredit = value; }
        }
        private string _cardAcceptorID;
        public string CardAcceptorID
        {
            get { return _cardAcceptorID; }
            set { _cardAcceptorID = value; }
        }
        private string _merchantZip;
        public string MerchantZip
        {
            get { return _merchantZip; }
            set { _merchantZip = value; }
        }
        private string _minorityVendorFlag;
        public string MinorityVendorFlag
        {
            get { return _minorityVendorFlag; }
            set { _minorityVendorFlag = value; }
        }
        private string _incorpVendorFlag;
        public string IncorpVendorFlag
        {
            get { return _incorpVendorFlag; }
            set { _incorpVendorFlag = value; }
        }
        private string _freqInd;
        public string FreqInd
        {
            get { return _freqInd; }
            set { _freqInd = value; }
        }
        private string _origAcct;
        public string OrigAcct
        {
            get { return _origAcct; }
            set { _origAcct = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_E_SBF_5"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_SBF_5_InsertOrUpdate"; } }
    }
    public enum F_E_SBF_5Columns
    {
        ID,
        F_TransactionID,
        F_E_SBF_2ID,
        RecordTypeID,
        AcctNum,
        PostDate,
        TransDate,
        MerchDesc,
        SourceCurrCode,
        BillCurrCode,
        ForeignCurrAmt,
        RefNum,
        MccCode,
        TransAmt,
        TransCode,
        MerchCity,
        MerchState,
        MerchIcaCode,
        MerchCountry,
        SalesTax,
        SalesTaxFlag,
        PurchID,
        MemoInd,
        TicketNum,
        DebitCredit,
        CardAcceptorID,
        MerchantZip,
        MinorityVendorFlag,
        IncorpVendorFlag,
        FreqInd,
        OrigAcct,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_SBF_5Procedure
    {
        p_F_E_SBF_5_GetFromImportFIN,
        p_F_E_SBF_5_GetBySBF_2ID,
    }
    public class F_E_SBF_5List : List<F_E_SBF_5>
    {

    }
}