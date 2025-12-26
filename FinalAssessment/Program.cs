using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW X-17",true,false,25);
            Bike bike = new Bike("Yamaha R1",false,true,100);
            Bus bus = new Bus("Hanif", true, true, 15);
            car.display();
            bike.display();
            bus.display();
            Console.ReadKey();
        }
    }
}
