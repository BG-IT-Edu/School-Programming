using System;
using System.Linq;

class MergeSort
{
    static void Main()
    {
        string input = Console.ReadLine();

        if (input == String.Empty)
        {
            return;
        }

        int[] arr = input
            .Split()
            .Select(int.Parse)
            .ToArray();

        Mergesort.Sort(arr);

        Console.WriteLine(String.Join(" ", arr));
    }
}

public class Mergesort
{
    private static int[] auxArr;

    public static void Sort(int[] arr)
    {
        auxArr = new int[arr.Length];
        Sort(arr, 0, arr.Length - 1);
    }

    private static void Merge(int[] arr, int leftIndex, int midIndex, int rightIndex)
    {
        if (IsLess(arr[midIndex], arr[midIndex + 1]))
        {
            return;
        }

        for (int index = leftIndex; index < rightIndex + 1; index++)
        {
            auxArr[index] = arr[index];
        }

        int i = leftIndex;
        int j = midIndex + 1;

        for (int currIndex = leftIndex; currIndex <= rightIndex; currIndex++)
        {
            if (i > midIndex)
            {
                arr[currIndex] = auxArr[j++];
            }
            else if (j > rightIndex)
            {
                arr[currIndex] = auxArr[i++];
            }
            else if (IsLess(auxArr[i], auxArr[j]))
            {
                arr[currIndex] = auxArr[i++];
            }
            else
            {
                arr[currIndex] = auxArr[j++];
            }
        }
    }

    private static bool IsLess(int current, int other)
    {
        return current.CompareTo(other) < 0;
    }

    private static void Sort(int[] arr, int leftIndex, int rightIndex)
    {
        if (leftIndex >= rightIndex)
        {
            return;
        }

        int midIndex = leftIndex + (rightIndex - leftIndex) / 2;

        Sort(arr, leftIndex, midIndex);
        Sort(arr, midIndex + 1, rightIndex);
        Merge(arr, leftIndex, midIndex, rightIndex);
    }
}