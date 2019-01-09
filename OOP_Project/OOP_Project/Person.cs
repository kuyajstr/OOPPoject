using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public class Person
    {
        public string FirstName;
        public string MiddleName;
        public string LastName;
        public string BirthDate;
        public string Address;

        public Person(string firstName, string lastName, string middleName = "")
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public string GetFullName()
        {
            if (MiddleName == "")
                MiddleName = "";
            else
                MiddleName = MiddleName.First().ToString().ToUpper() + ". ";

            string[] separatedFirstName = FirstName.Split(' ');
            string capitalizedFirstName = "";

            if (FirstName.Contains(" "))
            {
                for (int i = 0; i < separatedFirstName.Length; i++)
                {
                    separatedFirstName[i] = (char.ToUpper((separatedFirstName[i][0]))) +
                        separatedFirstName[i].ToLower().Substring(1) + " ";
                    capitalizedFirstName += separatedFirstName[i];
                }
            }
            else capitalizedFirstName = FirstName.First().ToString().ToUpper() + FirstName.Substring(1).ToLower() + " ";

            string[] separatedLastName = LastName.Split(' ');
            string capitalizedLastName = "";

            if (LastName.Contains(' '))
            {
                for (int i = 0; i < separatedLastName.Length; i++)
                {
                    separatedLastName[i] = (char.ToUpper((separatedLastName[i][0]))) +
                        separatedLastName[i].ToLower().Substring(1) + " ";
                    capitalizedLastName += separatedLastName[i];
                }
            }
            else capitalizedLastName = LastName.First().ToString().ToUpper() + LastName.Substring(1).ToLower();


            return String.Format(capitalizedFirstName + MiddleName + capitalizedLastName);

        }

        public int GetAge()
        {
            return Calculation.CalculateAge(BirthDate);
        }

    }
}
