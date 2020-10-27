using System;

namespace Coin_Ratings
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var votesForDoge = 0;
            var votesForIOTA = 0;
            var votesForNeo = 0;
            var votesForESTD = 0;

            var dogeToEur = 0.07;
            var iotaToEur = 1.44;
            var neoToEur = 28.50;
            var estdToEur = 25.0;

            var coinsInDoge = 0.0;
            var coinsInIOTA = 0.0;
            var coinsInNeo = 0.0;
            var coinsInESTD = 0.0;

            for (int i = 0; i < n; i++)
            {
                var label = Console.ReadLine();
                var coins = double.Parse(Console.ReadLine());

                switch (label)
                {
                    case "DOGE": coinsInDoge += coins; votesForDoge++; break;
                    case "IOTA": coinsInIOTA += coins; votesForIOTA++; break;
                    case "NEO": coinsInNeo += coins; votesForNeo++; break;
                    case "ESTD": coinsInESTD += coins; votesForESTD++; break;
                }
            }

            var totalDogeInEur = coinsInDoge * dogeToEur;
            var totalIotaInEur = coinsInIOTA * iotaToEur;
            var totalNeoInEur = coinsInNeo * neoToEur;
            var totalEstdInEur = coinsInESTD * estdToEur;

            var totalMarketCapInEur = totalDogeInEur + totalIotaInEur + totalNeoInEur + totalEstdInEur;

            var totalVotesForCategories = votesForDoge + votesForESTD + votesForIOTA + votesForNeo;

            var dogePercentage = totalDogeInEur / totalMarketCapInEur * 100;
            var iotaPercentage = totalIotaInEur / totalMarketCapInEur * 100;
            var neoPercentage = totalNeoInEur / totalMarketCapInEur * 100;
            var estdPercentage = totalEstdInEur / totalMarketCapInEur * 100;

            Console.WriteLine($"Total votes = {totalVotesForCategories}, Money in market = {totalMarketCapInEur:F2} EUR");

            Console.WriteLine($"DOGE's contribution: {dogePercentage:F2}%; People who use DOGE: {votesForDoge}");
            Console.WriteLine($"IOTA's contribution: {iotaPercentage:F2}%; People who use IOTA: {votesForIOTA}");
            Console.WriteLine($"NEO's contribution: {neoPercentage:F2}%; People who use NEO: {votesForNeo}");
            Console.WriteLine($"ESTD's contribution: {estdPercentage:F2}%; People who use ESTD: {votesForESTD}");
        }
    }
}
