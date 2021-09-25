using System;

namespace _13.VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int sheetsCount = int.Parse(Console.ReadLine());
            double sheetsPerHour = double.Parse(Console.ReadLine());
            int daysCount = int.Parse(Console.ReadLine());

            double timePerDay = (sheetsCount / sheetsPerHour) / daysCount;

            Console.WriteLine(timePerDay);
        }
    }
}