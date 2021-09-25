using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomMinFunction
{
    class CustomMinFunction
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Func<List<int>, int> minNum = x =>
            {
                return x.Min();
            };

            Console.WriteLine(minNum(nums));
        }
    }
}
