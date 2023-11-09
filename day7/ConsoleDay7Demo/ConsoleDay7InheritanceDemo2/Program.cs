using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay7InheritanceDemo2
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog firstDog=new Dog();

            firstDog.Name = "dog1";
            firstDog.Breed = "breed 1";

            firstDog.Bark();
            firstDog.Sleeping();


            Console.ReadKey();


        }
    }
}
