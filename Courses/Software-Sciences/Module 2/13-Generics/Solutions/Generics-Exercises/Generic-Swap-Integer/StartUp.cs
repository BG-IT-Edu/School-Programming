using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _05.GenericSwapMethod
{
    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());
                list.Add(input);
            }

            var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SwapGeneric<int>(list, indexes[0], indexes[1]);

            PrintResult(list);
        }

        public static void SwapGeneric<T>(List<T> list, int firstIndex, int secondIndex)
        {
            if (firstIndex >= 0 && firstIndex < list.Count && secondIndex >= 0 && secondIndex < list.Count)
            {
                var temp = list[firstIndex];
                list[firstIndex] = list[secondIndex];
                list[secondIndex] = temp;
            }
        }

        private static void PrintResult(List<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
    }
}
