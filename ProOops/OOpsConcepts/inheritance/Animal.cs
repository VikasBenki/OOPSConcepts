using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpsConcepts.inheritance
{
    internal class Animal
    {
        string colour= "brown", size = "big";
        public void display()
        {
            Console.WriteLine("colour {0} and size {1}", colour ,size);
        }
    }
}
