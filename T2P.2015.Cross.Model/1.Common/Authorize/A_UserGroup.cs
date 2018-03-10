using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class A_UserGroup : BaseModel
    {
        private long _ID;

        public long ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private long _A_UserProfileID;

        public long A_UserProfileID
        {
            get { return _A_UserProfileID; }
            set { _A_UserProfileID = value; }
        }

        private long _A_GroupID;

        public long A_GroupID
        {
            get { return _A_GroupID; }
            set { _A_GroupID = value; }
        }
        
        public override string Table { get { return "A_UserGroup"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_A_UserGroup_InsertOrUpdate"; } }
    }

    public enum A_UserGroupProcedure
    {
        p_A_UserGroup_Get,
        p_GetListByA_UserProfileID
    }

    public class A_UserGroupList : List<A_UserGroup>
    {
    }
}
