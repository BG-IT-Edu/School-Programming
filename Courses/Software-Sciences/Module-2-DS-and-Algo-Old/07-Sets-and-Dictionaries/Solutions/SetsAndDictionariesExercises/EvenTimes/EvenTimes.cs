using System;
using System.Collections.Generic;

namespace EvenTimes
{
    class EvenTimes
    {
        static void Main(string[] args)
        {
            int countOfRows = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < countOfRows; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (numbers.ContainsKey(currentNumber))
                {
                    numbers[currentNumber]++;
                }
                else
                {
                    numbers[currentNumber] = 1;
                }
            }

            foreach (var num in numbers)
            {
                if (num.Value % 2 == 0)
                {
                    Console.WriteLine(num.Key);
                    return;
                }
            }
        }
    }
}
