using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClassD
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddressFormat a1 = new AddressFormat(12, 34, 7788, "Khulna");

            Student s1 = new Student();
            s1.Id = 100; //s1.SetId(100);//s1.id = 100;
            s1.Name = "Bruce"; //s1.SetName("Bruce");//s1.name = "Bruce";
            s1.Cgpa = 3.21; //s1.SetCgpa(3.21);//s1.cgpa = 3.21;
            s1.BloodGroup = "O+"; //s1.SetBloodGroup("O+");//s1.bloodGroup = "O+";
            s1.Address = new AddressFormat(12, 34, 7788, "Khulna");
            //s1.SetAddress(new AddressFormat(12, 34, 7788, "Khulna"));
            s1.PrintStudentInfo();


            Student s2 = new Student(200, "Clerk", -2.19, "AB+", new AddressFormat(22, 87, 4390, "Sylhet"));
            s2.PrintStudentInfo();

            //int[] ax = new int[5] { 23, 56, 22, 100, -87 };
            //ax[0] = 90;

            //for (byte c = 0; c < 5; c++)
            //{
            //    Console.Write("{0} ", ax[c]);
            //}
            //Console.WriteLine();

            //int d = 0;
            //while (d < ax.Length)
            //{
            //    Console.Write("{0} ", ax[d]);
            //    d++;
            //}
            //Console.WriteLine();

            //d = 0;
            //do
            //{
            //    Console.Write("{0} ", ax[d]);
            //    d++;
            //}
            //while (d < ax.Length);
            //Console.WriteLine();

            //foreach (int t in ax)
            //{
            //    Console.Write("{0} ", t);
            //}
            //Console.WriteLine();

            //int[,] bx = new int[4, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
            byte r = 0, c = 0;
            //while (r < 4)
            //{
            //    c = 0;
            //    while (c < 3)
            //    {
            //        Console.Write("{0} ", bx[r, c]);
            //        c++;
            //    }
            //    Console.WriteLine();
            //    r++;
            //}
            //Console.WriteLine();
            //foreach (int t in bx)
            //    Console.Write("{0} ", t);

            //Console.WriteLine();
            //Console.WriteLine();

            //int[,,,] q = new int[2, 3, 2, 4];

            int[][] jx = new int[4][];
            jx[0] = new int[3] { 1, 2, 3 };
            jx[1] = new int[2] { 4, 5 };
            jx[2] = new int[5] { 6, 7, 8, 9, 10 };
            jx[3] = new int[1] { 11 };

            r = 0;
            while (r < jx.Length)
            {
                c = 0;
                while (c < jx[r].Length)
                {
                    Console.Write("{0} ", jx[r][c]);
                    c++;
                }
                Console.WriteLine();
                r++;
            }
            Console.WriteLine();

            /*int date;
            string month;
            int year;

            Console.WriteLine("Enter date: ");
            date = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter month: " );
            month = Console.ReadLine();

            Console.WriteLine("Enter  year : ");
            year = Int32.Parse(Console.ReadLine());

            Console.WriteLine("{0} {1}, {2}", date, month, year);*/
        }
    }
}
