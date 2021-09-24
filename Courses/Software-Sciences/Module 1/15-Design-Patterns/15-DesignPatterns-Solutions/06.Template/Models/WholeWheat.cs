using System;
using System.Collections.Generic;
using System.Text;

namespace _3._Template.Models
{
    public class WholeWheat : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Baking the Whole Wheat Bread. (15 minutes)");
        }

        public override void MixIngredients()
        {
            Console.WriteLine("Gathering Ingredients for 1Whole Wheat Bread.");
        }
    }
}
