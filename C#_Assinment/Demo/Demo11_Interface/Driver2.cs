using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11_Interface
{
    class Driver2
    {
        public void Drive(Car objCar)
        {
            Console.WriteLine("Driver is driving a car");
            objCar.DriveCar();
        }

        public void Drive(Scooter objScooter)
        {
            Console.WriteLine("Driver is now driving a Scooter");
            objScooter.DriveScooter();
        }
    }
}
