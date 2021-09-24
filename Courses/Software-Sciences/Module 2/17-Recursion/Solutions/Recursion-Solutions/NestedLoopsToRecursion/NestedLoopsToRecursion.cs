using System;

class NestedLoopsToRecursion
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var nums = new int[n];

        CreateLoop(nums, 0);
    }

    private static void CreateLoop(int[] nums, int index)
    {
        if (index > nums.Length - 1)
        {
            Console.WriteLine(string.Join(" ", nums));
            return;
        }

        for (int i = 1; i <= nums.Length; i++)
        {
            nums[index] = i;
            CreateLoop(nums, index + 1);
        }
    }
}
