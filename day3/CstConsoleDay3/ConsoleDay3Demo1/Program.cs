using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay3Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
               DateTime  myDay=DateTime.Now;
               string strB1=string.Format("{0:D}", myDay);
               string strB2 = string.Format("{0:d}", myDay);
            
               Console.WriteLine(strB1);
               Console.WriteLine(strB2);


            Console.ReadKey();
            
        }
    }
}
