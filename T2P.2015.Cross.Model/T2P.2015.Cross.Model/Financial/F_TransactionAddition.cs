using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_TransactionAddition : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _f_TransactionID;

        public long F_TransactionID
        {
            get { return _f_TransactionID; }
            set { _f_TransactionID = value; }
        }

        public override string Table { get { return "F_TransactionAddition"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_F_TransactionAddition_InsertOrUpdate"; } }
    }

    public enum F_TransactionAdditionColumns
    {
        ID,
        F_TransactionID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum F_TransactionAdditionProcedure
    {
    }

    public class F_TransactionAdditionList : List<F_TransactionAddition>
    {
    }
}