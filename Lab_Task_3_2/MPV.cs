using System;
using CarInfo;

namespace MPVCarInfo
{
    class MPV : Car
    {
        public MPV()
        {
            Console.WriteLine("MPV Car Object");
        }
        public override void status()
        {
            base.status();
            Console.WriteLine("Active MPV Car Status On\n");
        }
    }
}
