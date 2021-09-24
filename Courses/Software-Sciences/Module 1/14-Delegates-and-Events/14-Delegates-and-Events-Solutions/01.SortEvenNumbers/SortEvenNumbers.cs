using System;
using System.Linq;

namespace SortEvenNumbers
{
    class SortEvenNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                 .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .Where(n => n % 2 == 0)
                 .OrderBy(n => n);

            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
