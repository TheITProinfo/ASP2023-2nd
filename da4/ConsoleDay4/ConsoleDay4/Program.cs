using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleDay4
{
    class Program
    {
        static void Main(string[] args)
        {

            string email = "eric@cstcollege.cloud";

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            Match match = regex.Match(email);
            if (match.Success)
            {

                Console.WriteLine("email:{0} is correct", email);

            }

            else
            {
                Console.WriteLine("email {0} is not correct", email);
            }


            Console.ReadKey();
        }
    }
}
