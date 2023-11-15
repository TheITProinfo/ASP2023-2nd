using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay8Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liskov substitute principle.
            //// object parameter with child string
            //string str =string.Join("+",new string[] { "A","B","C","D","e"});
            //Console.WriteLine(str);

            //Console.ReadKey();


            // example 2.
            // 

            // Student stu1=new Student();


            Pseron myPseron =new Student();
            Student stu1 = myPseron as Student;
            stu1.StudentSpeak();

            Console.ReadKey();


        }
    }
}
