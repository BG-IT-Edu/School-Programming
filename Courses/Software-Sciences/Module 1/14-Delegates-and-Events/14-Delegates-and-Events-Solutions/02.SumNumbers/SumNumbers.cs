using System;
using System.Linq;

namespace SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                 .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse);

            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Sum());
        }
    }
}
