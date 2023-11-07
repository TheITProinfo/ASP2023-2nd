using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay5BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConsoleDay5BubbleSort example

            int[] arr = {24, 11, 23, 50, 21, 2, 40,14};

            int n = arr.Length;
            int temp = 0;

            for (int i = 0; i <n-1; i++)
            {

                for (int j = 0; j < n-i-1; j++)
                {

                    if (arr[j] > arr[j + 1])
                    {

                        temp = arr[j];

                        arr[j] = arr[j + 1];

                        arr[j + 1] = temp;

                    } //end of if


                } //enf of internal loop

                
            } //end of external for

            foreach (int items in arr)
            {
                Console.WriteLine("the sorted array is {0}", items);
            }

            Console.ReadKey();

        }
    }
}
