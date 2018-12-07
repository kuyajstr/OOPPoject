using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    class Product
    {
        public string Name;
        public string Description;
        public decimal Price;
        public string Manufacturer;
        public int Items;
        public decimal MonthlyInterestRate;


        public void DeductItems(int items = 0)
        {
            if (items != 0)
                Items = Items - items;
            else
                Items--;
        }


    }

}

