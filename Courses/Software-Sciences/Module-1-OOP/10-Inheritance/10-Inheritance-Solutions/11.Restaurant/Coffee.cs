using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double coffeeMilliliters = 50;
        private const decimal coffeePrice = 3.5m;
        public Coffee(string name, double coffeine)
            : base(name, coffeePrice, coffeeMilliliters)
        {
            this.Coffeine = coffeine;
        }
        public double Coffeine { get; set; }
    }
}
