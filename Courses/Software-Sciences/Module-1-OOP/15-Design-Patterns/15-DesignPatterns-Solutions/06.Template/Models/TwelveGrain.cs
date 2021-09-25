using System;
using System.Collections.Generic;
using System.Text;

namespace _3._Template.Models
{
    public class TwelveGrain : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Baking the 12-Grain Bread. (25 minutes)");
        }

        public override void MixIngredients()
        {
            Console.WriteLine("Gathering Ingredients for 12-Grain Bread.");
        }
    }
}
