using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var stack = new Stack<string>(input.Reverse());

            while (stack.Count > 1)
            {
                int leftOperand = int.Parse(stack.Pop());
                string operation = stack.Pop();
                int rightOperand = int.Parse(stack.Pop());

                switch (operation)
                {
                    case "+":
                        stack.Push((leftOperand + rightOperand).ToString());
                        break;
                    case "-":
                        stack.Push((leftOperand - rightOperand).ToString());
                        break;
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
