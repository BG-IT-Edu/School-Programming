using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    class ReverseAndExclude
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Action<List<int>> reverse = n => n.Reverse();

            reverse(nums);
            int num = int.Parse(Console.ReadLine());

            Func<int, int, bool> filterNums = (n, num) => n % num == 0;

            var filteredNums = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                if (!filterNums(nums[i], num))
                {
                    filteredNums.Add(nums[i]);
                }
            }


            Console.Write(String.Join(" ", filteredNums));
        }
    }
}
