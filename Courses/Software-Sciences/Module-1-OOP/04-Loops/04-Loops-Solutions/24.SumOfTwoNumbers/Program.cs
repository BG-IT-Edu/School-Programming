using System;

namespace _24.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            bool isMagicNumberFound = false;
            int combinations = 0;

            for (int x1 = start; x1 <= end; x1++)
            {
                for (int x2 = start; x2 <= end; x2++)
                {
                    combinations++;
                    if (x1 + x2 == magicNumber)
                    {
                        isMagicNumberFound = true;
                        Console.WriteLine($"Combination N:{combinations} ({x1} + {x2} = {magicNumber})");
                        return;
                    }
                }
            }

            if (!isMagicNumberFound)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
            }
        }
    }
}