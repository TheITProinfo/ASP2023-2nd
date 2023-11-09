using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay7InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle r1=new Rectangle();

            r1.Height = 20;
            r1.Width = 50;
            //r1.GetArea();

            Console.WriteLine("the rectangle area is {0}",r1.GetArea());
            // call class parent method
            // 

            r1.M1();


            Console.ReadKey();

        }
    }
}
