//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//namespace T2P._2015.Cross.Model
//{
//    [Serializable]
//    public class M_ProcessStepRelation : BaseModel
//    {
//        private long _iD;
//        public long ID
//        {
//            get { return _iD; }
//            set { _iD = value; }
//        }
//        private long _m_ProcessCurrentStepID;
//        public long M_ProcessCurrentStepID
//        {
//            get { return _m_ProcessCurrentStepID; }
//            set { _m_ProcessCurrentStepID = value; }
//        }
//        private long _m_ProcessNextStepID;
//        public long M_ProcessNextStepID
//        {
//            get { return _m_ProcessNextStepID; }
//            set { _m_ProcessNextStepID = value; }
//        }
//        public override string Table { get { return "M_ProcessStepRelation"; } }
//        public override string PrimaryKey { get { return ID.ToString(); } }
//        public override string InsertUpdateProcedure { get { return "p_M_ProcessStepRelation_InsertOrUpdate"; } }
//    }
//    public enum M_ProcessStepRelationColumns
//    {
//        ID,
//        M_ProcessCurrentStepID,
//        M_ProcessNextStepID,
//        CreatedBy,
//        CreatedDate,
//        UpdatedBy,
//        UpdatedDate,
//        Status,
//    }
//    public enum M_ProcessStepRelationProcedure
//    {
//        p_M_ProcessRelationStep_Get_ByStep
//    }
//    public class M_ProcessStepRelationList : List<M_ProcessStepRelation>
//    {

//    }
//}