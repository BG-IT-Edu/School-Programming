using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckStudents
{
    class CheckStudents
    {
        static void Main(string[] args)
        {
            List<string> missing = new List<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command.Contains("not"))
                {
                    if (missing.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        missing.Add(command[0]);
                    }
                }
                else
                {
                    if (missing.Contains(command[0]))
                    {
                        missing.Remove(command[0]);

                        Console.WriteLine($"{command[0]} is in class!");
                    }
                }
            }

            foreach (var name in missing)
            {
                Console.WriteLine(name);
            }
        }
    }
}
