using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_ProcessActor : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _m_ProcessStepID;

        public long M_ProcessStepID
        {
            get { return _m_ProcessStepID; }
            set { _m_ProcessStepID = value; }
        }

        public override string Table { get { return "M_ProcessActor"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_ProcessActor_InsertOrUpdate"; } }
    }

    public enum M_ProcessActorColumns
    {
        ID,
        M_ProcessStepID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_ProcessActorProcedure
    {
    }

    public class M_ProcessActorList : List<M_ProcessActor>
    {
    }
}