using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    public enum EmployType
    {
        Contract,
        Permanent,
    }

    public static class EmployManagerFactory
    {
        public static IEmployeeManager GetEmployeeManager(EmployType empType)
        {
            switch (empType)
            {
                case EmployType.Contract:
                    return new ContractEmployeeManger();
                case EmployType.Permanent:
                    return new PermanentEmployeeManager();
            }
            return null;
        }
        
    }
}
