using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals
{
    public class Cat : Feline
    {
        private const double BaseWeightModifier = 0.30;
        private static HashSet<string> owlAllowedFoods = new HashSet<string>
        {
            nameof(Meat),
            nameof(Vegetable)
        };
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, owlAllowedFoods, BaseWeightModifier, livingRegion, breed)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
