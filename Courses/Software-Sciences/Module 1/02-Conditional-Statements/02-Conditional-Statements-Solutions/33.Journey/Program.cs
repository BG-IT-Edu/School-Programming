using System;

namespace _33.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string place = "";
            double expences = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    place = "Camp";
                    expences = budget * 0.30;
                }
                else
                {
                    place = "Hotel";
                    expences = budget * 0.70;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    place = "Camp";
                    expences = budget * 0.40;
                }
                else
                {
                    place = "Hotel";
                    expences = budget * 0.80;
                }
            }
            else
            {
                destination = "Europe";
                place = "Hotel";
                expences = budget * 0.90;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {expences:f2}");
        }
    }
}