using System;
using VehicleInfo;

namespace MotorBikeInfo
{
    public class Motorbike : Vehicle
    {
       public Motorbike()
        {
            Console.WriteLine("MotorBike Object");
        }
        public override void status()
        {
            base.status();
            Console.WriteLine("Active MotorBike Status On\n");
        }
    }
}
