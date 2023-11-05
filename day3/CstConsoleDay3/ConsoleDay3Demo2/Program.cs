using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay3Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello CstCollege, Welcome";
            char[] separator = {','};
            String[] splitStrings=new string[120];
            splitStrings = str1.Split(separator);

            for (int i = 0; i < splitStrings.Length; i++)
            {


                Console.WriteLine("each member is {0}:{1}",i, splitStrings[i]);

            }

            Console.ReadKey();


        }
    }
}
