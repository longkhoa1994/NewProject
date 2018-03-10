using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_I_SBF_8 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _f_I_SBF_1ID;
        public long F_I_SBF_1ID
        {
            get { return _f_I_SBF_1ID; }
            set { _f_I_SBF_1ID = value; }
        }
        private string _recordTypeID;
        public string RecordTypeID
        {
            get { return _recordTypeID; }
            set { _recordTypeID = value; }
        }
        private string _providerID3;
        public string ProviderID3
        {
            get { return _providerID3; }
            set { _providerID3 = value; }
        }
        private string _providerID2;
        public string ProviderID2
        {
            get { return _providerID2; }
            set { _providerID2 = value; }
        }
        private string _providerID1;
        public string ProviderID1
        {
            get { return _providerID1; }
            set { _providerID1 = value; }
        }
        private string _clientProductCode;
        public string ClientProductCode
        {
            get { return _clientProductCode; }
            set { _clientProductCode = value; }
        }
        private string _compNum;
        public string CompNum
        {
            get { return _compNum; }
            set { _compNum = value; }
        }
        private string _totAcctsForComp;
        public string TotAcctsForComp
        {
            get { return _totAcctsForComp; }
            set { _totAcctsForComp = value; }
        }
        private string _totCreditLimit;
        public string TotCreditLimit
        {
            get { return _totCreditLimit; }
            set { _totCreditLimit = value; }
        }
        private float? _totCurrPaymntsDue;
        public float? TotCurrPaymntsDue
        {
            get { return _totCurrPaymntsDue; }
            set { _totCurrPaymntsDue = value; }
        }
        private string _totNumAcctsPastDue;
        public string TotNumAcctsPastDue
        {
            get { return _totNumAcctsPastDue; }
            set { _totNumAcctsPastDue = value; }
        }
        private float? _totAmtPastDue;
        public float? TotAmtPastDue
        {
            get { return _totAmtPastDue; }
            set { _totAmtPastDue = value; }
        }
        private float? _totDisputedAmt;
        public float? TotDisputedAmt
        {
            get { return _totDisputedAmt; }
            set { _totDisputedAmt = value; }
        }
        private string _totNumCardsOutstand;
        public string TotNumCardsOutstand
        {
            get { return _totNumCardsOutstand; }
            set { _totNumCardsOutstand = value; }
        }
        private string _nameLine1;
        public string NameLine1
        {
            get { return _nameLine1; }
            set { _nameLine1 = value; }
        }
        private string _addrLine2;
        public string AddrLine2
        {
            get { return _addrLine2; }
            set { _addrLine2 = value; }
        }
        private float? _cashAmount;
        public float? CashAmount
        {
            get { return _cashAmount; }
            set { _cashAmount = value; }
        }
        private string _clientDefined4;
        public string ClientDefined4
        {
            get { return _clientDefined4; }
            set { _clientDefined4 = value; }
        }
        private string _division;
        public string Division
        {
            get { return _division; }
            set { _division = value; }
        }
        private string _department;
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }
        private float? _annualFee;
        public float? AnnualFee
        {
            get { return _annualFee; }
            set { _annualFee = value; }
        }
        private DateTime? _dateAnnualFee;
        public DateTime? DateAnnualFee
        {
            get { return _dateAnnualFee; }
            set { _dateAnnualFee = value; }
        }
        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        private string _state;
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        private string _zip;
        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }
        private DateTime? _payDueDate;
        public DateTime? PayDueDate
        {
            get { return _payDueDate; }
            set { _payDueDate = value; }
        }
        private float? _netDlyBalance;
        public float? NetDlyBalance
        {
            get { return _netDlyBalance; }
            set { _netDlyBalance = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_I_SBF_8"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_I_SBF_8_InsertOrUpdate"; } }
    }
    public enum F_I_SBF_8Columns
    {
        ID,
        F_I_SBF_1ID,
        RecordTypeID,
        ProviderID3,
        ProviderID2,
        ProviderID1,
        ClientProductCode,
        CompNum,
        TotAcctsForComp,
        TotCreditLimit,
        TotCurrPaymntsDue,
        TotNumAcctsPastDue,
        TotAmtPastDue,
        TotDisputedAmt,
        TotNumCardsOutstand,
        NameLine1,
        AddrLine2,
        CashAmount,
        ClientDefined4,
        Division,
        Department,
        AnnualFee,
        DateAnnualFee,
        City,
        State,
        Zip,
        PayDueDate,
        NetDlyBalance,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_I_SBF_8Procedure
    {

    }
    public class F_I_SBF_8List : List<F_I_SBF_8>
    {

    }
}