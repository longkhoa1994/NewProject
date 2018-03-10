using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_Object : A_Object
    {
        public long ParentID { get; set; }
        public string ParentName { get; set; }
        public int Level { get; set; }
    }

    public enum P_ObjectProcedure
    {
        p_P_Object_GetList,
    }
}
