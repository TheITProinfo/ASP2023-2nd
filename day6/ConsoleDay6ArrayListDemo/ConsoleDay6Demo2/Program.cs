using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay6Demo2
{
    class Program
    {
        static void Main(string[] args)
        {

            Student stu1= new Student("Tom","999 Yong street");

            stu1.speak();
            Console.ReadKey();
            Student stu2=new Student("Herry","1022 Bayview st.");

            stu2.speak();

        }
    }
}
