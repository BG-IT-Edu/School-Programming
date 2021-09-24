using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals
{
    public class Tiger : Feline
    {
        private const double BaseWeightModifier = 1.00;
        private static HashSet<string> owlAllowedFoods = new HashSet<string>
        {
            nameof(Meat)
        };
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, owlAllowedFoods, BaseWeightModifier, livingRegion, breed)
        {
        }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
