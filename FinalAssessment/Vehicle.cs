using System;

namespace FinalAssessment
{
    abstract class Vehicle
    {
        public string ModelName { get; set; }
        public Vehicle(string modelName)
        {
            this.ModelName = modelName;
        }
        public abstract void display();
    }
}
