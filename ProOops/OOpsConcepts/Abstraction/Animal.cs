using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpsConcepts.Abstraction
{
    abstract class Animal
    {
        public abstract void Animalsound();
        public void sleep()
        {
            Console.WriteLine("Non abstract method");
        }
    }
}
