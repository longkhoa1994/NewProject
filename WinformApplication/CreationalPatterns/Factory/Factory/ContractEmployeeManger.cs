using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    public class ContractEmployeeManger:IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 10;
        }
        public decimal GetPay()
        {
            return 15;
        }
        public decimal GetMedicalAllowance()
        {
            return 100;
        }     
    }
}
