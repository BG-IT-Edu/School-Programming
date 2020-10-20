using System;

namespace Altcoins
{
    class Program
    {
        static void Main(string[] args)
        {

            double bitcoinsBought = double.Parse(Console.ReadLine());
            double bitcoinBeginingRate = double.Parse(Console.ReadLine());
            double bitcoinsCurrentRate = double.Parse(Console.ReadLine());
            double desiredEther = double.Parse(Console.ReadLine());
            double desiredNeo = double.Parse(Console.ReadLine());

            double priceOfEther = bitcoinsCurrentRate * 0.075;
            double priceOfNeo = priceOfEther * 0.40;

            double beginingMoney = bitcoinBeginingRate * bitcoinsBought;
            double currentMoney = bitcoinsCurrentRate * bitcoinsBought;

            double profit = currentMoney - beginingMoney;

            double totalPriceOfEther = desiredEther * priceOfEther;
            double totalPriceOfNeo = desiredNeo * priceOfNeo;

            double totalPriceInUsd = totalPriceOfEther + totalPriceOfNeo;


            if (profit < totalPriceInUsd)
            {
                double moneyNeeded = totalPriceInUsd - profit;
                Console.WriteLine("Stefcho does not have enough money to make this investment.");
                Console.WriteLine($"He needs {moneyNeeded:F2} more in profits.");
            }
            else
            {
                double moneyLeft = profit - totalPriceInUsd;
                Console.WriteLine($"Stefcho bought {desiredEther:F4} Ethereum at a price of {priceOfEther:F4}");
                Console.WriteLine($"Stefcho bought {desiredNeo:F4} Neo at a price of {priceOfNeo:F4}");
                Console.WriteLine($"Stefcho has {moneyLeft:F2} profits left to spend.");
            }
        }
    }
}
