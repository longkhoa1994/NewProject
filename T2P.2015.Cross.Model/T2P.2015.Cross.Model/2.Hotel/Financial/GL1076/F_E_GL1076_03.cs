using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_GL1076_03 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _recordType;
        public string RecordType
        {
            get { return _recordType; }
            set { _recordType = value; }
        }
        private long _f_E_GL1076_01ID;

        public long F_E_GL1076_01ID
        {
            get { return _f_E_GL1076_01ID; }
            set { _f_E_GL1076_01ID = value; }
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
        private string _userAccountingInformation1Text;
        public string UserAccountingInformation1Text
        {
            get { return _userAccountingInformation1Text; }
            set { _userAccountingInformation1Text = value; }
        }
        private string _userAccountingInformation2Text;
        public string UserAccountingInformation2Text
        {
            get { return _userAccountingInformation2Text; }
            set { _userAccountingInformation2Text = value; }
        }
        private string _userAccountingInformation3Text;
        public string UserAccountingInformation3Text
        {
            get { return _userAccountingInformation3Text; }
            set { _userAccountingInformation3Text = value; }
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
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }

        public override string Table { get { return "F_E_GL1076_03"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_GL1076_03_InsertOrUpdate"; } }
    }
    public enum F_E_GL1076_03Columns
    {
        ID,
        RecordType,
        F_E_GL1076_01ID,
        TransactionMatchedCode1,
        TransactionMatchedCode2,
        AccountNumber,
        PreAuthorizationUniqueID,
        MerchantMatchCode,
        RequestorUserIdentifier,
        PreAuthorizationAmount,
        PreAuthorizationStatusCode,
        PreAuthorizationCreateDate,
        PreAuthorizationExpirationDate,
        UserAccountingInformation1Text,
        UserAccountingInformation2Text,
        UserAccountingInformation3Text,
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
        Filler,
        CreatedDate,
        CreatedBy,
        UpdatedDate,
        Updatedby,
        Status,
    }
    public enum F_E_GL1076_03Procedure
    {
        p_F_E_GL1076_03_Get_By_F_E_GL_1076_01ID,
    }
    public class F_E_GL1076_03List : List<F_E_GL1076_03>
    {

    }
}