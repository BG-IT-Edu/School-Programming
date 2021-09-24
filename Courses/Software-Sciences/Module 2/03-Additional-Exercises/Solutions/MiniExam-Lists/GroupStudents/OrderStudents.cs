using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupStudents
{
    class OrderStudents
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<string> orderedNumbers = new List<string>();

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                string[] group = numbers[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (var number in group)
                {
                    orderedNumbers.Add(number);
                }
            }

            Console.WriteLine(String.Join(" ", orderedNumbers));
        }
    }
}
