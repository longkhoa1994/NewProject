using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CountryOrganization : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _m_CountryID;

        public long M_CountryID
        {
            get { return _m_CountryID; }
            set { _m_CountryID = value; }
        }

        private long _m_OrganizationID;

        public long M_OrganizationID
        {
            get { return _m_OrganizationID; }
            set { _m_OrganizationID = value; }
        }

        public override string Table { get { return "M_CountryOrganization"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_CountryOrganization_InsertOrUpdate"; } }
    }

    public enum M_CountryOrganizationColumns
    {
        ID,
        M_CountryID,
        M_OrganizationID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_CountryOrganizationProcedure
    {
    }

    public class M_CountryOrganizationList : List<M_CountryOrganization>
    {
    }
}