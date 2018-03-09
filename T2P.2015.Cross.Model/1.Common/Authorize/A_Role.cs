using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class A_Role : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _roleName;

        public string RoleName
        {
            get { return _roleName; }
            set { _roleName = value; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public override string Table { get { return "A_Role"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_A_Role_InsertOrUpdate"; } }
    }

    public enum A_RoleColumns
    {
        ID,
        RoleName,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum A_RoleProcedure
    {
        p_A_Role_Get_ByRoleName,
        p_A_Role_Get_ByUserID,
        p_A_Role_Get
    }

    public class A_RoleList : List<A_Role>
    {
    }
}