using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_M_InvoiceErrorCode : BaseModel
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

        private string _errorCategory;

        public string ErrorCategory
        {
            get { return _errorCategory; }
            set { _errorCategory = value; }
        }

        private int? _errorType;

        public int? ErrorType
        {
            get { return _errorType; }
            set { _errorType = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public override string Table { get { return "R_M_InvoiceErrorCode"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_M_InvoiceErrorCode_InsertOrUpdate"; } }
    }

    public enum R_M_InvoiceErrorCodeColumns
    {
        ID,
        ErrorCode,
        ErrorText,
        ErrorType,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_M_InvoiceErrorCodeProcedure
    {
        p_R_M_InvoiceErrorCode_Get_Translation_ByBooking,
        p_R_M_InvoiceErrorCode_Get_Translation_ByR_I_DataID
    }

    public class R_M_InvoiceErrorCodeList : List<R_M_InvoiceErrorCode>
    {
    }
}