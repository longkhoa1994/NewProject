using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class P_BookingStep : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _b_AccessID;

        public long B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
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

        public override string Table { get { return "P_BookingStep"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_P_BookingStep_InsertOrUpdate"; } }
    }

    public enum P_BookingStepColumns
    {
        ID,
        B_AccessID,
        Step,
        ProcessedDate,
        StepStatus,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum P_BookingStepProcedure
    {
        p_P_BookingStep_GetByB_AccessID,
        p_P_BookingStep_GetAllHistory,
        p_P_BookingStep_GetByB_AccessID_ForReactivate,
        p_P_BookingStep_GetListForDeleting,
        p_P_BookingStep_GetList_ForCreateTask,
        p_P_BookingStep_GetByB_AccessID_WithoutStepStatus
    }

    public class P_BookingStepList : List<P_BookingStep>
    {
    }
}