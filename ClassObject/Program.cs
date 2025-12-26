using System;
using StudentInfo;


namespace ClassObject
{
    class Program
    {
        //Param 
        public static string fun(params string[] s)
        {
            return string.Join(",",s);
        }
    static void Main(string[] args)
        {
            Student s = new Student();
            s.Sid = 100;
            Console.WriteLine(s.Sid);
            s.Name = "Sazzad Khan";
            Console.WriteLine(s.Name);
            string s1 = fun("Hi", "Hello", "Thank you");
            Console.WriteLine(s1);
            Console.Read();
        }
    }
}
