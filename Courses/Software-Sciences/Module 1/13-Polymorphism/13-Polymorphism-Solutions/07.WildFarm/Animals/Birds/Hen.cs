using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals
{
    public class Hen : Bird
    {
        private const double BaseWeightModifier = 0.35;
        private static HashSet<string> owlAllowedFoods = new HashSet<string>
        {
            nameof(Meat),
            nameof(Fruit),
            nameof(Seeds),
            nameof(Vegetable)
            
        };
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, owlAllowedFoods, BaseWeightModifier, wingSize)
        {
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
