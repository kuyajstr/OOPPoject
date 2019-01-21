using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @try
{
    class Coffee
    {
        protected string mainIngredient = "Ground up cofee Beans";
        protected string water = "water";

        public Coffee(int cups)
        {
            for (int x = 0; x <= cups; x++)
                Serve();
        }

        public string Water
        {
            get {return water;}
            set
            {
                if (value == "hot" || value == "cold")
                water = value;
            }
        }

        public virtual string[] Serve()
        {
            string[] ingredients = { mainIngredient, water };
            return ingredients;
        }
    }

    class Cappucino: Coffee
    {
        public Cappucino(int cups) : base(cups) { }

        public override string[] Serve()
        {
            string[] ingredients = { mainIngredient, water, "Steamed Milk", "Foamy Milk" };
            return ingredients;
        }

    }

    class Macchiato : Coffee
    {
        public Macchiato(int cups) : base(cups) { }

        public override string[] Serve()
        {
            string[] ingredients = { mainIngredient, water, "Foamy Milk" };
            return ingredients;
        }
    }

    class CafeLAtte : Coffee
    {
        public CafeLAtte(int cups) : base(cups) { }

        public override string[] Serve()
        {
            string[] ingredients = { mainIngredient, "Steamed Milk" };
            return ingredients;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
