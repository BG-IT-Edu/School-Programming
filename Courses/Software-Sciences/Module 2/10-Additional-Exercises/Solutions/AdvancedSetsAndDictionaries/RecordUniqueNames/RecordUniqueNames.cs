using System;
using System.Collections.Generic;

namespace RecordUniqueNames
{
    class RecordUniqueNames
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            HashSet<string> uniqueNames = new HashSet<string>();

            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();

                uniqueNames.Add(name);
            }

            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
