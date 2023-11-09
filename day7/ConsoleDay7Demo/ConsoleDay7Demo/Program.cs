using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay7Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1=new Student("Tom","male",20,98,92,88);
            stu1.Speak();
            stu1.ShowScore();

            Console.ReadKey();


            Student stu2=new Student("Jerry","male",25);

            {
                stu2.Python = 45;
                stu2.Ccna = 70;
                stu2.DataBase = 59;
                stu2.Speak();
                stu2.ShowScore();

                Console.ReadKey();

            }


            Student stu3=new Student("Bob");

            stu3.Age = 35;
            stu3.Gender = "male";
            stu3.Ccna = 98;
            stu3.Python = 100;
            stu3.DataBase = 100;

            stu3.ShowScore();
            stu3.Speak();

            Console.ReadKey();

        }
    }
}
