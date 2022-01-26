using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpsConcepts.Arrays
{
    internal class ArraysMultiplication
    {
        public static void GetArrrayMultiplication()
        {
            Console.WriteLine(" enter the length of the arrays ");
            int i = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[i], array2 = new int[i], multiplication = new int[i];
            Console.WriteLine(" enter integer elements of first array ");
            for (i = 0; i <5; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("enter integer element of second array");
            for (i = 0; i <5; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("multiplication of two arrays");
            for (i = 0; i <5; i++)
            {
                multiplication[i] = array1[i] * array2[i];
                Console.WriteLine("{0}" , multiplication[i]);

            }


        }
        public static void GetArrayMultiplication2()
        {
            Console.WriteLine("please enter the array lenth ");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add the elements in single line by separating space");
            var stringArray = Console.ReadLine().Split(' ');
            var intArray = new int[n];
            for (var i = 0; i < n; i++)
            {
                intArray[i] = int.Parse(stringArray[i]); // line 17
            }
            Console.WriteLine("printing the array elements");

            for (int k = 0; k < n; k++)
            {
                Console.Write(" " + intArray[k]);
            }
        }
    }
}
