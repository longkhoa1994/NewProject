using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class P_InvoiceStep : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _i_ImageID;

        public long I_ImageID
        {
            get { return _i_ImageID; }
            set { _i_ImageID = value; }
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
        private string _SettingType;

        public string SettingType
        {
            get { return _SettingType; }
            set { _SettingType = value; }
        }

        public override string Table { get { return "P_InvoiceStep"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_P_InvoiceStep_InsertOrUpdate"; } }
    }

    public enum P_InvoiceStepColumns
    {
        ID,
        I_ImageID,
        Step,
        ProcessedDate,
        StepStatus,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum P_InvoiceStepProcedure
    {
        p_P_InvoiceStep_GetByImageID,
        p_P_InvoiceStep_GetByB_AccessID_ForReactivate,
        p_P_InvoiceStep_GetListByListImageID,
        p_P_LockCorrection_Get_ByImageID,        
        p_P_InvoiceStep_GetByI_ImageID_ForReactiveExceptionalHandling,
        p_P_InvoiceStep_GetListForDeleting,
        p_P_InvoiceStep_GetList_ForCreateTask,
        p_P_InvoiceStep_GetInvoiceStepByAccess
    }

    public class P_InvoiceStepList : List<P_InvoiceStep>
    {
    }
}