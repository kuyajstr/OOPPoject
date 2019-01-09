using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace OOP_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //items
            Product Necklace = new Product();
            {
                Necklace.Name = "Necklace";
                Necklace.Description = "Gold";
                Necklace.Price = 5000;
                Necklace.Items = 3;
                Necklace.MonthlyInterestRate = 1.3m;
            }

            Product Earrings = new Product();
            {
                Earrings.Name = "Earring";
                Earrings.Description = "Gold";
                Earrings.Price = 1500;
                Earrings.Items = 5;
                Earrings.MonthlyInterestRate = 0.5m;
            }

            Product Ring = new Product();
            {
                Ring.Name = "Ring";
                Ring.Description = "Gold";
                Ring.Price = 2000;
                Ring.Items = 8;
                Ring.MonthlyInterestRate = 0.7m;
            }

            Product Bracelet = new Product();
            {
                Bracelet.Name = "Bracelet";
                Bracelet.Description = "Gold";
                Bracelet.Price = 3000;
                Bracelet.Items = 4;
                Bracelet.MonthlyInterestRate = 1;
            }


            //input
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Middle Name: ");
            string middleName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            Person Customer = new Person(firstName, lastName, middleName);

            Console.Write("Birthdate: ");
            Customer.BirthDate = Console.ReadLine();

            Console.Write("Address: ");
            Customer.Address = Console.ReadLine();

            Console.Write("Jewelry purchased: ");
            string product = Console.ReadLine();
            product = product.First().ToString().ToUpper() + product.Substring(1).ToLower();
            Console.Write("Number of Items purchased: ");
            int noOfItems = Convert.ToInt32(Console.ReadLine());

            Console.Write("Due Date: ");
            string dueDate = Console.ReadLine();

            Console.Clear();

            
            //output
            Console.WriteLine("Customer: {0}", Customer.GetFullName());
            Console.WriteLine("Birthdate: {0}", Customer.BirthDate);
            Console.WriteLine("Address: {0}", Customer.Address);
            Console.WriteLine("Jewelry: {0}", product);
            Console.WriteLine("Number of items purchased: {0}", noOfItems);

            //use switch for interest and accrued amount
            switch (product)
            {
                case "Necklace":
                    Console.WriteLine("Interest per Month: {0} pesos",
                         Calculation.CalculateInterest(Necklace.Price, Necklace.MonthlyInterestRate));
                    Console.WriteLine("Accrued Amount on Due Date: {0} pesos", Calculation.CalculateAccruedAmount
                        (Necklace.Price, Necklace.MonthlyInterestRate, dueDate));
                    break;

                case "Earrings":

                    Console.WriteLine("Interest per Month: {0} pesos",
                         Calculation.CalculateInterest(Earrings.Price, Earrings.MonthlyInterestRate));
                    Console.WriteLine("Accrued Amount on Due Date: {0} pesos", Calculation.CalculateAccruedAmount
                        (Earrings.Price, Earrings.MonthlyInterestRate, dueDate));
                    break;

                case "Ring":
                    Console.WriteLine("Interest per Month: {0} pesos",
                         Calculation.CalculateInterest(Ring.Price, Ring.MonthlyInterestRate));
                    Console.WriteLine("Accrued Amount on Due Date: {0} pesos", Calculation.CalculateAccruedAmount
                        (Ring.Price, Ring.MonthlyInterestRate, dueDate));
                    break;

                case "Bracelet":
                    Console.WriteLine("Interest per Month: {0} pesos",
                         Calculation.CalculateInterest(Bracelet.Price, Bracelet.MonthlyInterestRate));
                    Console.WriteLine("Accrued Amount on Due Date: {0} pesos", Calculation.CalculateAccruedAmount
                        (Bracelet.Price, Bracelet.MonthlyInterestRate, dueDate));
                    break;
            }

            Console.Read();

        }
    }
}