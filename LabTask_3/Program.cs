using System;
using ContactInnfo;
using CourseInfo;
using BookInfo;

namespace LabTask_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Course Object---
            Course course1 = new Course("Object Oriented Programming","CS0347",3);
            course1.showCourseInfo();

            //Book Object
            Book book1 = new Book("Computer Graphics","Jakob D. Paul","CG2017361de","Programming",3);
            book1.addBookCopy(5);
            Book book2 = new Book("Basic Algorithm", "Rafiqul Haque", "BA129392ph", "Programming", 10);
            book2.addBookCopy(12);
            book1.showInfo();
            book2.showInfo();
            Console.WriteLine("Total Number of Books Avaiable now in the Libaray: " + Book.bookCounter);

            //Contact Object
            Contact obj1 = new Contact();
            obj1.PersonName = "Md. Sazzad Khan";
            obj1.PersonID = "22-49172-3";
            obj1.Age = 23;
            obj1.MobileNumber = "01550030406";
            obj1.Gender = 'M';
            Console.WriteLine("Person's Information--------\nPerson Name: " + obj1.PersonName);
            Console.WriteLine("Person Id: " + obj1.PersonID);
            Console.WriteLine("Person Age: " + obj1.Age);
            Console.WriteLine("Person Mobile Number: " + obj1.MobileNumber);
            if (obj1.Gender == 'M') Console.WriteLine("Person Gender: Male");
            else Console.WriteLine("Person Gender: Female");
            obj1.detectMobileOperator();

            Console.ReadKey();

        }
    }
}
