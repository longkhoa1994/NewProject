using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class P_NextBookingStep : BaseModel
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

        public override string Table { get { return "P_NextBookingStep"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_P_NextBookingStep_InsertOrUpdate"; } }
    }
    public class P_NextBookingStepExtend : P_NextBookingStep
    {
        private long _M_HotelID;

        public long M_HotelID
        {
            get { return _M_HotelID; }
            set { _M_HotelID = value; }
        }
        private long _M_CompanyID;

        public long M_CompanyID
        {
            get { return _M_CompanyID; }
            set { _M_CompanyID = value; }
        }
        private long _M_HotelPlatformID;

        public long M_HotelPlatformID
        {
            get { return _M_HotelPlatformID; }
            set { _M_HotelPlatformID = value; }
        }

        private long _M_ProcessID;

        public long M_ProcessID
        {
            get { return _M_ProcessID; }
            set { _M_ProcessID = value; }
        }
        private M_NotificationTemplate _M_NotificationTemplate;

        public M_NotificationTemplate M_NotificationTemplate
        {
            get { return _M_NotificationTemplate; }
            set { _M_NotificationTemplate = value; }
        }

        private P_BookingInfo_Email p_BookingInfo_Email;

        public P_BookingInfo_Email P_BookingInfo_Email
        {
            get { return p_BookingInfo_Email; }
            set { p_BookingInfo_Email = value; }
        }
        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
    }
    public enum P_NextBookingStepColumns
    {
        ID,
        B_AccessID,
        Step,
        ExpectedTime,
        StepStatus,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum P_NextBookingStepProcedure
    {
        p_P_NextBookingStep_GetInfoForRemindLetter,
        p_P_NextBookingStep_GetInfoForCollectionLetter,
        p_P_NextBookingStep_Update_Status,
        p_P_NextBookingStep_GetByB_AccessID,
        p_P_NextBookingStep_GetForNextStep,
        p_P_NextBookingStep_GetListForDeleting,
        p_P_NextBookingStep_GetList_ForCreateTask
    }

    public class P_NextBookingStepList : List<P_NextBookingStep>
    {
    }
}