using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_AccessDetail : BaseModel
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

        private long _m_TravelerID;

        public long M_TravelerID
        {
            get { return _m_TravelerID; }
            set { _m_TravelerID = value; }
        }

        public override string Table { get { return "B_AccessDetail"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_B_AccessDetail_InsertOrUpdate"; } }
    }

    public enum B_AccessDetailColumns
    {
        ID,
        B_AccessID,
        M_TravelerID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_AccessDetailProcedure
    {
        p_B_AccessDetail_Get_By_B_AccessID,
        p_B_AccessDetail_GetListForDeleting,
    }

    public class B_AccessDetailList : List<B_AccessDetail>
    {
    }
}