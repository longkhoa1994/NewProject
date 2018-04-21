using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Factory.Abtract;

namespace Factory
{
    public class AbstractPermanentEmployeeManager : AbtractEmployee
    {
        public override decimal GetBonus()
        {
            return 100;
        }
        public override decimal GetPay()
        {
            return 150;
        }
    }
}
