using System;

namespace _38.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            int coinCounter = 0;
            double amount = double.Parse(Console.ReadLine());
            amount = Math.Round(amount * 100);
            while (amount != 0)
            {
                if (amount / 200 >= 1)
                {
                    amount -= 200;
                    coinCounter++;
                }
                else if (amount / 100 >= 1)
                {
                    amount -= 100;
                    coinCounter++;
                }
                else if (amount / 50 >= 1)
                {
                    amount -= 50;
                    coinCounter++;
                }
                else if (amount / 20 >= 1)
                {
                    amount -= 20;
                    coinCounter++;
                }
                else if (amount / 10 >= 1)
                {
                    amount -= 10;
                    coinCounter++;
                }
                else if (amount / 5 >= 1)
                {
                    amount -= 5;
                    coinCounter++;
                }
                else if (amount / 2 >= 1)
                {
                    amount -= 2;
                    coinCounter++;
                }
                else
                {
                    amount -= 1;
                    coinCounter++;
                }
            }

            Console.WriteLine(coinCounter);
        }
    }
}