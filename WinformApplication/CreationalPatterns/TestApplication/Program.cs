using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CreationalPatterns;
using CreationalPatterns.StaticClass;
using Factory;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //TemperatureConverter.FahrenheitToCelsius("abc");
            //IPizza iPizza = FactoryPatterns.CreatePizza(PizzaType.NewYork, new List<string>());
            var empInterface = EmployManagerFactory.GetEmployeeManager(EmployType.Contract);
            var employee = new Employee(1, "", empInterface.GetBonus(), empInterface.GetPay());
            var empAbstract = AbstractEmployManagerFactory.GetEmployeeManager(EmployType.Contract);
            var employeea = new Employee(1, "", empAbstract.GetBonus(), empAbstract.GetPay());
            AbstractContractEmployeeManger adf = new AbstractContractEmployeeManger();
            
        }
    }
}
