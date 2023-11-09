using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay6ArrayListDemo
{
    class Program
    {
       public static void Main(string[] args)
        { 
            //ArrayList  Example

            ArrayList List=new ArrayList();

            List.Add(10);
            List.Add("Boy");
            //int[] arr = {12, 22, 33, 55, 66};
            //List.Add(arr);
            Console.WriteLine("new list is {0}",List);

            Console.ReadKey();




        }
    }
}
