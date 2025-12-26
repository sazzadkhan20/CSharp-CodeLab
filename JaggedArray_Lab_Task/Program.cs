using System;

namespace JaggedArray_Lab_Task
{
    class Program
    {
        const int N = 10000;
        static int deptno;
        static string[][][] studentGradeInfo = new string[N][][];
        static string[] departments = new string[N];
        static string[,] courses = new string[N, N];

        public static int grade_equivalent(string grade)
        {
            if (grade == "A+") return 90;
            else if (grade == "A") return 85;
            else if (grade == "B+") return 80;
            else if (grade == "B-") return 75;
            else if (grade == "C") return 70;
            else if (grade == "D+") return 65;
            else if (grade == "D") return 60;
            else if (grade == "D-") return 55;
            else return 50;
        }

        public static string equivalent_grade(float grade)
        {
            if (grade >= 90.0 && grade <= 100) return "A+";
            else if (grade >= 85.0 && grade < 90.0) return "A";
            else if (grade >= 80.0 && grade < 85.0) return "B+";
            else if (grade >= 75.0 && grade < 80.0) return "B-";
            else if (grade >= 70.0 && grade < 75.0) return "C";
            else if (grade >= 65.0 && grade < 70.0) return "D+";
            else if (grade >= 60.0 && grade < 65.0) return "D";
            else if (grade > 50.0 && grade < 60.0) return "D-";
            else return "F";
        }
        //Show Grade
        public static void show_grade()
        {
            for (int i = 0; i < deptno; i++)
            {
                Console.WriteLine("Department: " + departments[i]);
                for (int j = 0; j < studentGradeInfo[i].Length; j++)
                {
                    Console.WriteLine("Course: " + courses[i, j]);
                    Console.Write("Grades of all Students(Course - " + courses[i, j]+"): ");
                    for (int k = 0; k < studentGradeInfo[i][j].Length; k++)
                        Console.Write(studentGradeInfo[i][j][k] + "   ");
                    Console.WriteLine();
                }
                Console.WriteLine("\n");
            }
        }

        //Average Grade Each Course
        public static void average_grade_each_course()
        {
            for (int i = 0; i < deptno; i++)
            {
                Console.WriteLine("Department: "+ departments[i]);
                for (int j = 0; j < studentGradeInfo[i].Length; j++)
                {
                    Console.Write("Average Grade of Course " + courses[i,j]+": ");
                    float averageGrade = 0;
                    for (int k = 0; k < studentGradeInfo[i][j].Length; k++)
                        averageGrade += grade_equivalent(studentGradeInfo[i][j][k]);
                    averageGrade = averageGrade / studentGradeInfo[i][j].Length;
                    Console.WriteLine(equivalent_grade(averageGrade)+"\n");
                }
            }
        }
        //Highest Grade Each Department
        public static void highest_grade_each_department()
        {
            for (int i = 0; i < deptno; i++)
            {
                Console.Write(departments[i]+" Department Highest Grade is : ");
                string highestGrade = "F";
                for (int j = 0; j < studentGradeInfo[i].Length; j++)
                {
                    for (int k = 0; k < studentGradeInfo[i][j].Length; k++)
                    {
                        if (grade_equivalent(highestGrade) < grade_equivalent(studentGradeInfo[i][j][k]))
                            highestGrade = studentGradeInfo[i][j][k];
                    }
                }
                Console.WriteLine(highestGrade+"\n");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Input--------------------\nEnter the Departement numbers of AIUB: ");
            
            byte departmentsNumber = Byte.Parse(Console.ReadLine());
            deptno = departmentsNumber;

            //User input -- 1
            for(int i=0; i< departmentsNumber; i++)
            {
                Console.Write("Enter a Department Name : ");
                string dep = Console.ReadLine();
                departments[i] = dep;
                Console.Write("Enter " + dep + " Department Under all Courses Number: ");
                byte courseNum = Byte.Parse(Console.ReadLine());
                studentGradeInfo[i] = new string [courseNum][];
                for(int j=0; j<courseNum; j++)
                {
                    Console.Write("Enter a Course Name(Dept-"+dep+"): ");
                    string course = Console.ReadLine();
                    courses[i,j] = course;
                    Console.Write("Enter " + course + " Course Under all Students Number: ");
                    byte students = Byte.Parse(Console.ReadLine());
                    studentGradeInfo[i][j] = new string[students];
                    Console.Write("Enter Students grade of " + course + " course: ");
                    for (int k=0; k<students; k++)
                    {
                        string grade = Console.ReadLine();
                        studentGradeInfo[i][j][k] = grade;
                    }
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Output---------------------------\n");
            //Grade Show -- 2
            Console.WriteLine("Show Grade of all Students of all the Departments-----");
            show_grade();
            //Average Grade Each Course -- 3
            Console.WriteLine("Show Average Grade of Each Course in Each Departments------");
            average_grade_each_course();
            //Highest Grade Each Department -- 4
            Console.WriteLine("Show Highest Grade of Each Departments-------");
            highest_grade_each_department();
            Console.ReadKey();
        }
    }
}
