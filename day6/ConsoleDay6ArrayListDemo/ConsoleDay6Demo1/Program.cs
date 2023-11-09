using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay6Demo1
{
    class Program
    {
        static void Main(string[] args)
        {


            //Create new object from person class

            Person tom = new Person();

            tom.Name = "Tom";
            tom.Age = 28;
            tom.Gender = "male";

            tom.Speak();
            tom.Drive();

            Console.ReadKey();

            Person bob=new Person();

            bob.Name = "Bob";
            bob.Gender = "male";
            bob.Age = 29;

            bob.Speak();
            bob.Drive();

            Console.ReadKey();


            Person alice=new Person();

            alice.Gender = "I don't know";
            alice.Age = -10;
            alice.Name = "Alice";


            alice.Speak();
            alice.Drive();
            Console.ReadKey();

            Person jerry=new Person();

            jerry.Age = 45;
            jerry.Name = "Jerry";
            jerry.Gender = "male";


            jerry.Speak();
            jerry.Drive();

            Console.ReadKey();
        }

    }
}
