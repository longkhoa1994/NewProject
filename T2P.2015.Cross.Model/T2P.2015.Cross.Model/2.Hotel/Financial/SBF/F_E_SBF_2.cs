using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_SBF_2 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        public long F_E_SBF_1ID { get; set; }

        public long? F_TransactionID { get; set; }
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
        private string _nameLine1;
        public string NameLine1
        {
            get { return _nameLine1; }
            set { _nameLine1 = value; }
        }
        private string _sSNum;
        public string SSNum
        {
            get { return _sSNum; }
            set { _sSNum = value; }
        }
        private string _placeOfEmploy;
        public string PlaceOfEmploy
        {
            get { return _placeOfEmploy; }
            set { _placeOfEmploy = value; }
        }
        private string _addrLine2;
        public string AddrLine2
        {
            get { return _addrLine2; }
            set { _addrLine2 = value; }
        }
        private DateTime? _expirationDate;
        public DateTime? ExpirationDate
        {
            get { return _expirationDate; }
            set { _expirationDate = value; }
        }
        private string _singleTranLimit;
        public string SingleTranLimit
        {
            get { return _singleTranLimit; }
            set { _singleTranLimit = value; }
        }
        private string _cashLimit;
        public string CashLimit
        {
            get { return _cashLimit; }
            set { _cashLimit = value; }
        }
        private string _convenienceCheckInd;
        public string ConvenienceCheckInd
        {
            get { return _convenienceCheckInd; }
            set { _convenienceCheckInd = value; }
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
        private DateTime? _pmtDueDate;
        public DateTime? PmtDueDate
        {
            get { return _pmtDueDate; }
            set { _pmtDueDate = value; }
        }
        private DateTime? _dob;
        public DateTime? Dob
        {
            get { return _dob; }
            set { _dob = value; }
        }
        private string _statusCode;
        public string StatusCode
        {
            get { return _statusCode; }
            set { _statusCode = value; }
        }
        private string _reasonCode;
        public string ReasonCode
        {
            get { return _reasonCode; }
            set { _reasonCode = value; }
        }
        private string _addrLine1;
        public string AddrLine1
        {
            get { return _addrLine1; }
            set { _addrLine1 = value; }
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
        private string _workPhone;
        public string WorkPhone
        {
            get { return _workPhone; }
            set { _workPhone = value; }
        }
        private string _acctTyp;
        public string AcctTyp
        {
            get { return _acctTyp; }
            set { _acctTyp = value; }
        }
        private string _acctTaxInd;
        public string AcctTaxInd
        {
            get { return _acctTaxInd; }
            set { _acctTaxInd = value; }
        }
        private string _acctCd;
        public string AcctCd
        {
            get { return _acctCd; }
            set { _acctCd = value; }
        }
        private string _employeeID;
        public string EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }
        private string _clientDefined3;
        public string ClientDefined3
        {
            get { return _clientDefined3; }
            set { _clientDefined3 = value; }
        }
        private string _freqIndDaily;
        public string FreqIndDaily
        {
            get { return _freqIndDaily; }
            set { _freqIndDaily = value; }
        }
        private string _freqIndWeekly;
        public string FreqIndWeekly
        {
            get { return _freqIndWeekly; }
            set { _freqIndWeekly = value; }
        }
        private string _freqIndCycle;
        public string FreqIndCycle
        {
            get { return _freqIndCycle; }
            set { _freqIndCycle = value; }
        }
        private string _freqIndMonthly;
        public string FreqIndMonthly
        {
            get { return _freqIndMonthly; }
            set { _freqIndMonthly = value; }
        }
        private string _activatedIndicator;
        public string ActivatedIndicator
        {
            get { return _activatedIndicator; }
            set { _activatedIndicator = value; }
        }
        private string _accountType;
        public string AccountType
        {
            get { return _accountType; }
            set { _accountType = value; }
        }
        private string _vipStatusIndicator;
        public string VipStatusIndicator
        {
            get { return _vipStatusIndicator; }
            set { _vipStatusIndicator = value; }
        }
        private string _execStatusIndicator;
        public string ExecStatusIndicator
        {
            get { return _execStatusIndicator; }
            set { _execStatusIndicator = value; }
        }
        private string _agent;
        public string Agent
        {
            get { return _agent; }
            set { _agent = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_E_SBF_2"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_SBF_2_InsertOrUpdate"; } }
    }
    public enum F_E_SBF_2Columns
    {
        ID,
        F_TransactionID,
        F_E_SBF_1ID,
        RecordTypeID,
        AcctNum,
        NameLine1,
        SSNum,
        PlaceOfEmploy,
        AddrLine2,
        ExpirationDate,
        SingleTranLimit,
        CashLimit,
        ConvenienceCheckInd,
        ClientDefined4,
        Division,
        Department,
        AnnualFee,
        DateAnnualFee,
        PmtDueDate,
        Dob,
        StatusCode,
        ReasonCode,
        AddrLine1,
        City,
        State,
        Zip,
        WorkPhone,
        AcctTyp,
        AcctTaxInd,
        AcctCd,
        EmployeeID,
        ClientDefined3,
        FreqIndDaily,
        FreqIndWeekly,
        FreqIndCycle,
        FreqIndMonthly,
        ActivatedIndicator,
        AccountType,
        VipStatusIndicator,
        ExecStatusIndicator,
        Agent,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_SBF_2Procedure
    {
        p_F_E_SBF_2_GetBySBF_1ID,
        p_F_E_SBF_2_GetFromImportFIN
    }
    public class F_E_SBF_2List : List<F_E_SBF_2>
    {

    }
}