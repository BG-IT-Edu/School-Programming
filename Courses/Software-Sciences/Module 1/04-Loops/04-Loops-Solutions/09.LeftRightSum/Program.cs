using System;

namespace _09.LeftRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < 2 * countOfNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i < countOfNumbers)
                {
                    leftSum += number;
                }
                else
                {
                    rightSum += number;
                }
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}