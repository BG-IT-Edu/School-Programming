using System;

namespace _07.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < numbers; i++)
            {
                int numbersToCount = int.Parse(Console.ReadLine());
                sum += numbersToCount;
            }

            Console.WriteLine(sum);
        }
    }
}