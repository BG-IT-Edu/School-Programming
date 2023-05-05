using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class FindEvensOrOdds
    {
        static void Main(string[] args)
        {
            Func<int, bool> oddNums = x => x % 2 != 0;
            Func<int, bool> evenNums = x => x % 2 == 0;
            int[] bounds = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var nums = new List<int>();

            int lowerBound = bounds[0];
            int upperBound = bounds[1];

            for (int i = lowerBound; i <= upperBound; i++)
            {
                nums.Add(i);
            }

            string numType = Console.ReadLine();

            if (numType == "odd")
            {
                nums = nums.Where(oddNums).ToList();
            }
            else
            {
                nums = nums.Where(evenNums).ToList();
            }

            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
