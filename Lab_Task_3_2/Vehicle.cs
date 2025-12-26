using System;

namespace VehicleInfo
{
    public class Vehicle
    {
        private string vehicleName;
        private string vehicleId;
        public int vehicleCount;

        public Vehicle()
        {
            Console.WriteLine("Vechile Object");
            vehicleCount++;
        }
        public string VehicleName
        {
            get { return vehicleName; }
            set { vehicleName = value; }
        }
        public string VehicleId 
        {   get {return vehicleId; }
            set {vehicleId = value; } 
        }
        public virtual void status()
        {
            Console.WriteLine("Active Vehicle Status On\n");
        }
        public void showInfo()
        {
            Console.WriteLine("Vehicle Information--------");
            Console.Write("Vehicle Name: " + this.vehicleName + "\nVehicle Id: " + this.vehicleId);
            Console.WriteLine("Total Vehicle In Road: " + vehicleCount);
        }
    }
}
