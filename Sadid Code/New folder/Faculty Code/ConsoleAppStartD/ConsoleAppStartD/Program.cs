using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStartD
{
    struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void PrintPoint()
        {
            Console.WriteLine("({0},{1})", this.x, this.y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1;
            p1.x = 3; //Convert.ToInt32(Console.ReadLine());//3;
            p1.y = 5; //Convert.ToInt32(Console.ReadLine());
            p1.PrintPoint();//Console.WriteLine("({0},{1})", p1.x, p1.y);

            Point p2 = p1;
            p2.x++;
            p2.y--;
            p1.PrintPoint(); //Console.WriteLine("({0},{1})", p1.x, p1.y);
            p2.PrintPoint(); //Console.WriteLine("({0},{1})", p2.x, p2.y);

            Point p3 = new Point();
            p3.x = -90;
            p3.y = 120;
            p3.PrintPoint();

            Point p4 = new Point(5, -8);
            p4.PrintPoint();

            //Console.Write("Welcome to Fall Semester\n\n");
            //Console.WriteLine("Welcome to C#\n");

            //int a = 10, b = 20, c = 30;
            //string m = "hello";
            ////printf("%d%d", a, b);
            //Console.WriteLine("a:{0},b:{1},c:{2}", a, b, c);
            ////Console.WriteLine("{0}", b);
            //Console.WriteLine("a:" + a + ",b:" + b + ",c:" + c);
            //Console.WriteLine($"a:{a},b:{b},c:{c}");

            //Console.Write("Input1:");
            //string s1 = Console.ReadLine();
            //Console.WriteLine("Output1:{0}", s1);

            ////string s2 = Console.ReadLine();
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Output2:{0}", ++n1);

            //int n2 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Output2:{0}", n2);

            //type_name var_name [=init];
            //int ax = 10;
            //ax = 10;
            //ax++;

            //float b = 3.4f;
            //double c = 2.7;
            //decimal d = 9.8m;
            //bool e = false;

            //byte w = 14;
            //short q = w;
            //int e = 256;
            //w = (byte)e;
            //Console.Write(w);
        }
    }
}
