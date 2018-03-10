using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_InvoiceError : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _p_ValidationID;
        public long P_ValidationID
        {
            get { return _p_ValidationID; }
            set { _p_ValidationID = value; }
        }
        private long _i_InvoiceErrorCodeID;
        public long I_InvoiceErrorCodeID
        {
            get { return _i_InvoiceErrorCodeID; }
            set { _i_InvoiceErrorCodeID = value; }
        }
        public override string Table { get { return "I_InvoiceError"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_InvoiceError_InsertOrUpdate"; } }
    }
    public enum I_InvoiceErrorColumns
    {
        ID,
        P_ValidationID,
        I_InvoiceErrorCodeID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum I_InvoiceErrorProcedure
    {

    }
    public class I_InvoiceErrorList : List<I_InvoiceError>
    {

    }
}