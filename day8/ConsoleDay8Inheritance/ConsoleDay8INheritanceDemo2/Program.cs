using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay8INheritanceDemo2
{
    class Program
    {
        static void Main(string[] args)
        {


            Car myCar = new Car("blue","BMW",2000);

            // call parent property

            //myCar.Brand = "BMW";
            //myCar.Color = "blue";
            // call this call property
            // myCar.Mileage = 1000;

            // call parent method

            myCar.CarRun2();

            //call this class  method
            myCar.CarRun();

            Console.ReadKey();
            // 

            //RaceCar myRaceCar = new RaceCar();

            //// call from grand father class property
            //myRaceCar.Color = "white";
            //myRaceCar.Brand = "Honda";
            //// call from father property
            //myRaceCar.Mileage = 5000;

            //myRaceCar.Run();
            //myRaceCar.CarRun();

            //Console.ReadKey();


        }
    }
}
