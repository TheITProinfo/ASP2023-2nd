using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDday5InsertSort
{
    class Program
    {
        static void Main(string[] args)
        {
            #region step by step example
            ////insert sorting

            //int[] arr = {15, 12, 11, 1};

            //   //First round 12,15 11 1  i=1

            //   int insetval = arr[1];
            //   int insertIndex = 1 - 1;

            //   while (insertIndex>=0&&insetval<arr[insertIndex])
            //   {

            //       arr[insertIndex + 1] = arr[insertIndex];
            //       insertIndex--;


            //   }

            //   arr[insertIndex + 1] = insetval;
            //   Console.WriteLine("the first round is");

            //   foreach (int items  in arr)
            //   {
            //       Console.WriteLine(items);

            //   }

            //   Console.ReadKey();

            //   // the 2nd round i=2 11 12 15 1

            //   int insertval2 = arr[2];
            //   int insertIndex2 = 2 - 1;

            //   while (insertIndex2 > 0 && insertval2 < arr[insertIndex2])
            //   {
            //       arr[insertIndex2 + 1] = arr[insertIndex2];
            //       insertIndex2--;

            //   }

            //   arr[insertIndex2 + 1] = insertval2;

            //   Console.WriteLine("the second round is");


            //   foreach (int items in arr)
            //   {
            //       Console.WriteLine(items);
            //   }

            //   Console.ReadKey();


            #endregion

            #region complete code

            int[] arr = {12, 11, 15, 1, 55,4,88,-50,-12};

            for (int i = 1; i <arr.Length; i++)
            {

                int insertval = arr[i];
                int inserIndex = i - 1;
                while (inserIndex >= 0 && insertval < arr[inserIndex])
                {

                    arr[inserIndex + 1] = arr[inserIndex];
                    inserIndex--;
                }  // end of while loop

                arr[inserIndex + 1] = insertval;


            } // end of for loop


            Console.WriteLine(" the insert sorting result is ");


            foreach (int items in arr)
            {
                Console.Write(items);
                Console.Write("\t");
            }

            Console.ReadKey();

            #endregion



        }
    }
}
