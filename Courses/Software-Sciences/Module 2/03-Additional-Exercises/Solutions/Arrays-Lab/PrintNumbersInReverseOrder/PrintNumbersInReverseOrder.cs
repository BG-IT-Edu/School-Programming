using System;

namespace PrintNumbersInReverseOrder
{
    class PrintNumbersInReverseOrder
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int j = arr.Length - 1; j >= 0; j--)
            {
                Console.Write(arr[j] + " ");
            }
        }
    }
}
