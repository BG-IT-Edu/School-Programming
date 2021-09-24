using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Train
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            int capacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] elements = command.Split();

                if (elements.Contains("Add"))
                {
                    int numberToAdd = int.Parse(elements[1]);
                    nums.Add(numberToAdd);
                }
                else
                {
                    int passengers = int.Parse(elements[0]);

                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] + passengers <= capacity)
                        {
                            nums[i] += passengers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
