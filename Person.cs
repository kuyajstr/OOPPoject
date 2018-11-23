using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    class Person
    {
        //fields
        public string FirstName;
        public string MiddleName;
        public string LastName;
        public DateTime Birthdate;
        public string Address;

        //constructor
        public Person(string firstName, string middleInitial, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleInitial;
            LastName = lastName;
        }

        //GetFullName method
        public string GetFullName(string firstName, string middleName, string lastName)
        {
            return "";
        }

        //GetAge method
        public int GetAge(DateTime birthDate)
        {
            return 0;
        }


    }
}
