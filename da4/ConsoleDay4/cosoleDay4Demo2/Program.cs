using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cosoleDay4Demo2
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1;i<=9; i++)
            {


                for (int j = 1; j <=9 ; j++)
                {

                    Console.Write("{0}*{1}={2}\t",i,j,i*j);

                }

                Console.WriteLine(); //new line




            }


            Console.ReadKey();


        }
    }
}
