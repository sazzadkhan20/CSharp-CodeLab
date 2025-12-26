using System;

namespace CourseInfo
{
    class Course
    {
        private string courseName;
        private string courseCode;
        int courseCredit;
        public Course() { }
        public Course(string courseName,string courseCode,int courseCredit)
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
            Console.WriteLine("Course All Information----------\n");
            Console.WriteLine("Course Name: " + courseName + "\nCourse Code : " + courseCode + "\nCourse Credit:" + courseCredit+"\n");
        }

    }
}
