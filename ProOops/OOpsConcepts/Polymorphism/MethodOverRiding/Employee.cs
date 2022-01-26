using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpsConcepts.Polymorphism.MethodOverRiding
{
    internal class Employee
    {
        public string name;
        public double salary;
        public void EmployeeDetails()
        {
            Console.WriteLine("name:" + name);

        }
        public void Getsalary()
        {
            Console.WriteLine("salary:500");        }
    }
}
