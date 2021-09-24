using System;
using System.Collections.Generic;
using System.Linq;

namespace OperationsWithStack
{
    class OperationsWithStack
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int pushCount = input[0];
            int popCount = input[1];
            int element = input[2];

            var elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>();

            for (int i = 0; i < pushCount; i++)
            {
                stack.Push(elements[i]);
            }

            for (int i = 0; i < popCount; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(element))
            {
                Console.WriteLine("found");
            }
            else
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine("nothing found");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }
    }
}
