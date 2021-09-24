using System;

namespace _16.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstN = int.Parse(Console.ReadLine());
            int secondN = int.Parse(Console.ReadLine());

            decimal result = FirstFactorial(firstN) / SecondFactorial(secondN);

            Console.WriteLine($"{result:f2}");
        }

        static decimal FirstFactorial(int firstN)
        {
            long result = 1;

            for (int i = 1; i <= firstN; i++)
            {
                result *= i;
            }

            return result;
        }

        static decimal SecondFactorial(int secondN)
        {
            long result = 1;

            for (int i = 1; i <= secondN; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}