using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value : " + x);
            double y = Double.Parse(Console.ReadLine());
            //Console.WriteLine(x + 3.5f); // Fraction By Default Double thake so just add f after number and convert Float
            int result = x + (int)y;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
