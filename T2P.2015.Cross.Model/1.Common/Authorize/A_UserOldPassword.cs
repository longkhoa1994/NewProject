using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class A_UserOldPassword : BaseModel
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
        private string _oldPassword;
        public string OldPassword
        {
            get { return _oldPassword; }
            set { _oldPassword = value; }
        }
        public override string Table { get { return "A_UserOldPassword"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_A_UserOldPassword_InsertOrUpdate"; } }
    }
    public enum A_UserOldPasswordColumns
    {
        ID,
        A_UserProfileID,
        OldPassword,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum A_UserOldPasswordProcedure
    {
        p_A_UserOldPassword_GetList_ByUserID
    }
    public class A_UserOldPasswordList : List<A_UserOldPassword>
    {

    }
}