using System;

namespace _29.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int totalSum = 0;
            int max = int.MinValue;

            for (int i = 0; i < numbers; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                totalSum += nums;
                if (nums > max)
                {
                    max = nums;
                }
            }

            int sumWithoutMax = totalSum - max;
            if (sumWithoutMax == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                int diff = Math.Abs(max - sumWithoutMax);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}