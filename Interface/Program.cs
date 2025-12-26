using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IShape
    {
        double getArea();
    }
    class Rectangle:IShape
    {
        private double width, height;
       public Rectangle(double w,double h)
        {
            width = w;
            height = h;
        }
        public double getArea()
        {
            return this.width * this.height;
        }
    }
    class CalculateShape
    {
        public double calculateArea(IShape obj)
        {
            return obj.getArea();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(5, 10);
            CalculateShape  cs= new CalculateShape();
            double area = cs.calculateArea(r);
            Console.WriteLine("Area Of Rectangle is: " + area);
            Console.ReadLine();

        }
    }
}
