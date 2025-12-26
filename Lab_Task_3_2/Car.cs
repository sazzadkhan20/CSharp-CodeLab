using System;
using VehicleInfo;

namespace CarInfo
{
    class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car Object");
        }
        public override void status()
        {
            Console.WriteLine("Active Car Status On\n");
            base.status();
        }
    }
}
