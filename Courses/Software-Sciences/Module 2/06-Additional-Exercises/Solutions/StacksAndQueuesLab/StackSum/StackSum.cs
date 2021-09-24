using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class StackSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            Stack<int> stackOfNumbers = new Stack<int>(numbers);

            string[] command = Console.ReadLine().ToLower().Split();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "add":
                        int firstToAdd = int.Parse(command[1]);
                        int secondToAdd = int.Parse(command[2]);

                        stackOfNumbers.Push(firstToAdd);
                        stackOfNumbers.Push(secondToAdd);
                        break;
                    case "remove":
                        int count = int.Parse(command[1]);

                        if (count <= stackOfNumbers.Count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                stackOfNumbers.Pop();
                            }
                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine().ToLower().Split();
            }

            Console.WriteLine($"Sum: {stackOfNumbers.Sum()}");
        }
    }
}
