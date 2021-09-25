using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesАndReverse
{
    class RemoveNegativesАndReverse
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] < 0)
                {
                    nums.RemoveAt(i--);
                }
            }

            nums.Reverse();

            Console.WriteLine(nums.Count == 0 ? "empty" : string.Join(" ", nums));
        }
    }
}
