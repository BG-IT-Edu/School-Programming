using System;
using System.Linq;

class InversionCount
{
    private static int[] aux;

    static void Main()
    {
        int[] arr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Console.WriteLine(MergeSort(arr));
    }

    private static int MergeSort(int[] arr)
    {
        int[] temp = new int[arr.Length];
        return Sort(arr, temp, 0, arr.Length - 1);
    }

    private static int Sort(int[] arr, int[] temp, int left, int right)
    {
        int mid, invCount = 0;

        if (right > left)
        {
            mid = (right + left) / 2;

            invCount = Sort(arr, temp, left, mid);
            invCount += Sort(arr, temp, mid + 1, right);

            invCount += Merge(arr, temp, left, mid + 1, right);
        }

        return invCount;
    }

    private static int Merge(int[] arr, int[] temp, int left, int mid, int right)
    {
        int i, j, k;

        int invCount = 0;

        i = left;
        j = mid;
        k = left;

        while ((i <= mid - 1) && (j <= right))
        {
            if (arr[i] <= arr[j])
            {
                temp[k++] = arr[i++];
            }
            else
            {
                temp[k++] = arr[j++];
                invCount += mid - i;
            }
        }

        while (i <= mid - 1)
        {
            temp[k++] = arr[i++];
        }

        while (j <= right)
        {
            temp[k++] = arr[j++];
        }

        for (i = left; i <= right; i++)
        {
            arr[i] = temp[i];
        }

        return invCount;
    }
}