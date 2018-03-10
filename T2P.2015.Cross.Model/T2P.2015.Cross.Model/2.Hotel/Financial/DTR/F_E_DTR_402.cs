using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_DTR_402 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _F_E_DTR_310ID;
        public long? F_E_DTR_310ID
        {
            get { return _F_E_DTR_310ID; }
            set { _F_E_DTR_310ID = value; }
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
        private decimal? _levelNum;
        public decimal? LevelNum
        {
            get { return _levelNum; }
            set { _levelNum = value; }
        }
        private string _refNum;
        public string RefNum
        {
            get { return _refNum; }
            set { _refNum = value; }
        }
        private decimal? _transCd;
        public decimal? TransCd
        {
            get { return _transCd; }
            set { _transCd = value; }
        }
        private string _debitCredit;
        public string DebitCredit
        {
            get { return _debitCredit; }
            set { _debitCredit = value; }
        }
        private decimal? _transAmt;
        public decimal? TransAmt
        {
            get { return _transAmt; }
            set { _transAmt = value; }
        }
        private string _transDesc;
        public string TransDesc
        {
            get { return _transDesc; }
            set { _transDesc = value; }
        }
        private string _merchState;
        public string MerchState
        {
            get { return _merchState; }
            set { _merchState = value; }
        }
        private string _merchCatCode;
        public string MerchCatCode
        {
            get { return _merchCatCode; }
            set { _merchCatCode = value; }
        }
        private string _companyAcct;
        public string CompanyAcct
        {
            get { return _companyAcct; }
            set { _companyAcct = value; }
        }
        private string _billingAcct;
        public string BillingAcct
        {
            get { return _billingAcct; }
            set { _billingAcct = value; }
        }
        private string _postedCurrencyCd;
        public string PostedCurrencyCd
        {
            get { return _postedCurrencyCd; }
            set { _postedCurrencyCd = value; }
        }
        private DateTime? _transDate;
        public DateTime? TransDate
        {
            get { return _transDate; }
            set { _transDate = value; }
        }
        private DateTime? _postingDate;
        public DateTime? PostingDate
        {
            get { return _postingDate; }
            set { _postingDate = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_E_DTR_402"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_DTR_402_InsertOrUpdate"; } }
    }
    public enum F_E_DTR_402Columns
    {
        ID,
        F_E_DTR_310ID,
        RecordType,
        BusinessIca,
        ProviderId3,
        ProviderId2,
        ProviderId1,
        ClientProductCode,
        Tbr,
        AcctNo,
        LevelNum,
        RefNum,
        TransCd,
        DebitCredit,
        TransAmt,
        TransDesc,
        MerchState,
        MerchCatCode,
        CompanyAcct,
        BillingAcct,
        PostedCurrencyCd,
        TransDate,
        PostingDate,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_DTR_402Procedure
    {
        p_F_E_DTR_402_GetBy_F_E_DTR_310ID
    }
    public class F_E_DTR_402List : List<F_E_DTR_402>
    {

    }
}