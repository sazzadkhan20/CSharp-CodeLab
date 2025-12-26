using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x value: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y value: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter z value: ");
            int z = Convert.ToInt32(Console.ReadLine());
            double result;
            result = (Math.Pow(1.0 * x, 3) + Math.Pow(1.0 * (z - 3), 2)) /(y + 2);
            Console.WriteLine("Result is : "+result);
            Console.ReadLine();
        }
    }
}
