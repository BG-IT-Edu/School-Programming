using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class AnonymousThreat
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();

            while (command != "3:1")
            {
                string[] commandWords = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commandWords[0] == "merge")
                {
                    int startIndex = int.Parse(commandWords[1]);
                    int endIndex = int.Parse(commandWords[2]);

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    if (endIndex > input.Count - 1)
                    {
                        endIndex = input.Count - 1;
                    }

                    for (int i = 1; i <= endIndex - startIndex; i++)
                    {
                        input[startIndex] += input[startIndex + 1];

                        input.RemoveAt(startIndex + 1);
                    }
                }
                else if (commandWords[0] == "divide")
                {
                    int index = int.Parse(commandWords[1]);
                    int partitions = int.Parse(commandWords[2]);
                    int currentStringLength = input[index].Length;
                    int newStringLength = currentStringLength / partitions;

                    for (int i = 0; i < partitions - 1; i++) 
                    {
                        string partCurrentString = string.Empty;

                        for (int j = 0; j < newStringLength; j++)
                        {
                            partCurrentString += input[index][j + (newStringLength * i)];
                        }

                        input.Insert(index + i + 1, partCurrentString);
                    }

                    string lastCurrentString = string.Empty;

                    for (int j = newStringLength * (partitions - 1); j < currentStringLength; j++)
                    {
                        lastCurrentString += input[index][j];
                    }

                    input.Insert(index + partitions, lastCurrentString);
                    input.RemoveAt(index);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', input));
        }
    }
}
