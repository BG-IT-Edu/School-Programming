using System;
using System.Linq;

class RecursiveArraySum
{
    static void Main()
    {
        string input = Console.ReadLine();

        int[] intArr = input.Split(' ').Select(Int32.Parse).ToArray();

        int sum = Sum(intArr, 0);

        Console.WriteLine(sum);
    }

    private static int Sum(int[] arr, int index)
    {
        if (index == arr.Length)
        {
            return 0;
        }

        int currentSum = arr[index] + Sum(arr, index + 1);

        return currentSum;
    }
}
