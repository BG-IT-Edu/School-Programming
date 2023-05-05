using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
   public interface IBuyer
    {
        public int Food { get; }

        void BuyFood();
    }
}
