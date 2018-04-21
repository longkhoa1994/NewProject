using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    public class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string JobDescription { get; set; }

        public string Number { get; set; }

        public string Department { get; set; }

        public decimal HourlyPay { get; set; }

        public decimal Bonus { get; set; }

        public decimal HouseAllowance { get; set; }
        public int EmployeeID { get; set; }

        public Employee()
        { 
        
        }
        public Employee(int iD, string name,decimal bonus,decimal hourlyPay)
        {
            this.ID = iD;
            this.Name = name;
            this.Bonus = bonus;
            this.HourlyPay = hourlyPay;
        }
    }
}
