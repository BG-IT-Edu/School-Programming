using System;
using System.Linq;

class Sorting
{
    //Using Bubble Sort
    static void Main()
    {
        int[] arr = Console.ReadLine().Trim().Split(' ')
            .Select(int.Parse).ToArray();

        BubbleSort(arr);
        Console.WriteLine(string.Join(" ", arr));
    }

    static void BubbleSort(int[] array)
    {
        bool swapped = true;
        while (swapped)
        {
            swapped = false;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Swap(array, i, i+1);
                    swapped = true;
                }
            }
        }
    }

    private static void Swap(int[] arr, int firstIndex, int secondIndex)
    {
        var old = arr[firstIndex];
        arr[firstIndex] = arr[secondIndex];
        arr[secondIndex] = old;
    }

}
