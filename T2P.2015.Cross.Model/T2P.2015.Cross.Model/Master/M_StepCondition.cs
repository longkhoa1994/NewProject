using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_StepCondition : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _currentStepID;
        public long CurrentStepID
        {
            get { return _currentStepID; }
            set { _currentStepID = value; }
        }
        private long _m_ConditionID;
        public long M_ConditionID
        {
            get { return _m_ConditionID; }
            set { _m_ConditionID = value; }
        }
        private int _require;
        public int Require
        {
            get { return _require; }
            set { _require = value; }
        }
        public override string Table { get { return "M_StepCondition"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_StepCondition_InsertOrUpdate"; } }
    }
    public enum M_StepConditionColumns
    {
        ID,
        CurrentStepID,
        M_ConditionID,
        Require,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_StepConditionProcedure
    {
        p_M_StepCondition_Get_ByStep
    }
    public class M_StepConditionList : List<M_StepCondition>
    {

    }
}