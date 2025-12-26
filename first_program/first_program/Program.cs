/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_program
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.ReadLine();
            Console.WriteLine("Moye Moye");
            Console.ReadLine();
        }
    }
}
**/

using System;

public class StudentInfo
{
    public static void Main(string[] args)
    {
        int numberOfSemester;
        string name;
        string id;
        Console.WriteLine("Enter Your Name : ");
        name = Console.ReadLine();
        Console.WriteLine("Enter Your Id : ");
        id = Console.ReadLine();
        Console.WriteLine("Enter Your Current Semseter : ");
        numberOfSemester = int.Parse(Console.ReadLine());
        Console.WriteLine("Name : "+name+"\n\n");
        Console.WriteLine("Id - "+id);
        Console.WriteLine("Current Semester: "+numberOfSemester);
        Console.ReadLine();
    }
}

