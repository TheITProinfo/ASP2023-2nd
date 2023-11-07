using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDday4Demo7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] days=new int[]{31,28,31,30,31,30,31,31,31,31,30,31};
            for (int i = 0; i < 12; i++)
            {

                Console.WriteLine("there are {0} days on this month {1}",days[i],i+1);


            }

            Console.ReadKey();
        }
    }
}
