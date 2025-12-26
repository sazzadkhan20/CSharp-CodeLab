using System;

namespace LabTask_3
{
        class Book
        {
            private string bookName;
            private string bookAuthor;
            private string bookId;
            private string bookType;
            private int bookCopy;
            public static int bookCounter = 0;
            public Book()
            {
                bookCounter++;
            }
            public Book(string bookName, string bookAuthor, string bookId, string bookType, int bookCopy)
            {
                this.bookName = bookName;
                this.bookAuthor = bookAuthor;
                this.bookId = bookId;
                this.bookType = bookType;
                this.bookCopy = bookCopy;
                bookCounter += bookCopy;
            }
            public string BookName { get; set; }
            public string BookAuthor { get; set; }
            public string BookId { get; set; }
            public string BookType { get; set; }
            public string BookCopy { get; set; }
            public void showInfo()
            {
                Console.WriteLine("Book All Information----------\n");
                Console.WriteLine("Book Name: " + bookName + "\nBook Author: " + bookAuthor + "\nBook Id: " + bookId + "\nBook Type: " + bookType + "\nBook Copy: " + bookCopy + "\n");
            }
            public void addBookCopy(int x)
            {
                bookCounter += x;
                this.bookCopy += x;
            }
        }
    class Course
    {
        private string courseName;
        private string courseCode;
        int courseCredit;
        public Course() { }
        public Course(string courseName, string courseCode, int courseCredit)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;
        }
        //Set get using Properties
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string CourseCredit { get; set; }
        public void showCourseInfo()
        {
            Console.WriteLine("Course All Information---------\n");
            Console.WriteLine("Course Name: " + courseName + "\nCourse Code : " + courseCode + "\nCourse Credit:" + courseCredit + "\n");
        }

    }
        class Contact
        {
            private string personName;
            private string personID;
            private int age;
            private string mobileNumber;
            private char gender;

            public Contact() { }
            public Contact(string personName, string personID, int age, string mobileNumber, char gender)
            {
                this.personName = personName;
                this.personID = personID;
                this.age = age;
                this.mobileNumber = mobileNumber;
                this.gender = gender;
            }
            public string PersonName { get; set; }
            public string PersonID { get; set; }
            public int Age { get; set; }
            public string MobileNumber { get; set; }
            public char Gender { get; set; }

            public void showPersonInfo()
            {
                string checkMaleFemale = "";
                if (this.gender == 'M') checkMaleFemale = "Male";
                else checkMaleFemale = "Female";
                Console.WriteLine("Person's All Information----------\n");
                Console.WriteLine("Person Name: " + personName + "\nPerson ID: " + personID + "\nPerson Age: " + age + "\nPerson Mobile Number: " + mobileNumber + "\nPerson Gender : " + checkMaleFemale + "\n");
            }
        public void detectMobileOperator()
        {
            string mobile = this.MobileNumber;
            if (mobile[2] == '7' || mobile[2] == '3') Console.WriteLine("Grameenphone Operator\n");
            else if (mobile[2] == '9' || mobile[2] == '4') Console.WriteLine("Banglalink Operator\n");
            else if (mobile[2] == '8') Console.WriteLine("Robi Operator\n");
            else if (mobile[2] == '6') Console.WriteLine("Airtel Operator\n");
            else if (mobile[2] == '5') Console.WriteLine("Teletok  Operator\n");
            else Console.WriteLine("Invalid Mobile Number\n");
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
             //Course Object---
             Course course1 = new Course("Object Oriented Programming", "CS0347", 3);
             course1.showCourseInfo();

             //Book Object
             Book book1 = new Book("Computer Graphics", "Jakob D. Paul", "CG2017361de", "Programming", 3);
             book1.addBookCopy(5);
             Book book2 = new Book("Basic Algorithm", "Rafiqul Haque", "BA129392ph", "Programming", 10);
             book2.addBookCopy(12);
             book1.showInfo();
             book2.showInfo();
             Console.WriteLine("Total Number of Books Avaiable now in the Libaray: " + Book.bookCounter+"\n");


            //Contact Object
            Contact obj1 = new Contact();
            obj1.PersonName = "Md. Sazzad Khan";
            obj1.PersonID = "22-49172-3";
            obj1.Age = 23;
            obj1.MobileNumber = "01550030406";
            obj1.Gender = 'M';
            Console.WriteLine("Person's Information--------\n\nPerson Name: " + obj1.PersonName);
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


