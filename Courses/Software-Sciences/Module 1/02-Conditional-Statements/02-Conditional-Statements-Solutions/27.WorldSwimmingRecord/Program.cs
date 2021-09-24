using System;

namespace _27.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double oneMeterSwimPerSeconds = double.Parse(Console.ReadLine());

            double swimmingTime = distanceInMeters * oneMeterSwimPerSeconds;
            double slowingSeconds = (Math.Floor(distanceInMeters / 15)) * 12.5;

            double totalTime = swimmingTime + slowingSeconds;

            if (totalTime < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                double timeNeeded = totalTime - recordInSeconds;
                Console.WriteLine($"No, he failed! He was {timeNeeded:f2} seconds slower.");
            }
        }
    }
}