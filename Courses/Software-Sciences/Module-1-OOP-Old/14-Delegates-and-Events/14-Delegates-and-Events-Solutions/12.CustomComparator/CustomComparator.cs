using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomComparator
{
    class CustomComparator
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Array.Sort(nums);

            var sortedList = new List<int>();

            Func<int, bool> evenNums = n => n % 2 == 0;

            foreach (var num in nums)
            {
                if (evenNums(num))
                {
                    sortedList.Add(num);

                }

            }

            foreach (var num in nums)
            {
                if (!evenNums(num))
                {
                    sortedList.Add(num);
                }

            }

            Action<List<int>> print = n => Console.Write(String.Join(" ", n));

            print(sortedList);
        }
    }
}
