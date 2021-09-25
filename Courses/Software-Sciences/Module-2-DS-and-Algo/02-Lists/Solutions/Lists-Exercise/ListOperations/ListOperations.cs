using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class ListOperations
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    Console.WriteLine(String.Join(' ', numbers));
                    break;
                }

                string[] command = input.Split(' ');

                if (command.Contains("Add"))
                {
                    numbers.Add((int.Parse(command[1])));
                }
                else if (command.Contains("Insert"))
                {
                    int index = int.Parse(command[2]);

                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.Insert(index, int.Parse(command[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command.Contains("Remove"))
                {
                    int index = int.Parse(command[1]);

                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command.Contains("left"))
                {
                    int count = int.Parse(command[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int number = numbers[0];

                        numbers.RemoveAt(0);
                        numbers.Add(number);
                    }
                }
                else if (command.Contains("right"))
                {
                    int count = int.Parse(command[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int number = numbers[numbers.Count - 1];

                        numbers.Remove(number);
                        numbers.Insert(0, number);
                    }
                }
            }
        }
    }
}
