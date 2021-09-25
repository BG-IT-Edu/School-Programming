using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxAndMinElement
{
    class MaxAndMinElement
    {
        static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());
            Stack<int> stackOfNumbers = new Stack<int>();

            for (int i = 1; i <= countOfLines; i++)
            {
                int[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (command[0] == 1)
                {
                    stackOfNumbers.Push(command[1]);
                }
                else if (stackOfNumbers.Count > 0)
                {
                    switch (command[0])
                    {
                        case 2:
                            stackOfNumbers.Pop();
                            break;
                        case 3:
                            Console.WriteLine(stackOfNumbers.Max());
                            break;
                        case 4:
                            Console.WriteLine(stackOfNumbers.Min());
                            break;
                    }
                }
            }

            Console.WriteLine(String.Join(", ", stackOfNumbers));
        }
    }
}
