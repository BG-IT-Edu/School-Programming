using System;

namespace _14.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while (number > sum)
            {
                int numbers = int.Parse(Console.ReadLine());
                sum += numbers;
            }

            Console.WriteLine(sum);
        }
    }
}