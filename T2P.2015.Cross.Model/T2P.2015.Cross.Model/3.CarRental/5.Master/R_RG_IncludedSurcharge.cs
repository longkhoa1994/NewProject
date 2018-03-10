using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_RG_IncludedSurcharge : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _r_RG_RateGridDetailID;

        public long? R_RG_RateGridDetailID
        {
            get { return _r_RG_RateGridDetailID; }
            set { _r_RG_RateGridDetailID = value; }
        }

        private long? _m_SurchargeID;

        public long? M_SurchargeID
        {
            get { return _m_SurchargeID; }
            set { _m_SurchargeID = value; }
        }

        public override string Table { get { return "R_RG_IncludedSurcharge"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_RG_IncludedSurcharge_InsertOrUpdate"; } }
    }

    public enum R_RG_IncludedSurchargeColumns
    {
        ID,
        R_RG_RateGridDetailID,
        M_SurchargeID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_RG_IncludedSurchargeProcedure
    {
    }

    public class R_RG_IncludedSurchargeList : List<R_RG_IncludedSurcharge>
    {
    }
}