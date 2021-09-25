using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine().Split(' ').ToArray();

            for (int i = items.Length - 1; i >= 0; i--)
            {
                Console.Write(items[i] + " ");
            }
        }
    }
}
