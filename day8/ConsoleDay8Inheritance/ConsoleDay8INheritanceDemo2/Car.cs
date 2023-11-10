using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay8INheritanceDemo2
{
   public class Car:Vehicle
    {

        private int _mileAge;

        public int Mileage
        {
            get { return _mileAge; }
            set { _mileAge = value; }
        }

        // constructor
        public Car(string color,string brand, int mileage): base(color,brand)
        {
            this.Mileage = mileage;

        }

        public void CarRun()
        {

            Console.WriteLine("this car is running {0}", this.Mileage);

        }

        public void CarRun2()
        {
            this.Run();
        }
    }
}
