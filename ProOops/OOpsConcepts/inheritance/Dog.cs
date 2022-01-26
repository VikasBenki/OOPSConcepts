using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpsConcepts.inheritance
{
    internal class Dog:Animal
    {
        string colour, size;
        public void display1()
        {
            Console.WriteLine("size{0}, colour{1}" , size, colour);
        }
    }
}
