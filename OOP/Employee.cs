using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Employee
    {

        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public decimal Salary { get; private set; }

        public Employee() { }


        public Employee(int empID, string name, decimal salary)
        { 
            EmployeeID= empID;
            EmployeeName= name;
            Salary= salary;
        }

        public void Introduce()
        {
            Console.WriteLine($"I am {EmployeeName} an Employee ID {EmployeeID}");
        }
    }
}
