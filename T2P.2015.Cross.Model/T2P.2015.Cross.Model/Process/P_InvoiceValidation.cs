using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class P_InvoiceValidation : BaseModel
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
        private long _f_TransactionID;
        public long F_TransactionID
        {
            get { return _f_TransactionID; }
            set { _f_TransactionID = value; }
        }
        private int _result;

        public int Result
        {
            get { return _result; }
            set { _result = value; }
        }
        public override string Table { get { return "P_InvoiceValidation"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_P_InvoiceValidation_InsertOrUpdate"; } }
    }
    public enum P_InvoiceValidationColumns
    {
        ID,
        I_DataID,
        F_TransactionID,
        Result,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum P_InvoiceValidationProcedure
    {

    }
    public class P_InvoiceValidationList : List<P_InvoiceValidation>
    {

    }
}