using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class P_NextInvoiceStep : BaseModel
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
        private string _SettingType;

        public string SettingType
        {
            get { return _SettingType; }
            set { _SettingType = value; }
        }

        public override string Table { get { return "P_NextInvoiceStep"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_P_NextInvoiceStep_InsertOrUpdate"; } }
    }

    public enum P_NextInvoiceStepColumns
    {
        ID,
        I_ImageID,
        Step,
        ExpectedTime,
        StepStatus,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum P_NextInvoiceStepProcedure
    {
        p_P_NextInvoiceStep_GetByImageID, 
        p_P_NextInvoiceStep_GetInfoForRejectionLetter,
        p_P_NextInvoiceStep_GetByStepCodeReady,
        p_P_NextInvoiceStep_Update_Status,
        p_P_NextInvoiceStep_GetListForDelivery,
        p_P_NextInvoiceStep_GetListForDeliveryImage,
        p_P_NextInvoiceStep_GetByB_AccessID,
        p_P_NextInvoiceStep_GetForNextStep,
        p_P_NextInvoiceStep_GetListByListImageID,
        p_P_NextInvoiceStep_GetListMatchFIN,
        p_P_NextInvoiceStep_GetInvoiceGateway,
        p_P_NextInvoiceStep_GetListForDeleting,
        p_P_NextInvoiceStep_GetList_ForCreateTask,
        p_P_NextInvoiceStep_GetForLockingCapture,
        p_P_NextInvoiceStep_GetForUnLockingCapture,
        p_P_NextInvoiceStep_GetByTypingManual,
        p_P_NextInvoiceStep_GetForCheckTypingInvoice,
        p_R_P_NextInvoiceStep_GetByTypingManual,
        p_P_NextInvoiceStep_GetListForSentRequestDBI,
        p_P_NextInvoiceStep_GetBy_ImageIds,
        p_P_NextInvoiceStep_GetStepForUnlocking,
        p_P_Unlock_InvoiceProcessLockedTooLong, 
        p_P_NextInvoiceStep_GetByStepStatusImageID,
        p_P_NextInvoiceStep_GetListForDeliveryImage_ByCompany,
        p_P_NextInvoiceStep_GetListForDeliveryCSV_ByCompany,
        p_P_NextInvoiceStep_GetStepByUserID,
        p_P_NextInvoiceStep_LockCorrection

    }

    public class P_NextInvoiceStepList : List<P_NextInvoiceStep>
    {

    }
}