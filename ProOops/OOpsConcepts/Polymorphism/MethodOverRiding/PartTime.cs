using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpsConcepts.Polymorphism.MethodOverRiding
{
    internal class PartTime : Employee
    {
        public void GetSalary()
        {
            Console.WriteLine("salary:250");
        }
    }
}
