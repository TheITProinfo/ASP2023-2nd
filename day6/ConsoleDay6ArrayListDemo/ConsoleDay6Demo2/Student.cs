using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay6Demo2
{
    class Student
    {
        private string _name;

        public string Name
        {
            get { return _name;
            }
            set { _name = value; }
        }

        private string _address;

        public string Address
        {
            get { return _address;}
            set { _address = value; }

        }

       // propfull
       

        // define constructors method

        public Student(string name, string address)    // constructors  with 2 parameters
        {
            this.Name = name;
            this.Address = address;

        }

        public void speak()
        {
            Console.WriteLine("my name is {0}, I am living {1}",this.Name,this.Address);
        }

    }
}
