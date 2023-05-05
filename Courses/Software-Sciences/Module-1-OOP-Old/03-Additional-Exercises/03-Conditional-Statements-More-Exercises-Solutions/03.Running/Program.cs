using System;

namespace _03.Running
{
    class Program
    {
        static void Main(string[] args)
        {
            int OneYearDays = 365;
            int NeededRunningMinutes = 40000;
            int MinutesForRunningInHardDay = 115;
            int MinutesForRunningInEasyDay = 55;

            int easyDays = int.Parse(Console.ReadLine());
            int hardDays = OneYearDays - easyDays;
            int realRunningMinutes = hardDays * MinutesForRunningInHardDay + easyDays * MinutesForRunningInEasyDay;

            if (NeededRunningMinutes >= realRunningMinutes)
            {
                Console.WriteLine("Great training!");
                Console.WriteLine($"She can run for {(NeededRunningMinutes - realRunningMinutes) / 60} hours and {(NeededRunningMinutes - realRunningMinutes) % 60} minutes more.");
            }
            else
            {
                Console.WriteLine($"Too much running!");
                Console.WriteLine($"Too hard to run for another {(realRunningMinutes - NeededRunningMinutes) / 60} hours and {(realRunningMinutes - NeededRunningMinutes) % 60} minutes.");
            }
        }
    }
}