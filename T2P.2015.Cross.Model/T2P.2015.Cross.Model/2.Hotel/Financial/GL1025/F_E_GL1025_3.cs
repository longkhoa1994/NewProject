using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_GL1025_3 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _f_E_GL1025_1ID;
        public long F_E_GL1025_1ID
        {
            get { return _f_E_GL1025_1ID; }
            set { _f_E_GL1025_1ID = value; }
        }
        private string _recordType;
        public string RecordType
        {
            get { return _recordType; }
            set { _recordType = value; }
        }
        private string _transactionMatchedCode1;
        public string TransactionMatchedCode1
        {
            get { return _transactionMatchedCode1; }
            set { _transactionMatchedCode1 = value; }
        }
        private string _transactionMatchedCode2;
        public string TransactionMatchedCode2
        {
            get { return _transactionMatchedCode2; }
            set { _transactionMatchedCode2 = value; }
        }
        private string _accountNumber;
        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        private string _preAuthorizationUniqueID;
        public string PreAuthorizationUniqueID
        {
            get { return _preAuthorizationUniqueID; }
            set { _preAuthorizationUniqueID = value; }
        }
        private string _vPaymentTokenAccountNumber;
        public string vPaymentTokenAccountNumber
        {
            get { return _vPaymentTokenAccountNumber; }
            set { _vPaymentTokenAccountNumber = value; }
        }
        private string _merchantMatchCode;
        public string MerchantMatchCode
        {
            get { return _merchantMatchCode; }
            set { _merchantMatchCode = value; }
        }
        private string _requestorUserIdentifier;
        public string RequestorUserIdentifier
        {
            get { return _requestorUserIdentifier; }
            set { _requestorUserIdentifier = value; }
        }
        private decimal? _preAuthorizationAmount;
        public decimal? PreAuthorizationAmount
        {
            get { return _preAuthorizationAmount; }
            set { _preAuthorizationAmount = value; }
        }
        private string _preAuthorizationStatusCode;
        public string PreAuthorizationStatusCode
        {
            get { return _preAuthorizationStatusCode; }
            set { _preAuthorizationStatusCode = value; }
        }
        private DateTime? _preAuthorizationCreateDate;
        public DateTime? PreAuthorizationCreateDate
        {
            get { return _preAuthorizationCreateDate; }
            set { _preAuthorizationCreateDate = value; }
        }
        private DateTime? _preAuthorizationExpirationDate;
        public DateTime? PreAuthorizationExpirationDate
        {
            get { return _preAuthorizationExpirationDate; }
            set { _preAuthorizationExpirationDate = value; }
        }
        private decimal? _authorizedAmount;
        public decimal? AuthorizedAmount
        {
            get { return _authorizedAmount; }
            set { _authorizedAmount = value; }
        }
        private string _preAuthorizationMerchantName;
        public string PreAuthorizationMerchantName
        {
            get { return _preAuthorizationMerchantName; }
            set { _preAuthorizationMerchantName = value; }
        }
        private string _authorizationCode;
        public string AuthorizationCode
        {
            get { return _authorizationCode; }
            set { _authorizationCode = value; }
        }
        private string _openPreAuthorizationApprovalCode;
        public string OpenPreAuthorizationApprovalCode
        {
            get { return _openPreAuthorizationApprovalCode; }
            set { _openPreAuthorizationApprovalCode = value; }
        }
        private DateTime? _preAuthorizationEffectiveDate;
        public DateTime? PreAuthorizationEffectiveDate
        {
            get { return _preAuthorizationEffectiveDate; }
            set { _preAuthorizationEffectiveDate = value; }
        }
        private decimal? _matchedTransactionAmount;
        public decimal? MatchedTransactionAmount
        {
            get { return _matchedTransactionAmount; }
            set { _matchedTransactionAmount = value; }
        }
        private string _transactionSequenceNumber;
        public string TransactionSequenceNumber
        {
            get { return _transactionSequenceNumber; }
            set { _transactionSequenceNumber = value; }
        }
        private DateTime? _businessProcessDate;
        public DateTime? BusinessProcessDate
        {
            get { return _businessProcessDate; }
            set { _businessProcessDate = value; }
        }
        private string _batchNumber;
        public string BatchNumber
        {
            get { return _batchNumber; }
            set { _batchNumber = value; }
        }
        private string _derivedRequestorCode;
        public string DerivedRequestorCode
        {
            get { return _derivedRequestorCode; }
            set { _derivedRequestorCode = value; }
        }
        private decimal? _partialShipmentAmount;
        public decimal? PartialShipmentAmount
        {
            get { return _partialShipmentAmount; }
            set { _partialShipmentAmount = value; }
        }
        private string _partialShipmentCode;
        public string PartialShipmentCode
        {
            get { return _partialShipmentCode; }
            set { _partialShipmentCode = value; }
        }
        private string _preAuthorizationCurrencyCode;
        public string PreAuthorizationCurrencyCode
        {
            get { return _preAuthorizationCurrencyCode; }
            set { _preAuthorizationCurrencyCode = value; }
        }
        private decimal? _preAuthorizationMaintainedAmount;
        public decimal? PreAuthorizationMaintainedAmount
        {
            get { return _preAuthorizationMaintainedAmount; }
            set { _preAuthorizationMaintainedAmount = value; }
        }
        private decimal? _settledDebitTotalAmount;
        public decimal? SettledDebitTotalAmount
        {
            get { return _settledDebitTotalAmount; }
            set { _settledDebitTotalAmount = value; }
        }
        private int? _settledDebitCount;
        public int? SettledDebitCount
        {
            get { return _settledDebitCount; }
            set { _settledDebitCount = value; }
        }
        private string _userDefined1;
        public string UserDefined1
        {
            get { return _userDefined1; }
            set { _userDefined1 = value; }
        }
        private string _userDefined2;
        public string UserDefined2
        {
            get { return _userDefined2; }
            set { _userDefined2 = value; }
        }
        private string _userDefined3;
        public string UserDefined3
        {
            get { return _userDefined3; }
            set { _userDefined3 = value; }
        }
        private string _userDefined4;
        public string UserDefined4
        {
            get { return _userDefined4; }
            set { _userDefined4 = value; }
        }
        private string _userDefined5;
        public string UserDefined5
        {
            get { return _userDefined5; }
            set { _userDefined5 = value; }
        }
        private string _userDefined6;
        public string UserDefined6
        {
            get { return _userDefined6; }
            set { _userDefined6 = value; }
        }
        private string _userDefined7;
        public string UserDefined7
        {
            get { return _userDefined7; }
            set { _userDefined7 = value; }
        }
        private string _userDefined8;
        public string UserDefined8
        {
            get { return _userDefined8; }
            set { _userDefined8 = value; }
        }
        private string _userDefined9;
        public string UserDefined9
        {
            get { return _userDefined9; }
            set { _userDefined9 = value; }
        }
        private string _userDefined10;
        public string UserDefined10
        {
            get { return _userDefined10; }
            set { _userDefined10 = value; }
        }
        private string _userDefined11;
        public string UserDefined11
        {
            get { return _userDefined11; }
            set { _userDefined11 = value; }
        }
        private string _userDefined12;
        public string UserDefined12
        {
            get { return _userDefined12; }
            set { _userDefined12 = value; }
        }
        private string _accounting1;
        public string Accounting1
        {
            get { return _accounting1; }
            set { _accounting1 = value; }
        }
        private string _accounting2;
        public string Accounting2
        {
            get { return _accounting2; }
            set { _accounting2 = value; }
        }
        private string _accounting3;
        public string Accounting3
        {
            get { return _accounting3; }
            set { _accounting3 = value; }
        }
        private string _accounting4;
        public string Accounting4
        {
            get { return _accounting4; }
            set { _accounting4 = value; }
        }
        private string _accounting5;
        public string Accounting5
        {
            get { return _accounting5; }
            set { _accounting5 = value; }
        }
        private string _accounting6;
        public string Accounting6
        {
            get { return _accounting6; }
            set { _accounting6 = value; }
        }
        private string _accounting7;
        public string Accounting7
        {
            get { return _accounting7; }
            set { _accounting7 = value; }
        }
        private string _accounting8;
        public string Accounting8
        {
            get { return _accounting8; }
            set { _accounting8 = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_E_GL1025_3"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_GL1025_3_InsertOrUpdate"; } }
    }
    public enum F_E_GL1025_3Columns
    {
        ID,
        F_E_GL1025_1ID,
        RecordType,
        TransactionMatchedCode1,
        TransactionMatchedCode2,
        AccountNumber,
        PreAuthorizationUniqueID,
        vPaymentTokenAccountNumber,
        MerchantMatchCode,
        RequestorUserIdentifier,
        PreAuthorizationAmount,
        PreAuthorizationStatusCode,
        PreAuthorizationCreateDate,
        PreAuthorizationExpirationDate,
        AuthorizedAmount,
        PreAuthorizationMerchantName,
        AuthorizationCode,
        OpenPreAuthorizationApprovalCode,
        PreAuthorizationEffectiveDate,
        MatchedTransactionAmount,
        TransactionSequenceNumber,
        BusinessProcessDate,
        BatchNumber,
        DerivedRequestorCode,
        PartialShipmentAmount,
        PartialShipmentCode,
        PreAuthorizationCurrencyCode,
        PreAuthorizationMaintainedAmount,
        SettledDebitTotalAmount,
        SettledDebitCount,
        UserDefined1,
        UserDefined2,
        UserDefined3,
        UserDefined4,
        UserDefined5,
        UserDefined6,
        UserDefined7,
        UserDefined8,
        UserDefined9,
        UserDefined10,
        UserDefined11,
        UserDefined12,
        Accounting1,
        Accounting2,
        Accounting3,
        Accounting4,
        Accounting5,
        Accounting6,
        Accounting7,
        Accounting8,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_GL1025_3Procedure
    {

    }
    public class F_E_GL1025_3List : List<F_E_GL1025_3>
    {

    }
}