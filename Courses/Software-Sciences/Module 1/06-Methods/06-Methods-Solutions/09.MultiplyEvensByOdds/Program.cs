using System;

namespace _09.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int number = Math.Abs(num);
            int result = GetMultipleOfEvenAndOdds(number);

            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);

            int result = evenSum * oddSum;

            return result;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int evenSum = 0;

            while (number >= 1)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }

                number /= 10;
            }

            return evenSum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int oddSum = 0;

            while (number >= 1)
            {
                int digit = number % 10;

                if (digit % 2 != 0)
                {
                    oddSum += digit;
                }

                number /= 10;
            }

            return oddSum;
        }
    }
}