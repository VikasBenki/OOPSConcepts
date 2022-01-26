using System;
using OOpsConcepts.Interface;
using OOpsConcepts.Abstraction;
using OOpsConcepts.Constructor;
using OOpsConcepts.Polymorphism.MethodOverloading;
using OOpsConcepts.Polymorphism.MethodOverRiding;
using OOpsConcepts.ClassOBject;
using OOpsConcepts.inheritance;
using OOpsConcepts.Encapsulation;
using OOpsConcepts.PassbyValueandReference;
using OOpsConcepts.Arrays;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpsConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dog dg = new Dog();
            dg.display();
            Tiger Roar = new Tiger();
            Roar.Animalsound();
            pig p = new pig();
            p.AnimalSound();
            p.Sleep();
            p.Details();*/
            /*Account Acc = new Account();
             Acc.setbalance(-1000);
             Acc.GetBalance();*/
            /*Rectangle Rec = new Rectangle();
            Rec.display();
            Rec.GetArea();
            Rec.RectangleDetails();
            Horse har = new Horse();
            har.sleep();
            har.run();*/
            /*ClassOBject.Dog1 pug = new ClassOBject.Dog1();
            pug.age = 10;
            pug.breed = "pug";
            pug.colour = "black";
            pug.size = 23;
            pug.sleep();
            Console.WriteLine("pug details:age;{0},size;{1},color:{2},breed:{3}", pug.age, pug.size, pug.colour, pug.breed);

            ClassOBject.Dog1 labrador = new ClassOBject.Dog1();
            labrador.age = 20;
            labrador.breed = "labrador";
            labrador.colour = "white";
            labrador.size = 23;
            labrador.sleep();

            Console.WriteLine("LABRADOR details:age;{0},size;{1},color:{2},breed:{3}", labrador.age, labrador.size, labrador.colour, labrador.breed);

            ClassOBject.Dog1 GSD = new ClassOBject.Dog1();
            GSD.age = 30;
            GSD.breed = "GSD";
            GSD.colour = "BLACK COATED";
            GSD.size = 23;
            GSD.sleep();
            Console.WriteLine("GSD details:age;{0},size;{1},color:{2},breed:{3}", GSD.age, GSD.size, GSD.colour, GSD.breed);*/

            /*Console.WriteLine("method overloading....");
            Addition add = new Addition();
            add.SumOfNumbers(10, 20, 30);
            PartTime part = new PartTime();
            part.GetSalary();*/

            /*Employee1 emp = new Employee1();

            Employee12 emp1 = new Employee12(420,"vikas",120000);
            emp1.Display();*/
           // PassbyValue. Test();

           // PassbyReference.TestReferenceType();

            //ArraysMultiplication.GetArrrayMultiplication();
            ArraysMultiplication.GetArrayMultiplication2();

            Console.ReadLine();
        }
    }
}
