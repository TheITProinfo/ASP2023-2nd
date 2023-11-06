using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosoleDay4Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {

                for (int j = 1; j <=i; j++)
                {
                    
                    Console.Write("{0}*{1}={2}\t",i,j,i*j);

                }

                Console.WriteLine();


            }

            Console.ReadKey();


        }
    }
}
