using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpsConcepts.ClassOBject
{
    internal class Horse
    {
        public string breed, colour;
        public int age, size;
        public void sleep()
        {
            Console.WriteLine(" horse sleep");
        }
        public void run()
        {
            Console.WriteLine("Horse will run fast");
        }
    }
}
