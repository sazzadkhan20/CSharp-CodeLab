using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.PrintProduct();
            
            Product product2 = new Product(222, 100.55, new DateFormat(20, "December", 2024));
            product2.PrintProduct();
        }
    }
}
