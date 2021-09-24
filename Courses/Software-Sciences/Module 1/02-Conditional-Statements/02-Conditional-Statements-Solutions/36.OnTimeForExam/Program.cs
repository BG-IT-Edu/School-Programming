using System;

namespace _36.OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinute = int.Parse(Console.ReadLine());

            int examTotalMinutes = (examHour * 60) + examMinute;
            int arriveTotalMinutes = (arriveHour * 60) + arriveMinute;

            if (examTotalMinutes == arriveTotalMinutes)
            {
                Console.WriteLine("On time");
            }
            else if (examTotalMinutes > arriveTotalMinutes)
            {
                if ((examTotalMinutes - arriveTotalMinutes) > 30)
                {
                    int minutesLeft = examTotalMinutes - arriveTotalMinutes;
                    if (minutesLeft >= 1 && minutesLeft < 60)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{minutesLeft} minutes before the start");
                    }
                    else if (minutesLeft >= 60)
                    {
                        int hours = minutesLeft / 60;
                        int minutes = minutesLeft % 60;
                        if (minutes < 10)
                        {
                            Console.WriteLine("Early");
                            Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
                        }
                        else
                        {
                            Console.WriteLine("Early");
                            Console.WriteLine($"{hours}:{minutes} hours before the start");
                        }
                    }
                }
                else if ((examTotalMinutes - arriveTotalMinutes) <= 30)
                {
                    int minutesLeft = examTotalMinutes - arriveTotalMinutes;
                    Console.WriteLine("On time");
                    Console.WriteLine($"{minutesLeft} minutes before the start");
                }
            }
            else if (arriveTotalMinutes > examTotalMinutes)
            {
                int minutesNeeded = arriveTotalMinutes - examTotalMinutes;
                if (minutesNeeded >= 1 && minutesNeeded < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{minutesNeeded} minutes after the start");
                }
                else if (minutesNeeded >= 60)
                {
                    int hours = minutesNeeded / 60;
                    int minutes = minutesNeeded % 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{hours}:{minutes:d2} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{hours}:{minutes} hours after the start");
                    }
                }
            }
        }
    }
}