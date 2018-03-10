using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_StepRelation : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_CurrentStepID;
        public long CurrentStepID
        {
            get { return _m_CurrentStepID; }
            set { _m_CurrentStepID = value; }
        }
        private long _m_NextStepID;
        public long NextStepID
        {
            get { return _m_NextStepID; }
            set { _m_NextStepID = value; }
        }
        public override string Table { get { return "M_StepRelation"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_StepRelation_InsertOrUpdate"; } }
    }
    public enum M_StepRelationColumns
    {
        ID,
        CurrentStepID,
        NextStepID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_StepRelationProcedure
    {
        p_M_StepRelation_Get_ByStep
    }
    public class M_StepRelationList : List<M_StepRelation>
    {

    }
}