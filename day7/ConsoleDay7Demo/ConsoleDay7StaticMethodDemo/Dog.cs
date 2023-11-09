using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay7StaticMethodDemo
{
    public class Dog

    {
        

        private string _name;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _breed;

        public string Breed
        {
            get { return _breed; }
            set { _breed = value; }
        }

        public void M1()
        {

            Console.WriteLine("this is non-static method");
        }

        public static void M2()
        {
            Console.WriteLine("this is static method");
        }



    }
}
