using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Demo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the year");

            string strYear = Console.ReadLine();

            int myYear = Int32.Parse(strYear);

            bool isLeapYear = ((myYear % 400) == 0) || (((myYear % 4) == 0) && ((myYear % 100) != 0));
            //bool isLeapYear = (myYear % 400 == 0);
            //bool isLeapYear = (myYear % 4 == 0) && (myYear % 100 != 0);


            string  yesNo=isLeapYear ? "it is Leap year" : "it is not leap year";

            Console.WriteLine("the year you input {0}:{1}",strYear,yesNo);

            Console.ReadKey();


        }
    }
}
