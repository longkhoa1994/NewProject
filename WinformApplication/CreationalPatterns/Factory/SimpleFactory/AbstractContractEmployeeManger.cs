using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Factory.Abtract;

namespace Factory
{
    public class AbstractContractEmployeeManger : AbtractEmployee
    {
        public AbstractContractEmployeeManger()
            : base()
        { 
            
        }
        public override decimal GetBonus()
        {
            return 10;
        }
        public override decimal GetPay()
        {
            return 15;
        }

        public override decimal GetTotalWithVitual()
        {
            return 15;
        }
    }
}
