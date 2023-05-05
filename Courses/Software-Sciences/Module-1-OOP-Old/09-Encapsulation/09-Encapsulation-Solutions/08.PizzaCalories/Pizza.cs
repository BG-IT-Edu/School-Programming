using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
   public class Pizza
    {
        private const int MAX_LENGTH = 15;
        private const int MIN_LENGTH = 1;
        private const int MAX_TOPPING_COUNT = 10;
        private const int MIN_TOPPING_COUNT = 0;

        private string name;
        private Dough dough;
        private readonly List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.Length < MIN_LENGTH || value.Length > MAX_LENGTH || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public Dough Dough
        {
            get
            {
                return this.dough;
            }
            private set
            {
                this.dough = value;
            }
        }


        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count < MIN_TOPPING_COUNT || this.toppings.Count > MAX_TOPPING_COUNT)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            this.toppings.Add(topping);
        }

        public override string ToString()
        {
            double calories = this.Dough.CalculateCalories() + this.toppings.Sum(t => t.CalculateCalories());
            return $"{this.Name} - {calories:f2} Calories.";
        }
    }
}
