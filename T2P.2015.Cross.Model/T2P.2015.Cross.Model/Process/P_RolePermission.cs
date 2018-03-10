using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_RolePermission
    {
        public string Message { get; set; }
        public A_Role Role { get; set; }
        public List<A_Function> ListA_Function { get; set; }
        public List<A_Function> ListA_Function_Basic { get; set; }
        public List<A_Function> ListA_Function_Addition { get; set; }
        public List<P_Object> ListP_Object { get; set; }
        public List<P_A_ObjectFunction> ListA_ObjectFunction { get; set; }

        public P_RolePermission()
        {
            Message = string.Empty;
            Role = new A_Role();
            ListA_Function = new List<A_Function>();
            ListA_Function_Basic = new List<A_Function>();
            ListA_Function_Addition = new List<A_Function>();
            ListP_Object = new List<P_Object>();
            ListA_ObjectFunction = new List<P_A_ObjectFunction>();
        }
    }

    public class P_A_ObjectFunction : A_ObjectFunction
    {
        private long _a_AssignedPermissionID;

        public long A_AssignedPermissionID
        {
            get { return _a_AssignedPermissionID; }
            set { _a_AssignedPermissionID = value; }
        }

        private bool _isDeleted;

        public bool IsDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        }
    }

}
