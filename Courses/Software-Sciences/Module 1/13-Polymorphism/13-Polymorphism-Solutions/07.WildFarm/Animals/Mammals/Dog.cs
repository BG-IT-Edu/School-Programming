using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals
{
    public class Dog : Mammal
    {
        private const double BaseWeightModifier = 0.40;
        private static HashSet<string> owlAllowedFoods = new HashSet<string>
        {
            nameof(Meat)
        };
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, owlAllowedFoods, BaseWeightModifier, livingRegion)
        {
        }

        public override string ProduceSound()
        {
            return "Woof";
        }
    }
}
