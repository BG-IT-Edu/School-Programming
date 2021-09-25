using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stackOfStrings = new StackOfStrings();

            Console.WriteLine(stackOfStrings.IsEmpty()); //True

            Stack<string> fullStack = new Stack<string>();

            fullStack.Push("b");
            fullStack.Push("c");

            stackOfStrings.AddRange(fullStack);

            Console.WriteLine(stackOfStrings.IsEmpty()); //False

        }
    }
}
