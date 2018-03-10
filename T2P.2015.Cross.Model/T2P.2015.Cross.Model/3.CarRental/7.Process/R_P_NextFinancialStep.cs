using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_P_NextFinancialStep : BaseModel
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
        private DateTime _expectedTime;
        public DateTime ExpectedTime
        {
            get { return _expectedTime; }
            set { _expectedTime = value; }
        }
        private int _stepStatus;
        public int StepStatus
        {
            get { return _stepStatus; }
            set { _stepStatus = value; }
        }
        public override string Table { get { return "R_P_NextFinancialStep"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_P_NextFinancialStep_InsertOrUpdate"; } }
    }
    public enum R_P_NextFinancialStepColumns
    {
        ID,
        R_F_TransactionID,
        Step,
        ExpectedTime,
        StepStatus,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum R_P_NextFinancialStepProcedure
    {
        p_R_P_NextInvoiceStep_GetByTransactionID,
        p_R_P_NextFinancialStep_Get_Current_Items,
        p_R_P_NextFinancialStep_GetByAccessID,
        p_R_P_NextFinancialStep_Update_Status,
        
    }
    public class R_P_NextFinancialStepList : List<R_P_NextFinancialStep>
    {

    }
}