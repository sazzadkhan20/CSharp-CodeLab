using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vehical
    {
        private int registrationNumber;
        private string colour;
        private string brand;
        private double price;

        public Vehical()
        {

        }
        public Vehical(int registrationNumber, string colour, string brand, double price)
        {
            this.SetRegistrationNumber(registrationNumber);
            this.SetColour(colour);
            this.SetBrand(brand);
            this.SetPrice(price);
        }
        public int GetRegistrationNumber()
        {
            return this.registrationNumber;
        }

        public void SetRegistrationNumber(int registrationNumber)
        {
            this.registrationNumber = registrationNumber;
        }

        public string GetColour()
        {
            return this.colour;
        }

        public void SetColour(string colour)
        {
            this.colour = colour;
        }

        public string GetBrand()
        {
            return this.brand;
        }

        public void SetBrand(string brand)
        {
            this.brand = brand;
        }

        public double GetPrice()
        {
            return this.price;
        }

        public void SetPrice(double price)
        {
            if (price > 0)
            {
                this.price = price;
            }
            else
            {
                this.price = -1;
            }
        }


        public void Print()
        {
            Console.WriteLine("Registration Number: {0}", this.GetRegistrationNumber());
            Console.WriteLine("Vheical Colour: {0}", this.GetColour());
            Console.WriteLine("Vheical Brand: {0}", this.GetBrand());
            Console.WriteLine("Vheical Price: {0} $ \n", this.GetPrice());

        }

    }
}
