using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay8Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar=new Car();
            
            // call parent property

            myCar.Brand = "BMW";
            myCar.Color = "blue";
            // call this call property
            myCar.Mileage = 1000;

            // call parent method

            myCar.Run();
            
            //call this call method
            myCar.CarRun();

            Console.ReadKey();
            // 

            RaceCar myRaceCar=new RaceCar();

            // call from grand father class property
            myRaceCar.Color = "white";
            myRaceCar.Brand = "Honda";
            // call from father property
            myRaceCar.Mileage = 5000;

            myRaceCar.Run();
            myRaceCar.CarRun();

            Console.ReadKey();





        }
    }
}
