using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.History
{
    [Serializable]
    public class H_P_Validation : BaseModel
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
        private long? _f_TransactionID;
        public long? F_TransactionID
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
        public override string Table { get { return "H_P_Validation"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_H_P_Validation_InsertOrUpdate"; } }
    }
    public enum H_P_ValidationColumns
    {
        ID,
        H_I_DataID,
        F_TransactionID,
        Result,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum H_P_ValidationProcedure
    {
        p_H_P_Validation_InsertOrUpdate,
        p_H_P_Validation_GetBy_H_I_DataID, 
        p_H_P_Validation_GetListByListH_I_DataID,
        p_H_P_Validation_GetListForDeleting

    }
}

