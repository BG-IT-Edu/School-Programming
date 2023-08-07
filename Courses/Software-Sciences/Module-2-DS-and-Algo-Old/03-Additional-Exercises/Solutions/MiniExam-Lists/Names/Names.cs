using System;
using System.Collections.Generic;

namespace Names
{
    class Names
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();

                names.Add(name);
            }

            names.Sort();

            foreach (var name in names)
            {
                Console.WriteLine($"{name}");
            }
        }
    }
}
