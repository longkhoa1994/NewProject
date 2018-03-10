using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class A_UserRole : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _a_UserProfileID;

        public long A_UserProfileID
        {
            get { return _a_UserProfileID; }
            set { _a_UserProfileID = value; }
        }

        private long _a_RoleID;

        public long A_RoleID
        {
            get { return _a_RoleID; }
            set { _a_RoleID = value; }
        }

        public override string Table { get { return "A_UserRole"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_A_UserRole_InsertOrUpdate"; } }
    }

    public enum A_UserRoleColumns
    {
        ID,
        A_UserProfileID,
        A_RoleID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum A_UserRoleProcedure
    {
        p_A_UserRole_GetList_ByRoleID,
        p_A_UserRole_GetByUserID,

    }

    public class A_UserRoleList : List<A_UserRole>
    {
    }
}