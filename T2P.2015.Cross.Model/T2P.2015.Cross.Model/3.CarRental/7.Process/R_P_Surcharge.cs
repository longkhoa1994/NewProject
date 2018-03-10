using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    public class R_P_Surcharge
    {
        public R_RG_Surcharge Surcharge { get; set; }

        public List<R_RG_SurchargeCondition> ListCondition { get; set; }

        public R_P_Surcharge()
        {
            Surcharge = new R_RG_Surcharge();
            ListCondition = new List<R_RG_SurchargeCondition>();
        }
    }
}
