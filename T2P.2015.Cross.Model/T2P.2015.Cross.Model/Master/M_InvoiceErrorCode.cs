using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_InvoiceErrorCode : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _errorCode;

        public string ErrorCode
        {
            get { return _errorCode; }
            set { _errorCode = value; }
        }

        private string _errorText;

        public string ErrorText
        {
            get { return _errorText; }
            set { _errorText = value; }
        }

        private int? _errorType;

        
        public int? ErrorType
        {
            get { return _errorType; }
            set { _errorType = value; }
        }

        private bool? _isSkipVTI;

        
        public bool? IsSkipVTI
        {
            get { return _isSkipVTI; }
            set { _isSkipVTI = value; }
        }

        private bool? _isSendTraveler;

        public bool? IsSendTraveler
        {
            get { return _isSendTraveler; }
            set { _isSendTraveler = value; }
        }

        private bool? _isSkipOnCorrect; 

        public bool? IsSkipOnCorrect
        {
            get { return _isSkipOnCorrect; }
            set { _isSkipOnCorrect = value; }
        }

        private string _description;

        
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private bool _isErrorCheck;

        public bool IsErrorCheck
        {
            get { return _isErrorCheck; }
            set { _isErrorCheck = value; }
        }

        private string _rule;

        public string Rule
        {
            get { return _rule; }
            set { _rule = value; }
        }
        public override string Table { get { return "M_InvoiceErrorCode"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_InvoiceErrorCode_InsertOrUpdate"; } }
    }

    public enum M_InvoiceErrorCodeColumns
    {
        ID,
        ErrorCode,
        ErrorText,
        ErrorType,
        IsSkipVTI,
        IsSendTraveler,
        IsSkipOnCorrect,
        Description,
        Rule,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_InvoiceErrorCodeProcedure
    {
        p_M_InvoiceErrorCode_GetByErrorCode,
        p_M_InvoiceErrorCode_GetByDataID,
        p_M_InvoiceErrorCode_Get_Translation_ByInvoiceData, 
        p_M_InvoiceErrorCode_Get_Translation_ByBooking,
        p_M_InvoiceErrorCode_Get_ForTypingRule,
        p_M_InvoiceErrorCode_Get_Translation,
    }

    public class M_InvoiceErrorCodeList : List<M_InvoiceErrorCode>
    {
    }
}