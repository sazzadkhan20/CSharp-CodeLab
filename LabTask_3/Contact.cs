using System;

namespace ContactInnfo
{
    class Contact
    {
        private string personName;
        private string personID;
        private int age;
        private string mobileNumber;
        private char gender;

        public Contact() { }
        public Contact(string personName,string personID,int age,string mobileNumber,char gender)
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
            Console.WriteLine("Person Name: " + personName + "\nPerson ID: " + personID + "\nPerson Age: " + age + "\nPerson Mobile Number: " + mobileNumber + "\nPerson Gender : " + checkMaleFemale+"\n");
        }
        public void detectMobileOperator()
        {
            string mobile = this.MobileNumber;
            if (mobile != null && mobile[2] == '7' || mobile[2] == '3') Console.WriteLine("Grameenphone Operator\n");
            else if (mobile != null && mobile[2] == '9' || mobile[2] == '4') Console.WriteLine("Banglalink Operator\n");
            else if (mobile != null && mobile[2] == '8') Console.WriteLine("Robi Operator\n");
            else if (mobile != null && mobile[2] == '6') Console.WriteLine("Airtel Operator\n");
            else if (mobile != null && mobile[2] == '5') Console.WriteLine("Teletok  Operator\n");
            else Console.WriteLine("Invalid Mobile Number\n");
        }
    }
}
