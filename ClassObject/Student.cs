using System;

namespace StudentInfo
{
    class Student
    {

        private int sid;
        private string name;
        private float cgpa;
         public int Sid
        {
            get { return sid; } // readonly teh only get thakbe
            set { sid = value; } // writeonly teh only set thakbe
        }
        public string Name { get; set; }
    }
}
