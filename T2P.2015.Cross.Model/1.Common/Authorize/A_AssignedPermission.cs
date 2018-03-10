using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class A_AssignedPermission : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _a_RoleID;

        public long A_RoleID
        {
            get { return _a_RoleID; }
            set { _a_RoleID = value; }
        }

        private long _a_ObjectFunctionID;

        public long A_ObjectFunctionID
        {
            get { return _a_ObjectFunctionID; }
            set { _a_ObjectFunctionID = value; }
        }

        public override string Table { get { return "A_AssignedPermission"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_A_AssignedPermission_InsertOrUpdate"; } }
    }

    public enum A_AssignedPermissionColumns
    {
        ID,
        A_RoleID,
        A_ObjectFunctionID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum A_AssignedPermissionProcedure
    {
        p_A_AssignedPermission_GetList_ByRoleID,
    }

    public class A_AssignedPermissionList : List<A_AssignedPermission>
    {
    }
}