using System;

namespace _32.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherMan = int.Parse(Console.ReadLine());
            double shipPrice = 0;

            switch (season)
            {
                case "Spring":
                    shipPrice = 3000;
                    break;

                case "Winter":
                    shipPrice = 2600;
                    break;

                default:
                    shipPrice = 4200;
                    break;
            }

            if (fisherMan <= 6)
            {
                shipPrice *= 0.9;
            }
            else if (fisherMan <= 11)
            {
                shipPrice *= 0.85;
            }
            else
            {
                shipPrice *= 0.75;
            }

            if (season != "Autumn" && (fisherMan % 2 == 0))
            {
                shipPrice *= 0.95;
            }

            if (budget >= shipPrice)
            {
                Console.WriteLine($"Yes! You have {budget - shipPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {shipPrice - budget:f2} leva.");
            }
        }
    }
}