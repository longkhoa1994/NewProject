using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_Role
    {
        private long _roleID;

        public long RoleID
        {
            get { return _roleID; }
            set { _roleID = value; }
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

        private int _numberOfUsers;

        public int NumberOfUsers
        {
            get { return _numberOfUsers; }
            set { _numberOfUsers = value; }
        }

        private long _totalRecords;

        public long TotalRecords
        {
            get { return _totalRecords; }
            set { _totalRecords = value; }
        }
    }

    public enum P_Role_Procedure
    { 
        p_P_Role_GetList,
    }
}
