using System;
using VehicleInfo;

namespace TruckInfo
{
    class Truck: Vehicle
    {
        public Truck()
        {
            Console.WriteLine("Truck Object");
        }
        public override void status()
        {
            base.status();
            Console.WriteLine("Active Truck Status On\n");
        }
    }
}
