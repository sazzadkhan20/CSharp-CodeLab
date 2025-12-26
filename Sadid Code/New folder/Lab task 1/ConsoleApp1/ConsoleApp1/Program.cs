using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        internal class Program
        {
            static void Main(string[] args)
            {
                Vehical v1 = new Vehical(100, "Black", "BMW", 20000.50);
                v1.Print();

                Vehical v2 = new Vehical();
                v2.SetRegistrationNumber(200);
                v2.SetColour("Blue");
                v2.SetBrand("Honda");
                v2.SetPrice(3000.79);
                v2.Print();
            }
        }
}
