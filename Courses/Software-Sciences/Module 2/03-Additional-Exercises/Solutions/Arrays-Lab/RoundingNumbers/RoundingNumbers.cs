using System;
using System.Linq;

namespace RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            int[] rounded = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                rounded[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);

                Console.WriteLine($"{Convert.ToDecimal(numbers[i])} => {Convert.ToDecimal(rounded[i])}");
            }
        }
    }
}
