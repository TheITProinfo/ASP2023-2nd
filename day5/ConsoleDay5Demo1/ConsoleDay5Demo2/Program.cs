using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay5Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*foreach example*/

            #region for loop example
//int[] arr=new int[10]{10,20,30,40,50,60,70,80,90,100};

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("each member is {0}\t\n",arr[i]);
            //}
            

            #endregion

            //foreach example

            int[] arr=new int[10]{10,20,30,40,50,60,70,80,90,100};

            foreach (int items in arr)
            {

                Console.WriteLine("each member is \t{0}",items);
                

            }

            


            Console.ReadKey();


        }
    }
}
