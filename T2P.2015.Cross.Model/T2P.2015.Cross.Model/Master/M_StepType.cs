using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_StepType : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _stepCategory;
        public string StepCategory
        {
            get { return _stepCategory; }
            set { _stepCategory = value; }
        }
        private string _stepCode;
        public string StepCode
        {
            get { return _stepCode; }
            set { _stepCode = value; }
        }
        private string _stepName;
        public string StepName
        {
            get { return _stepName; }
            set { _stepName = value; }
        }
        private float? _order;
        public float? Order
        {
            get { return _order; }
            set { _order = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private bool? _isShow;
        public bool? IsShow
        {
            get { return _isShow; }
            set { _isShow = value; }
        }
        public override string Table { get { return "M_StepType"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_StepType_InsertOrUpdate"; } }
    }
    public enum M_StepTypeColumns
    {
        ID,
        StepCategory,
        StepCode,
        StepName,
        Order,
        Description,
        IsShow,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }


    public enum M_StepTypeProcedure
    {
        p_M_StepType_ByProcessID,
        P_M_StepType_GetListClassifyByOption,
        p_M_StepType_GetStepForExceptionHandling,
        p_M_StepType_GetByCompanyProcess,
        p_M_StepType_GetByProcess,
        p_M_StepType_GetList_ByCompanyID,
    }

    public class M_StepTypeList : List<M_StepType>
    {
    }
}