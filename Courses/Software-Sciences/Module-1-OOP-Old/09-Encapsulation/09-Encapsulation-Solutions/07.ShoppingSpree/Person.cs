using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private const int MIN_MONEY = 0;
        private string name;
        private decimal money;
        private List<Product> products;
        public Person()
        {
            this.Products = new List<Product>();
        }

        public Person(string name, decimal money)
              : this()
        {
            this.Name = name;
            this.Money = money;
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

        public decimal Money
        {
            get { return money; }
            set
            {
                if (value < MIN_MONEY)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }


    }
}
