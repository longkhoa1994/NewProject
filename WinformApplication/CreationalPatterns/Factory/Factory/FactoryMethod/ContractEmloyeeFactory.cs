using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.Factory.FactoryMethod
{
    public class ContractEmloyeeFactory : BaseEmployeeFactory
    {
        public ContractEmloyeeFactory(Employee emp)
            : base(emp)
        {
        
        }
        public override IEmployeeManager Create()
        {
            var manager = new ContractEmployeeManger();
            _emp.HouseAllowance = manager.GetMedicalAllowance();
            return manager;
        }
    }
}
