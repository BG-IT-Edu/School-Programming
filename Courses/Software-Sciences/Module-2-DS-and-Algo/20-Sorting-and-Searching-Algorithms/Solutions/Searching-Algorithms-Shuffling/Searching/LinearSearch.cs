using System;
using System.Linq;

class LinearSearchClass
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

        int index = LinearSearch(arr, key);
        Console.WriteLine(index);
    }

    public static int LinearSearch(int[] data, int item)
    {
        int N = data.Length;
        for (int i = 0; i < N; i++)
            if (data[i] == item)
                return i;
        return -1;
    }
}