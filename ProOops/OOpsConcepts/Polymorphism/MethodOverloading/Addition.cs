﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpsConcepts.Polymorphism.MethodOverloading
{
    internal class Addition
    {
        public void SumOfNumbers(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Sum:"+c);

        }
        public void SumOfNumbers(int a, int b, int d)
        {
            int c = a + b + d;
            Console.WriteLine("sum:" + c);
        }
        public void SumOfNumbers(float a, int b, int d)
        {
            float c = a + b + d;
            Console.WriteLine("sum:" + c);
        }
    }
}
