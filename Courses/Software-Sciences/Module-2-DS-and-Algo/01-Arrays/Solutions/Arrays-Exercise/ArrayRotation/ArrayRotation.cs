using System;
using System.Linq;

namespace ArrayRotation
{
    class ArrayRotation
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = array.Length - 1; j >= 0; j--)
                {
                    int temp = array[array.Length - 1];
                    array[array.Length - 1] = array[j];
                    array[j] = temp;
                }
            }

            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
        }
    }
}
