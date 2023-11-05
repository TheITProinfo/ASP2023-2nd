using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay3Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "";
            long startTime = DateTime.Now.Millisecond;
            for (int i = 0; i < 100000; i++)
            {
                str = str + i;
;            }

            long endTime = DateTime.Now.Millisecond;

            long runTime = endTime - startTime;

            Console.WriteLine("the program is running: {0}",runTime);


            StringBuilder strBuilder=new StringBuilder();

            startTime = DateTime.Now.Millisecond;
            for (int j = 0; j<10000; j++)
            {
                strBuilder.Append(j);
            }

            endTime = DateTime.Now.Millisecond;

            runTime = endTime - startTime;

            Console.WriteLine("the stringBuild is running {0}",runTime);

            Console.ReadKey();


        }
    }
}
