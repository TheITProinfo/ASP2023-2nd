using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay7StaticMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog  firstDog=new Dog();

            // call non-static method object.method

            firstDog.M1();

            // call static method with class

            Dog.M2(); // static method
            

            Console.ReadKey();

        }
    }
}
