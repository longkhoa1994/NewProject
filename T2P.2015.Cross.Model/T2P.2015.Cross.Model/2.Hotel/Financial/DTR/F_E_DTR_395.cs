using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_DTR_395 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _F_E_DTR_320ID;
        public long? F_E_DTR_320ID
        {
            get { return _F_E_DTR_320ID; }
            set { _F_E_DTR_320ID = value; }
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
        private decimal? _processingCo;
        public decimal? ProcessingCo
        {
            get { return _processingCo; }
            set { _processingCo = value; }
        }
        private decimal? _merchLookUpOpt;
        public decimal? MerchLookUpOpt
        {
            get { return _merchLookUpOpt; }
            set { _merchLookUpOpt = value; }
        }
        private decimal? _maintainedBy;
        public decimal? MaintainedBy
        {
            get { return _maintainedBy; }
            set { _maintainedBy = value; }
        }
        private decimal? _acquirerId;
        public decimal? AcquirerId
        {
            get { return _acquirerId; }
            set { _acquirerId = value; }
        }
        private decimal? _merchantId;
        public decimal? MerchantId
        {
            get { return _merchantId; }
            set { _merchantId = value; }
        }
        private decimal? _preAuthApprove;
        public decimal? PreAuthApprove
        {
            get { return _preAuthApprove; }
            set { _preAuthApprove = value; }
        }
        private string _authUsedFlag;
        public string AuthUsedFlag
        {
            get { return _authUsedFlag; }
            set { _authUsedFlag = value; }
        }
        private DateTime? _enteredDate;
        public DateTime? EnteredDate
        {
            get { return _enteredDate; }
            set { _enteredDate = value; }
        }
        private DateTime? _expirationDate;
        public DateTime? ExpirationDate
        {
            get { return _expirationDate; }
            set { _expirationDate = value; }
        }
        private string _clientDefDe1;
        public string ClientDefDe1
        {
            get { return _clientDefDe1; }
            set { _clientDefDe1 = value; }
        }
        private string _clientDefDe2;
        public string ClientDefDe2
        {
            get { return _clientDefDe2; }
            set { _clientDefDe2 = value; }
        }
        private string _clientDefDe3;
        public string ClientDefDe3
        {
            get { return _clientDefDe3; }
            set { _clientDefDe3 = value; }
        }
        private decimal? _amtCardhBill;
        public decimal? AmtCardhBill
        {
            get { return _amtCardhBill; }
            set { _amtCardhBill = value; }
        }
        private string _cardAcceptorIdCs;
        public string CardAcceptorIdCs
        {
            get { return _cardAcceptorIdCs; }
            set { _cardAcceptorIdCs = value; }
        }
        private string _cardAcceptorNameLo;
        public string CardAcceptorNameLo
        {
            get { return _cardAcceptorNameLo; }
            set { _cardAcceptorNameLo = value; }
        }
        private decimal? _authCode;
        public decimal? AuthCode
        {
            get { return _authCode; }
            set { _authCode = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_E_DTR_395"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_DTR_395_InsertOrUpdate"; } }
    }
    public enum F_E_DTR_395Columns
    {
        ID,
        F_E_DTR_320ID,
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
        ProcessingCo,
        MerchLookUpOpt,
        MaintainedBy,
        AcquirerId,
        MerchantId,
        PreAuthApprove,
        AuthUsedFlag,
        EnteredDate,
        ExpirationDate,
        ClientDefDe1,
        ClientDefDe2,
        ClientDefDe3,
        AmtCardhBill,
        CardAcceptorIdCs,
        CardAcceptorNameLo,
        AuthCode,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_DTR_395Procedure
    {
        p_F_E_DTR_395_GetBy_F_E_DTR_320ID
    }
    public class F_E_DTR_395List : List<F_E_DTR_395>
    {

    }
}