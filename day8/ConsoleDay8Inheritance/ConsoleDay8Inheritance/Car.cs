using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay8Inheritance
{
    public class Car:Vehicle
    {
        private int _mileAge;

        public int Mileage
        {
            get { return _mileAge; }
            set { _mileAge = value; }
        }


        public void CarRun()
        {

            Console.WriteLine("this car is running {0}",this.Mileage);

        }


    }
}
