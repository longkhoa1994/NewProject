using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.History
{
    [Serializable]
    public class H_P_InvoiceError : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _h_I_DataID;
        public long H_I_DataID
        {
            get { return _h_I_DataID; }
            set { _h_I_DataID = value; }
        }
        private long _m_InvoiceErrorCodeID;
        public long M_InvoiceErrorCodeID
        {
            get { return _m_InvoiceErrorCodeID; }
            set { _m_InvoiceErrorCodeID = value; }
        }
        public override string Table { get { return "H_P_InvoiceError"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_H_P_InvoiceError_InsertOrUpdate"; } }
    }
    public enum H_P_InvoiceErrorColumns
    {
        ID,
        H_I_DataID,
        M_InvoiceErrorCodeID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum H_P_InvoiceErrorProcedure
    {
        p_H_P_InvoiceError_InsertOrUpdate,
        p_H_P_InvoiceError_GetBy_H_I_DataID,
        p_H_P_InvoiceError_GetListByListH_I_DataID,
        p_H_P_InvoiceError_GetListForDeleting,
    }
}

