using System;
using System.Linq;

namespace TopIntegers
{
    class TopIntegers
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];
                bool isTopNumber = true;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int rightNumber = arr[j];

                    if (rightNumber >= currentNumber)
                    {
                        isTopNumber = false;
                        break;
                    }
                }

                if (isTopNumber)
                {
                    Console.Write($"{currentNumber} ");
                }
            }
        }
    }
}
