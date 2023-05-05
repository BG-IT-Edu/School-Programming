using System;

namespace _31.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlowers = Console.ReadLine();
            int countFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double priceFlower = 0;

            switch (typeFlowers)
            {
                case "Roses":
                    priceFlower = 5.0;
                    if (countFlowers > 80)
                    {
                        priceFlower *= 0.90;
                    }

                    break;
                case "Dahlias":
                    priceFlower = 3.80;
                    if (countFlowers > 90)
                    {
                        priceFlower *= 0.85;
                    }

                    break;
                case "Tulips":
                    priceFlower = 2.80;
                    if (countFlowers > 80)
                    {
                        priceFlower *= 0.85;
                    }

                    break;
                case "Narcissus":
                    priceFlower = 3.0;
                    if (countFlowers < 120)
                    {
                        priceFlower *= 1.15;
                    }

                    break;
                case "Gladiolus":
                    priceFlower = 2.50;
                    if (countFlowers < 80)
                    {
                        priceFlower *= 1.20;
                    }

                    break;
            }

            double neededBudget = priceFlower * countFlowers;
            if (neededBudget <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {countFlowers} {typeFlowers} and {budget - neededBudget:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {neededBudget - budget:f2} leva more.");
            }
        }
    }
}