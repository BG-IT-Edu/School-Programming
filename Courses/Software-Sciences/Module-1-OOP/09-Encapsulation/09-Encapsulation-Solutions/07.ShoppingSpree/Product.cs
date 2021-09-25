using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        private const int MIN_COST = 0;

        private string name;
        private decimal cost;
        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        public decimal Cost
        {
            get { return cost; }
            set
            {
                if (value < MIN_COST)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                cost = value;
            }
        }
    }
}
