using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals
{
    public abstract class Bird : Animal
    {
        protected Bird(string name, double weight, HashSet<string> allowedFoods, double weightModifier, double wingSize)
            : base(name, weight, allowedFoods, weightModifier)
        {
            WingSize = wingSize;
        }

        public double WingSize { get; private set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
