using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class P_InvoiceValidationDetail : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _p_InvoiceValidationID;

        public long P_InvoiceValidationID
        {
            get { return _p_InvoiceValidationID; }
            set { _p_InvoiceValidationID = value; }
        }

        private long _i_DataID;

        public long I_DataID
        {
            get { return _i_DataID; }
            set { _i_DataID = value; }
        }

        private long? _f_TransactionID;

        
        public long? F_TransactionID
        {
            get { return _f_TransactionID; }
            set { _f_TransactionID = value; }
        }

        public override string Table { get { return "P_InvoiceValidationDetail"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_P_InvoiceValidationDetail_InsertOrUpdate"; } }
    }

    public enum P_InvoiceValidationDetailColumns
    {
        ID,
        P_InvoiceValidationID,
        I_DataID,
        F_TransactionID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum P_InvoiceValidationDetailProcedure
    {
        p_P_InvoiceValidationDetail_GetByTransactionID,
    }

    public class P_InvoiceValidationDetailList : List<P_InvoiceValidationDetail>
    {
    }
}