using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class P_InvoiceError : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _i_DataID;
        public long I_DataID
        {
            get { return _i_DataID; }
            set { _i_DataID = value; }
        }

        private long? _i_PositionID;
        public long? I_PositionID
        {
            get { return _i_PositionID; }
            set { _i_PositionID = value; }
        }
        
        private long _m_InvoiceErrorCodeID;
        public long M_InvoiceErrorCodeID
        {
            get { return _m_InvoiceErrorCodeID; }
            set { _m_InvoiceErrorCodeID = value; }
        }

        private string _comment;
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        public override string Table { get { return "P_InvoiceError"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_P_InvoiceError_InsertOrUpdate"; } }
    }
    public enum P_InvoiceErrorColumns
    {
        ID,
        I_DataID,
        I_PositionID,
        M_InvoiceErrorCodeID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public class P_InvoiceError_Extend : P_InvoiceError
    {
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

        private bool _isSkipVTI;

        public bool IsSkipVTI
        {
            get { return _isSkipVTI; }
            set { _isSkipVTI = value; }
        }

        private int _errorType;

        public int ErrorType
        {
            get { return _errorType; }
            set { _errorType = value; }
        }
    }

    public enum P_InvoiceErrorProcedure
    {
        p_P_InvoiceError_GetByP_ValidationID,
        p_P_InvoiceError_GetByP_ValidationID_ForCorrection,
        p_P_InvoiceError_GetByI_ImageID,
        p_P_InvoiceError_Get_ByI_ImageIDCheckValid,
        p_P_InvoiceError_Get_Translation_ByInvoiceData,
        p_P_InvoiceError_GetBy_I_DataID, 
        p_P_InvoiceError_GetListByListI_DataID,
        p_P_InvoiceError_GetVTIBy_I_DataID,
        p_P_InvoiceError_Extend_GetListByListI_DataID,
        p_P_InvoiceError_GetListForDeleting,
        p_P_InvoiceError_GetByB_AccessID
    }

}