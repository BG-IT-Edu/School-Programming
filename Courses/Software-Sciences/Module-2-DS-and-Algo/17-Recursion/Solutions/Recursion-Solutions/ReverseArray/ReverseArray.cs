using System;
using System.Linq;

class ReverseArrayClass
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        PrintArrayInReversedOrder(nums, 0);
        Console.WriteLine();
    }

    private static void PrintArrayInReversedOrder(int[] nums, int index)
    {
        if (index > nums.Length - 1)
        {
            return;
        }

        PrintArrayInReversedOrder(nums, index + 1);
        Console.Write(nums[index] + " ");
    }
}

