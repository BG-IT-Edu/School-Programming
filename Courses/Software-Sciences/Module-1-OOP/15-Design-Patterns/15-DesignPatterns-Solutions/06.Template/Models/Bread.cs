using System;
using System.Collections.Generic;
using System.Text;

namespace _3._Template.Models
{
    public abstract class Bread
    {
        public abstract void MixIngredients();

        public abstract void Bake();

        public virtual void Slice()
        {
            Console.WriteLine($"Slicing the {GetType().Name} bread!");
        }

        public void Make()
        {
            MixIngredients();
            Bake();
            Slice();
        }
    }
}
