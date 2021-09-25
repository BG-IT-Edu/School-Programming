using System;

namespace _37.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekends = int.Parse(Console.ReadLine());

            double weekendsInSofia = 48 - weekends;
            double weekSofiaPlay = weekendsInSofia * 3.0 / 4.0;
            double holidaySofia = holidays * 2.0 / 3.0;

            double plays = holidaySofia + weekSofiaPlay + weekends;

            if (year == "leap")
            {
                plays *= 1.15;
                Console.WriteLine(Math.Floor(plays));
            }
            else
            {
                Console.WriteLine(Math.Floor(plays));
            }
        }
    }
}