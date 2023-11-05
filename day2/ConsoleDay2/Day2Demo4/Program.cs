using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Demo4
{
    class Program
    {
        enum MyDate
        {
            Sun=0,
            Mon=1,
            Tue=2,
            Wed=3,
            Thu=4,
            Fri=5,
            Sat=6

        }
        static void Main(string[] args)
        {
            int myDay = (int)DateTime.Now.DayOfWeek;

            Console.WriteLine("myDay ={0}",myDay);



            switch(myDay)
            {
                case (int)MyDate.Sun: Console.WriteLine("today is Sunday");break;
                case (int)MyDate.Mon: Console.WriteLine("today is Monday"); break;
                case (int)MyDate.Tue: Console.WriteLine("today is Tuesday"); break;
                case (int)MyDate.Wed: Console.WriteLine("today is Wednesday"); break;
                case (int)MyDate.Thu: Console.WriteLine("today is Thursday"); break;
                case (int)MyDate.Fri: Console.WriteLine("today is Friday"); break;
                case (int)MyDate.Sat: Console.WriteLine("today is Saturday"); break;


            }

            Console.ReadKey();
        }
    }
}
