using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_P_NextInvoiceStep : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _r_I_ImageID;

        public long R_I_ImageID
        {
            get { return _r_I_ImageID; }
            set { _r_I_ImageID = value; }
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

        public override string Table { get { return "R_P_NextInvoiceStep"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_P_NextInvoiceStep_InsertOrUpdate"; } }
    }

    public enum R_P_NextInvoiceStepColumns
    {
        ID,
        R_I_ImageID,
        Step,
        ExpectedTime,
        StepStatus,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_P_NextInvoiceStepProcedure
    {
        p_R_P_NextInvoiceStep_GetByTypingManual,
        p_R_P_NextInvoiceStep_GetByImageId,
        p_R_P_NextInvoiceStep_Update_Status,
        p_R_P_NextInvoiceStep_GetForUnLockingCapture,
        p_R_P_NextInvoiceStep_GetForCheckTypingInvoice,
        p_R_P_NextInvoiceStep_Get_List_For_Claim_Email,
        p_R_P_NextInvoiceStep_Get_By_Step_ImageID,
        p_R_P_NextInvoiceStep_Get_ForCheckOutMail,
        p_R_P_NextInvoiceStep_GetByCorrection,
        p_R_P_NextInvoiceStep_GetForUnLockingCorrection,
        p_R_P_NextInvoiceStep_Get_List_For_Escalation_Email,
        p_R_P_NextInvoiceStep_GetByAccessID,
        p_R_P_NextInvoiceStep_Get_Claim_Email,
        p_R_P_NextInvoiceStep_Get_CollectionCredit_Email,
        p_R_InvoiceCapture_GetList_ForLoadNext,
        p_R_P_NextInvoiceStep_GetListForDeliveryImage,
        p_R_P_NextInvoiceStep_Get_ForSendApproval,
    }

    public class R_P_NextInvoiceStepList : List<R_P_NextInvoiceStep>
    {
    }
}