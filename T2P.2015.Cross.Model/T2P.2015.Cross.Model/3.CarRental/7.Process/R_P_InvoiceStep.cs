using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_P_InvoiceStep : BaseModel
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

        private string _imageStatus;

        public string ImageStatus
        {
            get { return _imageStatus; }
            set { _imageStatus = value; }
        }

        public override string Table { get { return "R_P_InvoiceStep"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_P_InvoiceStep_InsertOrUpdate"; } }
    }

    public enum R_P_InvoiceStepColumns
    {
        ID,
        R_I_ImageID,
        Step,
        ProcessedDate,
        StepStatus,
        ImageStatus,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_P_InvoiceStepProcedure
    {
        p_R_P_InvoiceStep_GetByIDAndCode,
        p_R_P_InvoiceStep_GetByAccessID_ForReactivate,
        p_R_P_InvoiceStep_GetByAccessID,
        p_R_P_InvoiceStep_Get_By_ImageID,
    }

    public class R_P_InvoiceStepList : List<R_P_InvoiceStep>
    {
    }
}