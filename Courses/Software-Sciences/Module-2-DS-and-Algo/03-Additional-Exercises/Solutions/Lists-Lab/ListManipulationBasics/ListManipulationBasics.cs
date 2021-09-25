using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class ListManipulationBasics
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

                switch (elements[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(elements[1]);
                        nums.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(elements[1]);
                        nums.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(elements[1]);
                        nums.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(elements[1]);
                        int indexToInsert = int.Parse(elements[2]);
                        nums.Insert(indexToInsert, numberToInsert);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
