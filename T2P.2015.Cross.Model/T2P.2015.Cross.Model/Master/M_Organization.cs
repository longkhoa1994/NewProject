using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_Organization : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public override string Table { get { return "M_Organization"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_Organization_InsertOrUpdate"; } }
    }

    public enum M_OrganizationColumns
    {
        ID,
        Name,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_OrganizationProcedure
    {
        p_M_Organization_Get_ByCountry,
    }

    public class M_OrganizationList : List<M_Organization>
    {
    }
}