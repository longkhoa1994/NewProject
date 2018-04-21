using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Factory.Abtract;

namespace Factory
{
    public enum ATEmployType
    {
        Contract,
        Permanent,
    }

    public class AbstractEmployManagerFactory
    {
        public static AbtractEmployee GetEmployeeManager(EmployType empType)
        {
            switch (empType)
            {
                case EmployType.Contract:
                    return new AbstractContractEmployeeManger();
                case EmployType.Permanent:
                    return new AbstractPermanentEmployeeManager();
                default:
                    return null;
            }
        }
        
    }
}
