using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay8Inheritance
{
    public class Vehicle
    {

        #region field

        private string _Color;

        public string Color
        {
            get { return _Color; }
            set { _Color = value; }
        }

        private string _brand;

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        #endregion

        #region method

        public void Run()
        {

            Console.WriteLine("this car is {0} color,brand:{1}, I am running",this.Color,this.Brand);
        }


        #endregion

    }
}
