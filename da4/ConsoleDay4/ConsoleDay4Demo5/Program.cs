using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay4Demo5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)


            {

                Console.Write("\n this is No.{0} loop",i+1);

                for (int j = 0; j <40; j++)
                {
                    
                    if(j%2==0)
                        continue;
                    Console.Write("j={0}",j);
                }
            }

            Console.ReadKey();

        }
    }
}
