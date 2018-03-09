using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CompanyActor : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _m_CompanyProcessID;

        public long M_CompanyProcessID
        {
            get { return _m_CompanyProcessID; }
            set { _m_CompanyProcessID = value; }
        }

        public override string Table { get { return "M_CompanyActor"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_CompanyActor_InsertOrUpdate"; } }
    }

    public enum M_CompanyActorColumns
    {
        ID,
        M_CompanyProcessID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_CompanyActorProcedure
    {
    }

    public class M_CompanyActorList : List<M_CompanyActor>
    {
    }
}