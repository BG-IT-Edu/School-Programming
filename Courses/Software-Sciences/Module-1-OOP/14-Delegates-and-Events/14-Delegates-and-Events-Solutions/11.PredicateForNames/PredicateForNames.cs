using System;
using System.Collections.Generic;

namespace PredicateForNames
{
    class PredicateForNames
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Func<string[], int, List<string>> editor = Predicator;
            var list = editor(names, n);
            Console.WriteLine(string.Join("\n", list));
        }
        static List<string> Predicator(string[] names, int n)
        {
            var output = new List<string>();
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length <= n)
                {
                    output.Add(names[i]);
                }
            }
            return output;
        }
    }
}
