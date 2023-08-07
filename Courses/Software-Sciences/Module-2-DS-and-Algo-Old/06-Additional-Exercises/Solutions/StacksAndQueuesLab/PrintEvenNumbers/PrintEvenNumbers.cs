using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class PrintEvenNumbers
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>(input);
            Queue<int> evenNumbers = new Queue<int>();

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenNumbers.Enqueue(num);
                }
            }

            Console.Write(evenNumbers.Dequeue());

            while (evenNumbers.Count > 0)
            {
                Console.Write($", {evenNumbers.Dequeue()}");
            }
        }
    }
}
