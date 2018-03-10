using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_P_FinancialStep : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _r_F_TransactionID;

        public long R_F_TransactionID
        {
            get { return _r_F_TransactionID; }
            set { _r_F_TransactionID = value; }
        }

        private string _step;

        public string Step
        {
            get { return _step; }
            set { _step = value; }
        }

        private DateTime _processedDate;

        public DateTime ProcessedDate
        {
            get { return _processedDate; }
            set { _processedDate = value; }
        }

        private int _stepStatus;

        public int StepStatus
        {
            get { return _stepStatus; }
            set { _stepStatus = value; }
        }

        public override string Table { get { return "R_P_FinancialStep"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_P_FinancialStep_InsertOrUpdate"; } }
    }

    public enum R_P_FinancialStepColumns
    {
        ID,
        R_F_TransactionID,
        Step,
        ProcessedDate,
        StepStatus,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_P_FinancialStepProcedure
    {
        p_R_P_FinancialStep_GetByAccessID_ForReactivate,
        p_R_P_FinancialStep_Get_By_TransactionID,
    }

    public class R_P_FinancialStepList : List<R_P_FinancialStep>
    {
    }
}