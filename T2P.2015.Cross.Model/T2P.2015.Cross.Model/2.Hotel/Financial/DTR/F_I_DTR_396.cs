using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_I_DTR_396 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _f_I_DTR_320ID;
        public long? F_I_DTR_320ID
        {
            get { return _f_I_DTR_320ID; }
            set { _f_I_DTR_320ID = value; }
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
        private string _aquirRefNum;
        public string AquirRefNum
        {
            get { return _aquirRefNum; }
            set { _aquirRefNum = value; }
        }
        private decimal? _addendumSeqNo;
        public decimal? AddendumSeqNo
        {
            get { return _addendumSeqNo; }
            set { _addendumSeqNo = value; }
        }
        private string _empName;
        public string EmpName
        {
            get { return _empName; }
            set { _empName = value; }
        }
        private string _socSecNo;
        public string SocSecNo
        {
            get { return _socSecNo; }
            set { _socSecNo = value; }
        }
        private string _jobCodePos;
        public string JobCodePos
        {
            get { return _jobCodePos; }
            set { _jobCodePos = value; }
        }
        private DateTime? _startDate;
        public DateTime? StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }
        private DateTime? _weekEnding;
        public DateTime? WeekEnding
        {
            get { return _weekEnding; }
            set { _weekEnding = value; }
        }
        private decimal? _regularHrs;
        public decimal? RegularHrs
        {
            get { return _regularHrs; }
            set { _regularHrs = value; }
        }
        private decimal? _regularHrsRate;
        public decimal? RegularHrsRate
        {
            get { return _regularHrsRate; }
            set { _regularHrsRate = value; }
        }
        private decimal? _premiumHrs;
        public decimal? PremiumHrs
        {
            get { return _premiumHrs; }
            set { _premiumHrs = value; }
        }
        private decimal? _premiumHrsRate;
        public decimal? PremiumHrsRate
        {
            get { return _premiumHrsRate; }
            set { _premiumHrsRate = value; }
        }
        private string _flatRateInd;
        public string FlatRateInd
        {
            get { return _flatRateInd; }
            set { _flatRateInd = value; }
        }
        private string _miscExpInd;
        public string MiscExpInd
        {
            get { return _miscExpInd; }
            set { _miscExpInd = value; }
        }
        private decimal? _miscExpAmt;
        public decimal? MiscExpAmt
        {
            get { return _miscExpAmt; }
            set { _miscExpAmt = value; }
        }
        private string _requestName;
        public string RequestName
        {
            get { return _requestName; }
            set { _requestName = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_I_DTR_396"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_I_DTR_396_InsertOrUpdate"; } }
    }
    public enum F_I_DTR_396Columns
    {
        ID,
        F_I_DTR_320ID,
        RecordType,
        BusinessIca,
        ProviderId3,
        ProviderId2,
        ProviderId1,
        ClientProductCode,
        Tbr,
        AcctNo,
        AquirRefNum,
        AddendumSeqNo,
        EmpName,
        SocSecNo,
        JobCodePos,
        StartDate,
        WeekEnding,
        RegularHrs,
        RegularHrsRate,
        PremiumHrs,
        PremiumHrsRate,
        FlatRateInd,
        MiscExpInd,
        MiscExpAmt,
        RequestName,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_I_DTR_396Procedure
    {
        p_F_I_DTR_396_GetBy_F_I_DTR_320ID
    }
    public class F_I_DTR_396List : List<F_I_DTR_396>
    {

    }
}