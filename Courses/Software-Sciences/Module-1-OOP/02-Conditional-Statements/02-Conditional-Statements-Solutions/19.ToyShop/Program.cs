using System;

namespace _19.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double costExcursion = double.Parse(Console.ReadLine());
            int numPuzzles = int.Parse(Console.ReadLine());
            int numDolls = int.Parse(Console.ReadLine());
            int numBears = int.Parse(Console.ReadLine());
            int numMinions = int.Parse(Console.ReadLine());
            int numTrucks = int.Parse(Console.ReadLine());

            int totalNum = numBears + numDolls + numMinions + numPuzzles + numTrucks;
            double totalSum = numBears * 4.1 + numDolls * 3 + numMinions * 8.2 + numPuzzles * 2.6 + numTrucks * 2;
            double finalSum = 0;
            if (totalNum >= 50)
            {
                finalSum = totalSum - totalSum * 0.25;
            }
            else
            {
                finalSum = totalSum;
            }

            double money = finalSum - finalSum * 0.1;
            double diff = Math.Abs(money - costExcursion);
            if (money >= costExcursion)
            {
                Console.WriteLine($"Yes! {diff:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {diff:f2} lv needed.");
            }
        }
    }
}