using System;

namespace _21.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSeconds = int.Parse(Console.ReadLine());
            int secondSeconds = int.Parse(Console.ReadLine());
            int thirdSeconds = int.Parse(Console.ReadLine());

            int timeMinites = (firstSeconds + secondSeconds + thirdSeconds) / 60;

            int timeSeconds = (firstSeconds + secondSeconds + thirdSeconds) % 60;

            if (timeSeconds < 10)
            {
                Console.WriteLine($"{timeMinites}:0{timeSeconds}");
            }
            else
            {
                Console.WriteLine($"{timeMinites}:{timeSeconds}");
            }
        }
    }
}