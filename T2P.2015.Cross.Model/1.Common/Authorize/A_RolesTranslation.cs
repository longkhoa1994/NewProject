using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class A_RolesTranslation : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _m_LanguageID;

        public long M_LanguageID
        {
            get { return _m_LanguageID; }
            set { _m_LanguageID = value; }
        }

        private long _a_RoleID;

        public long A_RoleID
        {
            get { return _a_RoleID; }
            set { _a_RoleID = value; }
        }

        private string _roleName;

        public string RoleName
        {
            get { return _roleName; }
            set { _roleName = value; }
        }

        public override string Table { get { return "A_RolesTranslation"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_A_RolesTranslation_InsertOrUpdate"; } }
    }

    public enum A_RolesTranslationColumns
    {
        ID,
        M_LanguageID,
        A_RoleID,
        RoleName,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum A_RolesTranslationProcedure
    {
        p_A_RolesTranslation_GetList_ByLanguageID,
    }

    public class A_RolesTranslationList : List<A_RolesTranslation>
    {
    }
}