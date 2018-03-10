using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_DTR_310 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _F_E_DTR_201ID;
        public long? F_E_DTR_201ID
        {
            get { return _F_E_DTR_201ID; }
            set { _F_E_DTR_201ID = value; }
        }
        private long? _f_HeaderID;
        public long? F_HeaderID
        {
            get { return _f_HeaderID; }
            set { _f_HeaderID = value; }
        }
        private string _recordType;
        public string RecordType
        {
            get { return _recordType; }
            set { _recordType = value; }
        }
        private string _businessIca;
        public string BusinessIca
        {
            get { return _businessIca; }
            set { _businessIca = value; }
        }
        private string _providerId3;
        public string ProviderId3
        {
            get { return _providerId3; }
            set { _providerId3 = value; }
        }
        private string _providerId2;
        public string ProviderId2
        {
            get { return _providerId2; }
            set { _providerId2 = value; }
        }
        private string _providerId1;
        public string ProviderId1
        {
            get { return _providerId1; }
            set { _providerId1 = value; }
        }
        private string _clientProductCode;
        public string ClientProductCode
        {
            get { return _clientProductCode; }
            set { _clientProductCode = value; }
        }
        private string _tbr;
        public string Tbr
        {
            get { return _tbr; }
            set { _tbr = value; }
        }
        private string _acctNo;
        public string AcctNo
        {
            get { return _acctNo; }
            set { _acctNo = value; }
        }
        private string _name1;
        public string Name1
        {
            get { return _name1; }
            set { _name1 = value; }
        }
        private string _name2;
        public string Name2
        {
            get { return _name2; }
            set { _name2 = value; }
        }
        private string _addrLine1;
        public string AddrLine1
        {
            get { return _addrLine1; }
            set { _addrLine1 = value; }
        }
        private string _addrLine2;
        public string AddrLine2
        {
            get { return _addrLine2; }
            set { _addrLine2 = value; }
        }
        private string _chCity;
        public string ChCity
        {
            get { return _chCity; }
            set { _chCity = value; }
        }
        private string _chState;
        public string ChState
        {
            get { return _chState; }
            set { _chState = value; }
        }
        private string _chZip;
        public string ChZip
        {
            get { return _chZip; }
            set { _chZip = value; }
        }
        private string _accountingCode;
        public string AccountingCode
        {
            get { return _accountingCode; }
            set { _accountingCode = value; }
        }
        private DateTime? _expDate;
        public DateTime? ExpDate
        {
            get { return _expDate; }
            set { _expDate = value; }
        }
        private DateTime? _openDate;
        public DateTime? OpenDate
        {
            get { return _openDate; }
            set { _openDate = value; }
        }
        private string _noOfTransPerD;
        public string NoOfTransPerD
        {
            get { return _noOfTransPerD; }
            set { _noOfTransPerD = value; }
        }
        private decimal? _singleTransLimit;
        public decimal? SingleTransLimit
        {
            get { return _singleTransLimit; }
            set { _singleTransLimit = value; }
        }
        private string _noOfTransPerCycle;
        public string NoOfTransPerCycle
        {
            get { return _noOfTransPerCycle; }
            set { _noOfTransPerCycle = value; }
        }
        private decimal? _amtCreditLimPe;
        public decimal? AmtCreditLimPe
        {
            get { return _amtCreditLimPe; }
            set { _amtCreditLimPe = value; }
        }
        private string _taxExemptIndic;
        public string TaxExemptIndic
        {
            get { return _taxExemptIndic; }
            set { _taxExemptIndic = value; }
        }
        private decimal? _dailyDollarLimi;
        public decimal? DailyDollarLimi
        {
            get { return _dailyDollarLimi; }
            set { _dailyDollarLimi = value; }
        }
        private string _multiLimitWarn;
        public string MultiLimitWarn
        {
            get { return _multiLimitWarn; }
            set { _multiLimitWarn = value; }
        }
        private string _shiptoZipCode;
        public string ShiptoZipCode
        {
            get { return _shiptoZipCode; }
            set { _shiptoZipCode = value; }
        }
        private string _shiptoGeoCode;
        public string ShiptoGeoCode
        {
            get { return _shiptoGeoCode; }
            set { _shiptoGeoCode = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_E_DTR_310"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_DTR_310_InsertOrUpdate"; } }
    }
    public enum F_E_DTR_310Columns
    {
        ID,
        F_E_DTR_201ID,
        F_HeaderID,
        RecordType,
        BusinessIca,
        ProviderId3,
        ProviderId2,
        ProviderId1,
        ClientProductCode,
        Tbr,
        AcctNo,
        Name1,
        Name2,
        AddrLine1,
        AddrLine2,
        ChCity,
        ChState,
        ChZip,
        AccountingCode,
        ExpDate,
        OpenDate,
        NoOfTransPerD,
        SingleTransLimit,
        NoOfTransPerCycle,
        AmtCreditLimPe,
        TaxExemptIndic,
        DailyDollarLimi,
        MultiLimitWarn,
        ShiptoZipCode,
        ShiptoGeoCode,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_DTR_310Procedure
    {
        p_F_E_DTR_310_GetBy_F_E_DTR_201ID,
        p_F_E_DTR_310_GetByF_Header,
    }
    public class F_E_DTR_310List : List<F_E_DTR_310>
    {

    }
}