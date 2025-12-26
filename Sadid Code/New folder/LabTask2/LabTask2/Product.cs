using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask2
{
    struct DateFormat
    {
        private byte date;
        private string month;
        private int year;

        public DateFormat(byte date, string month, int year)
        {
            this.date = date;
            this.month = month;
            this.year = year;
        }

        public void PrintDateFormat()
        {
            Console.WriteLine("Date Format-");
            Console.WriteLine("Date  : {0}", this.date);
            Console.WriteLine("Month : {0}", this.month);
            Console.WriteLine("Year  : {0}", this.year);
        }
    }
    internal class Product
    {
        private int id;
        private double price;
        private DateFormat productionDate;

        public int Id
        {
            get { return this.id; }
            set { this.id = value;}
        }
        public double Price
        {
            get { return this.price; }
            set { this.price = value;}
        }
        public DateFormat Dateformat
        {
            get { return this.productionDate; }
            set { this.productionDate = value;}
        }

        public Product()
        {
            
        }

        public Product(int id, double price, DateFormat productionDate)
        {
            this.Id = id;
            this.Price = price;
            this.Dateformat = productionDate;
        }

        public void PrintProduct()
        {
            Console.WriteLine("Product Id    : {0}",this.Id);
            Console.WriteLine("Product Price : {0}$",this.Price);
            this.Dateformat.PrintDateFormat();
            Console.WriteLine("");

        }

    }
}
