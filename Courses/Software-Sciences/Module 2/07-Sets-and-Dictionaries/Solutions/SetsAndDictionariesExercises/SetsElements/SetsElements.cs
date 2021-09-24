using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsElements
{
    class SetsElements
    {
        static void Main(string[] args)
        {
            int[] setsSize = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstSetSize = setsSize[0];
            int secondSetSize = setsSize[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < firstSetSize; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int j = 0; j < secondSetSize; j++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var item in firstSet)
            {
                if (secondSet.Contains(item))
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}
