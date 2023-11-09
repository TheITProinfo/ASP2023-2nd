using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay7InheritanceDemo2
{
    public class Animal
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

        public void Sleeping()
        {
            Console.WriteLine("I am sleeping");
        }



    }
}
