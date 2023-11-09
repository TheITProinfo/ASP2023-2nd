using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay5SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //selection sorting

            int[] arr={23,33,11,10,44,-55,-22};

            int min;

            for (int i = 0; i < arr.Length-1; i++)
            {

                min =i;

                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[j] < arr[min])
                    {
                        min = j;

                    }

                    int temp = arr[min];

                    arr[min] = arr[i];

                    arr[i] = temp;


                } // end of internal for loop




            } // end of external for loop

            Console.WriteLine("the selection sorting result is ");

            foreach (int items in arr)
            {


                Console.Write(items);
                Console.Write("\t");
            }

            Console.ReadKey();




        }
    }
}
