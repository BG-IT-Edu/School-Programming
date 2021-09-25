using System;

namespace _07.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfWeek = int.Parse(Console.ReadLine());            
            if (dayOfWeek == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (dayOfWeek == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (dayOfWeek == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (dayOfWeek == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (dayOfWeek == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (dayOfWeek == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (dayOfWeek == 7)
            {
                Console.WriteLine("Sunday");
            }            
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}