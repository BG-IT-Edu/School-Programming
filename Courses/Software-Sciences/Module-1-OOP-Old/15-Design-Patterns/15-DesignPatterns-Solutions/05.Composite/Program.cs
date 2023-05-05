using _2._Composite.Models;
using System;

namespace _2._Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var phone = new SingleGift("Phone", 256);
            phone.CalculateTotalPrice();
            Console.WriteLine();

            var rootbox = new CompositeGift("RootBox", 0);
            var truckToy = new SingleGift("TruckToy", 289);
            var plainToy = new SingleGift("PlainToy", 587);

            rootbox.Add(truckToy);
            rootbox.Add(plainToy);

            var childBox = new CompositeGift("ChildBox", 0);
            var soldierToy = new SingleGift("SoldierToy", 200);

            childBox.Add(soldierToy);
            rootbox.Add(childBox);

            Console.WriteLine($"Total price of this composite present is: {rootbox.CalculateTotalPrice()}");
        }
    }
}
