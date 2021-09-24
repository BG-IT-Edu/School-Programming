using System;

namespace _07.GolfEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double stickPrice = double.Parse(Console.ReadLine());
            int numOfSticks = int.Parse(Console.ReadLine());
            int numOfSets = int.Parse(Console.ReadLine());

            double setPrice = stickPrice * 1 / 6;
            double total = stickPrice * numOfSticks + numOfSets * setPrice;
            total += total * 0.2;
            double playerPayment = total * 1 / 8;
            double sponsorsPayment = total - playerPayment;

            Console.WriteLine($"Tony should pay {Math.Floor(playerPayment)}");
            Console.WriteLine($"Sponsors should pay {Math.Ceiling(sponsorsPayment)}");
        }
    }
}