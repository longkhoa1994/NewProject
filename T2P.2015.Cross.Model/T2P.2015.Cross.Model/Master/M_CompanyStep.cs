using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CompanyStep : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _m_CompanyID;

        public long M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }

        private long _m_ProcessStepListID;

        public long M_ProcessStepListID
        {
            get { return _m_ProcessStepListID; }
            set { _m_ProcessStepListID = value; }
        }

        public override string Table { get { return "M_CompanyStep"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_CompanyStep_InsertOrUpdate"; } }
    }

    public enum M_CompanyStepColumns
    {
        ID,
        M_CompanyID,
        M_ProcessStepListID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_CompanyStepProcedure
    {
    }

    public class M_CompanyStepList : List<M_CompanyStep>
    {
    }
}