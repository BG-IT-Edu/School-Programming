using System;

namespace _08.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            for (int i = 0; i < number; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers > maxNumber)
                {
                    maxNumber = numbers;
                }
                if (numbers < minNumber)
                {
                    minNumber = numbers;
                }
            }

            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}