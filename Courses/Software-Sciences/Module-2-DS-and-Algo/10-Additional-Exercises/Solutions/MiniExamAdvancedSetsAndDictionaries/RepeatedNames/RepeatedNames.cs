using System;
using System.Collections.Generic;

namespace RepeatedNames
{
    class RepeatedNames
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < rows; i++)
            {
                names.Add(Console.ReadLine());
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
