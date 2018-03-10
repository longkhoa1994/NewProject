using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_ProcessCondition : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_ProcessStepRelationID;
        public long M_ProcessStepRelationID
        {
            get { return _m_ProcessStepRelationID; }
            set { _m_ProcessStepRelationID = value; }
        }
        private string _condition;
        public string Condition
        {
            get { return _condition; }
            set { _condition = value; }
        }
        private int _result;
        public int Result
        {
            get { return _result; }
            set { _result = value; }
        }
        public override string Table { get { return "M_ProcessCondition"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_ProcessCondition_InsertOrUpdate"; } }
    }
    public enum M_ProcessConditionColumns
    {
        ID,
        M_ProcessStepRelationID,
        Condition,
        Result,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_ProcessConditionProcedure
    {

    }
    public class M_ProcessConditionList : List<M_ProcessCondition>
    {

    }
}