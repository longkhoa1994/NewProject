using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class P_FinancialStep : BaseModel
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

        private DateTime _processedDate;

        public DateTime ProcessedDate
        {
            get { return _processedDate; }
            set { _processedDate = value; }
        }

        private int _StepStatus;

        public int StepStatus
        {
            get { return _StepStatus; }
            set { _StepStatus = value; }
        }

        public override string Table { get { return "P_FinancialStep"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_P_FinancialStep_InsertOrUpdate"; } }
    }

    public enum P_FinancialStepColumns
    {
        ID,
        F_TransactionID,
        Step,
        ProcessedDate,
        StepStatus,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum P_FinancialStepProcedure
    {
        p_P_FinancialStep_GetByTransactionID,
        p_P_FinancialStep_GetByB_AccessID_ForReactivate,
        p_P_FinancialStep_GetListForDeleting,
        p_P_FinancialStep_GetList_ForCreateTask, 
        p_P_FinancialStep_GetByF_TransactionID,
        p_P_FinancialStep_GetByF_TransactionID_ForReactivate,
    }

    public class P_FinancialStepList : List<P_FinancialStep>
    {
    }
}