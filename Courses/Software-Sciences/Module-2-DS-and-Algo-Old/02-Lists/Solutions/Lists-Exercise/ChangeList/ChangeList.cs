using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] elements = command.Split();

                if (elements.Contains("Insert"))
                {
                    int numberToInsert = int.Parse(elements[1]);
                    int position = int.Parse(elements[2]);
                    nums.Insert(position, numberToInsert);
                }
                else
                {
                    int elementToDelete = int.Parse(elements[1]);
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] == elementToDelete)
                        {
                            nums.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
