using System;
using VehicleInfo;
using CarInfo;
using MPVCarInfo;
using SaloonCarInfo;
using TruckInfo;
using MotorBikeInfo;

namespace Lab_Task_3_2
{
    class VehicleControlSystem
    {
        static void Main(string[] args)
        {
            Vehicle obj1 = new Motorbike();     
            Vehicle obj2 = new Saloon();
            Vehicle obj3 = new MPV();
            obj1.status();
            obj2.status();
            obj3.status();
            Console.ReadKey();
        }
    }
}
