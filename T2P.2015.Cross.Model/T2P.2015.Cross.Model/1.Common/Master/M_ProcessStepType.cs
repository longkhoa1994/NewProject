using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_ProcessStepType : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _stepCategory;

        public string StepCategory
        {
            get { return _stepCategory; }
            set { _stepCategory = value; }
        }

        private string _stepCode;

        public string StepCode
        {
            get { return _stepCode; }
            set { _stepCode = value; }
        }
       
        private string _stepName;

        public string StepName
        {
            get { return _stepName; }
            set { _stepName = value; }
        }

        public override string Table { get { return "M_ProcessStepType"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_ProcessStepType_InsertOrUpdate"; } }
    }

    public enum M_ProcessStepTypeColumns
    {
        ID,
        StepCategory,
        StepCode,
        StepName,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_ProcessStepTypeProcedure
    {
    }

    public class M_ProcessStepTypeList : List<M_ProcessStepList>
    {
    }
}