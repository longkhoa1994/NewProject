using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    public class PermanentEmployeeManager:IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 100;
        }
        public decimal GetPay()
        {
            return 150;
        }
        public decimal GetHouseAllowance()
        {
            return 130;
        }
    }
}
