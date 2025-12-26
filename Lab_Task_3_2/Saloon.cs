using System;
using CarInfo;

namespace SaloonCarInfo
{
    class Saloon: Car
    {
        public Saloon()
        {
            Console.WriteLine("Saloon Car Object");
        }
        public override void status()
        {
            base.status();
            Console.WriteLine("Active Saloon Car Status On\n");
        }
    }
}
