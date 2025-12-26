using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter a Age: ");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.Write("Enetr Gender if Male use 'M' if female use 'F': ");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.Write("Enetr CGPA: ");
            float cgpa = float.Parse(Console.ReadLine());
            if (gender == 'M') Console.WriteLine("User is Male\n");
            else Console.WriteLine("User is Female\n");
            Console.ReadLine();
        }
    }
}
