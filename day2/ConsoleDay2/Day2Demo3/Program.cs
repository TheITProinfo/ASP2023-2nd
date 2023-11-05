using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Demo3
{
    class Program
    { 
        static void Main(string[] args)
        {
            string stuName1 = "John";
            string stuName2 = stuName1;

            stuName2 = "Alice";

            Console.WriteLine("student Name 1 is {0}",stuName1);
            Console.WriteLine("student Name 2 is {0}",stuName2);

            Console.ReadKey();


        }
    }
}
