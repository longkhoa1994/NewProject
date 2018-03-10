using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class P_NextFinancialStep : BaseModel
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

        private string _Step;

        public string Step
        {
            get { return _Step; }
            set { _Step = value; }
        }

        private DateTime _expectedTime;

        public DateTime ExpectedTime
        {
            get { return _expectedTime; }
            set { _expectedTime = value; }
        }

        private int _StepStatus;

        public int StepStatus
        {
            get { return _StepStatus; }
            set { _StepStatus = value; }
        }

        public override string Table { get { return "P_NextFinancialStep"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_P_NextFinancialStep_InsertOrUpdate"; } }
    }

    public enum P_NextFinanciaStepColumns
    {
        ID,
        F_TransactionID,
        Step,
        ExpectedTime,
        StepStatus,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum P_NextFinancialStepProcedure
    {
        p_P_NextFinancialStep_Update_Status,
        p_P_NextFinancialStep_GetByF_TransactionID,
        p_P_NextFinancialStep_GetByB_AccessID,
        p_P_NextFinancialStep_GetByI_ImageID,
        p_P_NextFinancialStep_GetForNextStep,
        p_P_NextFinancialStep_GetList_ByStep,
        p_P_NextFinancialStep_GetInfoForCollectionLetter,
        p_P_NextFinancialStep_GetListForDeleting,
        p_P_NextFinancialStep_GetList_ForCreateTask,
        p_P_NextFinancialStep_GetByList_F_TransactionID,
        p_P_NextFinancialStep_Update_StepStatus,
        p_P_NextFinancialStep_GetList_ForNewFin,
        p_P_NextFinancialStep_Delete_DuplicatedFin,
    }

    public class P_NextFinanciaStepList : List<P_NextFinancialStep>
    {
    }
}