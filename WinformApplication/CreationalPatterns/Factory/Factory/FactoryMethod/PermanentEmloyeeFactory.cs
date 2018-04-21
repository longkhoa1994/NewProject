using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.Factory.FactoryMethod
{
    public class PermanentEmloyeeFactory : BaseEmployeeFactory
    {
        public PermanentEmloyeeFactory(Employee emp) :base (emp)
        {
        
        }
        public override IEmployeeManager Create()
        {
            var manager = new PermanentEmployeeManager();
            _emp.HouseAllowance = manager.GetHouseAllowance();
            return manager;
        }
    }
}
