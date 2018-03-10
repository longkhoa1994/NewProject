using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_Error : BaseModel
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

        private long _m_InvoiceErrorCodeID;

        public long M_InvoiceErrorCodeID
        {
            get { return _m_InvoiceErrorCodeID; }
            set { _m_InvoiceErrorCodeID = value; }
        } 

        public override string Table { get { return "I_Error"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_I_Error_InsertOrUpdate"; } }
    }

    public enum I_ErrorColumns
    {
        ID,
        I_DataID,
        I_InvoiceErrorCodeID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum I_ErrorProcedure
    {
        p_I_Error_GetByDataID,
        p_I_Error_UpdateStatus,
        p_I_Error_CompareErrorToSetInActiveI_Error,
        p_I_Error_GetListByListI_DataID,
        p_I_Error_GetListForDeleting
    } 

    public class I_ErrorList : List<I_Error>
    {
    }
}