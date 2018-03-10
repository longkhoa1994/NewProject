using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_Addition : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _b_BookingID;

        public long B_BookingID
        {
            get { return _b_BookingID; }
            set { _b_BookingID = value; }
        }

        private string _correlationID;

        
        public string CorrelationID
        {
            get { return _correlationID; }
            set { _correlationID = value; }
        }

        private string _resStatus;

        
        public string ResStatus
        {
            get { return _resStatus; }
            set { _resStatus = value; }
        }

        private string _echoToken;

        
        public string EchoToken
        {
            get { return _echoToken; }
            set { _echoToken = value; }
        }

        private string _uniqueID_ID;

        
        public string UniqueID_ID
        {
            get { return _uniqueID_ID; }
            set { _uniqueID_ID = value; }
        }

        private string _guestUniqueID_ID;

        
        public string GuestUniqueID_ID
        {
            get { return _guestUniqueID_ID; }
            set { _guestUniqueID_ID = value; }
        }

        private string _guestUniqueID_Type;

        
        public string GuestUniqueID_Type
        {
            get { return _guestUniqueID_Type; }
            set { _guestUniqueID_Type = value; }
        }

        private bool? _prepaidIndicator;

        
        public bool? PrepaidIndicator
        {
            get { return _prepaidIndicator; }
            set { _prepaidIndicator = value; }
        }

        private string _accountNumber;

        
        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        private string _accountingCode;

        
        public string AccountingCode
        {
            get { return _accountingCode; }
            set { _accountingCode = value; }
        }

        private string _internalAccount;

        
        public string InternalAccount
        {
            get { return _internalAccount; }
            set { _internalAccount = value; }
        }

        private string _projectNumberID;

        
        public string ProjectNumberID
        {
            get { return _projectNumberID; }
            set { _projectNumberID = value; }
        }

        private string _projectNumberType;

        
        public string ProjectNumberType
        {
            get { return _projectNumberType; }
            set { _projectNumberType = value; }
        }

        private string _projectNumberContext;

        
        public string ProjectNumberContext
        {
            get { return _projectNumberContext; }
            set { _projectNumberContext = value; }
        }

        private string _employeeNumber;

        
        public string EmployeeNumber
        {
            get { return _employeeNumber; }
            set { _employeeNumber = value; }
        }

        private bool? _freeTextGuestViewable;

        
        public bool? FreeTextGuestViewable
        {
            get { return _freeTextGuestViewable; }
            set { _freeTextGuestViewable = value; }
        }

        private string _freeTextCommentOriginatorCode;

        
        public string FreeTextCommentOriginatorCode
        {
            get { return _freeTextCommentOriginatorCode; }
            set { _freeTextCommentOriginatorCode = value; }
        }

        private string _freeTextValue;

        
        public string FreeTextValue
        {
            get { return _freeTextValue; }
            set { _freeTextValue = value; }
        }

        private int? _numberOfUnits;

        
        public int? NumberOfUnits
        {
            get { return _numberOfUnits; }
            set { _numberOfUnits = value; }
        }

        private string _bankID;

        
        public string BankID
        {
            get { return _bankID; }
            set { _bankID = value; }
        }

        private string _timeZone;

        
        public string TimeZone
        {
            get { return _timeZone; }
            set { _timeZone = value; }
        }

        private string _companyTaxCode;

        
        public string CompanyTaxCode
        {
            get { return _companyTaxCode; }
            set { _companyTaxCode = value; }
        }

        public override string Table { get { return "B_Addition"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_B_Addition_InsertOrUpdate"; } }
    }

    public enum B_AdditionColumns
    {
        ID,
        B_BookingID,
        CorrelationID,
        ResStatus,
        EchoToken,
        UniqueID_ID,
        GuestUniqueID_ID,
        GuestUniqueID_Type,
        PrepaidIndicator,
        AccountNumber,
        AccountingCode,
        InternalAccount,
        ProjectNumberID,
        ProjectNumberType,
        ProjectNumberContext,
        EmployeeNumber,
        FreeTextGuestViewable,
        FreeTextCommentOriginatorCode,
        FreeTextValue,
        NumberOfUnits,
        BankID,
        TimeZone,
        CompanyTaxCode,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_AdditionProcedure
    {
        p_B_Addition_Get_by_B_BookingID,
        p_B_Addition_GetInfoDeliveryInvoice,
        p_B_Addition_GetListForDeleting,

    }

    public class B_AdditionList : List<B_Addition>
    {
    }
}