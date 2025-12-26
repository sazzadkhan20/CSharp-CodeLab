using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssessment
{
    class Bike : Vehicle,IDrivable,IRefuelable
    {
        private bool drive, refuel;
        private int experience;
        public Bike(string modelName,bool drive,bool refuel,int experience) : base(modelName)
        {
            this.drive = drive;
            this.refuel = refuel;
        }
        public bool drivable()
        {
            if (this.drive) return true;
            else return false;
        }
        public bool refuelable()
        {
            if (this.refuel) return true;
            else return false;
        }
        public override void display()
        {
            Console.WriteLine("Bike Information------");
            Console.WriteLine("Bike Model Name: "+this.ModelName);
            if (this.drivable())
                Console.WriteLine("This Bike is Drivable");
            else
                Console.WriteLine("This Bike is not Drivable");
            if (this.refuelable())
                Console.WriteLine("This Bike is Refuelable");
            else
                Console.WriteLine("This Bike is not Refuelable");
            if (experience >= 1 && experience < 10) Console.WriteLine(this.ModelName + " This Bike Experience is not much Good");
            else if (experience > 10 && experience < 20) Console.WriteLine(this.ModelName + " This Bike Experience is Good");
            else if (experience >= 20 && experience < 50) Console.WriteLine(this.ModelName + " This Bike Experience is so much Good\n\n");
            else Console.WriteLine(this.ModelName + " This Bike Experience is Awsome");
            Console.WriteLine("\n");
        }
    }
}
