using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student x = new Student();

            x.Name = "Nate";
            x.Age = 18;
            DateTime birthDate = Convert.ToDateTime("25/3/2000");
            x.Birthdate = birthDate.Date;
            x.StudentId = "2201801275873";
            x.Course = "BS CpE";
            x.YearLevel = 1;

            PrintStudent(x.Name, x.Age, x.Birthdate, x.StudentId, x.Course, x.YearLevel);

            Console.ReadLine();

        }

        static void PrintStudent(string name, int age, DateTime birthDate, string studentId, string course, int yearlevel)
        {
            Console.Write("Name: {0}\n" +
                "Age: {1}\n" +
                "Birthdate: {2}\n" +
                "Student ID: {3}\n" +
                "Course: {4}\n" +
                "Year Level: {5}",
                name, age, birthDate, studentId, course, yearlevel);-

        }
    }

     


    abstract class Person
    {
        protected string name;
        protected DateTime birthdate;
        protected int age;

        public string Name
        {
            get => name;
            set { name = value; }
        }

        public DateTime Birthdate
        {
            get => birthdate;
            set { birthdate = value; }
        }

        public int Age
        {
            get => age;
            set { age = value; }
        }

        public virtual string[] GetDetails()
        {
            string[] details = { name, Convert.ToString(birthdate), Convert.ToString(age) };
            return details;
        }
    }

    class Student : Person
    {
        protected string studentId;
        protected string course;
        protected int yearLevel;

        public string StudentId
        {
            get => studentId;
            set { studentId = value; }
        }

        public string Course
        {
            get => course;
            set { course = value; }
        }

        public int YearLevel
        {
            get => yearLevel;
            set { yearLevel = value; }
        }

        public override string[] GetDetails()
        {
            string [] data = { studentId, name, Convert.ToString(birthdate),
                Convert.ToString(age), course, Convert.ToString(yearLevel) };
            return data;
        }
    }

    class Employee : Person
    {
        protected string employeeId;
        protected int tinId;
        protected int sssId;
        protected string position;

        public string EmployeeId
        {
            get => employeeId;
            set { employeeId = value; }
        }

        public int TINID
        {
            get => tinId;
            set { tinId = value; }
        }

        public int SSSID
        {
            get => sssId;
            set { sssId = value; }
        }

        public string Position
        {
            get => position;
            set { position = value; }
        }


        public override string[] GetDetails()
        {
            return new string[] { employeeId, name, Convert.ToString(birthdate), Convert.ToString(age),
                Convert.ToString(tinId), Convert.ToString(sssId), position };
        }
    }

    class Teacher : Employee

    {
        protected string status;
        protected string division;

        public string Status
        {
            get => status;
            set { status = value; }
        }

        public string Division
        {
            get => division;
            set { division = value; }
        }

        public override string[] GetDetails()
        {
            return new string[] { employeeId, name, Convert.ToString(birthdate),
                Convert.ToString(age), Convert.ToString(tinId), Convert.ToString(sssId),
                status };
        }
    }


}
