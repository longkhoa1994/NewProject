using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_ProcessStep : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _m_ProcessID;

        public long M_ProcessID
        {
            get { return _m_ProcessID; }
            set { _m_ProcessID = value; }
        }

        private long _m_StepTypeID;

        public long M_StepTypeID
        {
            get { return _m_StepTypeID; }
            set { _m_StepTypeID = value; }
        }


        private bool option;

        public bool Option
        {
            get { return option; }
            set { option = value; }
        }

        public override string Table { get { return "M_ProcessStep"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_ProcessStep_InsertOrUpdate"; } }
    }

    public enum M_ProcessStepColumns
    {
        ID,
        M_ProcessID,
        M_StepTypeID,Option,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_ProcessStepProcedure
    {
        p_M_ProcessStep_GetByProcessID
    }

    public class M_ProcessStepList : List<M_ProcessStep>
    {
    }
}