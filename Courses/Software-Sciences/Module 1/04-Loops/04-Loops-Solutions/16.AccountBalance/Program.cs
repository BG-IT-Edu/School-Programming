using System;

namespace _16.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalSum = 0;
            string input = Console.ReadLine();
            while (input != "NoMoreMoney")
            {
                double moneyIn = double.Parse(input);
                if (moneyIn < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {moneyIn:f2}");
                totalSum += moneyIn;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {totalSum:f2}");
        }
    }
}