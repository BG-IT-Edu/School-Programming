using System;
using System.Linq;

class Quicksort
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

        Quick.Sort(arr);

        Console.WriteLine(String.Join(" ", arr));
    }
}

public class Quick
{
    public static void Sort(int[] arr)
    {
        Shuffle(arr);
        Sort(arr, 0, arr.Length - 1);
    }

    private static void Sort(int[] arr, int leftIndex, int rightIndex)
    {
        if (leftIndex >= rightIndex)
        {
            return;
        }

        int pivot = Partition(arr, leftIndex, rightIndex);
        Sort(arr, leftIndex, pivot - 1);
        Sort(arr, pivot + 1, rightIndex);
    }

    private static int Partition(int[] arr, int leftIndex, int rightIndex)
    {
        if (leftIndex >= rightIndex)
        {
            return leftIndex;
        }

        int i = leftIndex;
        int j = rightIndex + 1;
        while (true)
        {
            while (Less(arr[++i], arr[leftIndex]))
            {
                if (i == rightIndex) break;
            }

            while (Less(arr[leftIndex], arr[--j]))
            {
                if (j == leftIndex) break;
            }

            if (i >= j) break;

            Swap(arr, i, j);
        }

        Swap(arr, leftIndex, j);
        return j;
    }

    private static void Swap(int[] arr, int firstIndex, int secondIndex)
    {
        var old = arr[firstIndex];
        arr[firstIndex] = arr[secondIndex];
        arr[secondIndex] = old;
    }

    private static bool Less(int current, int other)
    {
        return current.CompareTo(other) < 0;
    }

    private static void Shuffle(int[] array)
    {
        Random random = new Random();

        for (int currNum = 0; currNum < array.Length; currNum++)
        {
            // Exchange array[i] with random element in array[i … n-1]

            int randomNum = currNum + random.Next(0, array.Length - currNum);

            int oldNum = array[currNum];
            array[currNum] = array[randomNum];
            array[randomNum] = oldNum;
        }
    }
}