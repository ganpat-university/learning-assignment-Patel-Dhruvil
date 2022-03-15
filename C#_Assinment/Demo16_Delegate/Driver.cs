using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo16_Delegate
{

    //without the method name 
    delegate void DriveHandler();

    class Driver
    {
        //Method receive the pointer
        public void Drive(DriveHandler objD)
        {
            Console.WriteLine("Driver is now driving the vehicle using the reference of the method to call!");

            if (objD != null)
            {
                objD();
            }
        }

    }
}
