using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesPractice
{
    class Student
    {
        private string fullName;
        public string course;
        public string subject;
        public string university;
        public string email;
        public string phoneNumber;

        public string FullName //access private string and make information available to public object/method 
        {
            get
            {
                return this.fullName;
            }
            set
            {
                this.fullName = value.ToUpper(); //make full name uppercase because why not 
            }
        }


        public Student() //default
        {
            this.FullName = "undefined";
            this.course = "undefined";
            this.subject = "undefined";
            this.university = "undefined";
            this.email = "undefined";
            this.phoneNumber = "undefined";
        }

        public Student(string fullname)
        {
            this.FullName = fullname; 
        }

        public Student(string fullname, string course)
        {
            this.FullName = fullname;
            this.course = course; 
        }

        public Student(string fullname, string course, string subject)
        {
            this.FullName = fullname;
            this.course = course; 
        }

        //full constructor 
        public Student(string fullname, string course, string subject, string university, string email, string phoneNumber)
        {
            this.FullName = fullname;
            this.course = course;
            this.subject = subject;
            this.university = university;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        public void ShowSomeStudentData()
        {
            Console.WriteLine("{0}'s e-mail is {1}, and their phone number is {2}.", fullName, email, phoneNumber);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student("Tori Brenneison", "Software Development", "Same", "CSU", "tori.brenneison@gmail.com", "4402636913");
           // Console.WriteLine(a.email);

            Student b = new Student("Tom Feldman");

            a.ShowSomeStudentData();
        }
    }
}
