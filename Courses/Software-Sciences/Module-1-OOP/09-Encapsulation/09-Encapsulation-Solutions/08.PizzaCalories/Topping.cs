using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const double MAX_WEIGHT = 50;
        private const double MIN_WEIGHT = 0;

        private const double meat = 1.2;
        private const double veggies = 0.8;
        private const double cheese = 1.1;
        private const double sauce = 0.9;

        private string name;
        private double weight;

        public Topping(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.name = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }

            private set
            {
                if (value < MIN_WEIGHT || value > MAX_WEIGHT)
                {
                    throw new ArgumentException($"{this.Name} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        public double CalculateCalories()
        {
            double calories = 0.0;

            if (this.Name.ToLower() == "meat")
            {
                calories = 2 * (this.weight * meat);
            }

            else if (this.Name.ToLower() == "veggies")
            {
                calories = 2 * (this.weight * veggies);
            }

            else if (this.Name.ToLower() == "cheese")
            {
                calories = 2 * (this.weight * cheese);
            }

            else if (this.Name.ToLower() == "sauce")
            {
                calories = 2 * (this.weight * sauce);
            }

            return calories;
        }
    }
}
