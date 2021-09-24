using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals
{
    public class Mouse : Mammal
    {
        private const double BaseWeightModifier = 0.10;
        private static HashSet<string> owlAllowedFoods = new HashSet<string>
        {
            nameof(Vegetable),
            nameof(Fruit)
        };
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, owlAllowedFoods, BaseWeightModifier, livingRegion)
        {
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }
    }
}
