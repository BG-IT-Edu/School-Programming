using System;

namespace ActionPrint
{
    class ActionPrint
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                 .Split();

            Action<string[]> print = n => Console.WriteLine(String.Join(Environment.NewLine, n));

            print(names);

        }
    }
}
