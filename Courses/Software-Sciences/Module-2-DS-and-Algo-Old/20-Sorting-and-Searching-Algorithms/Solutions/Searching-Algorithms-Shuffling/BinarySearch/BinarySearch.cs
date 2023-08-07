using System;
using System.Linq;

class BinarySearchClass
{
    static void Main()
    {
        string input = Console.ReadLine();
        int key = int.Parse(Console.ReadLine());

        if (input == String.Empty)
        {
            return;
        }

        int[] arr = input
            .Split()
            .Select(int.Parse)
            .ToArray();

        int index = BinarySearch(arr, key);
        Console.WriteLine(index);
    }

    public static int BinarySearch(int[] arr, int key)
    {
        int leftIndex = 0;
        int rightIndex = arr.Length - 1;

        while (leftIndex <= rightIndex)
        {
            int midIndex = leftIndex + (rightIndex - leftIndex) / 2;

            if (key < arr[midIndex])
            {
                rightIndex = midIndex - 1;
            }
            else if (key > arr[midIndex])
            {
                leftIndex = midIndex + 1;
            }
            else
            {
                return midIndex;
            }
        }

        return -1;
    }
}