using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    class ListManipulationAdvanced
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            bool changed = false;

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
                        changed = true;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(elements[1]);
                        nums.Remove(numberToRemove);
                        changed = true;
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(elements[1]);
                        nums.RemoveAt(indexToRemove);
                        changed = true;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(elements[1]);
                        int indexToInsert = int.Parse(elements[2]);
                        nums.Insert(indexToInsert, numberToInsert);
                        changed = true;
                        break;
                    case "Contains":
                        int numberToContain = int.Parse(elements[1]);

                        Console.WriteLine(nums.Contains(numberToContain) ? "Yes" : "No such number");
                        break;
                    case "PrintEven":
                        string evenElements = "";

                        foreach (var num in nums)
                        {
                            if (num % 2 == 0)
                            {
                                evenElements += num + " ";
                            }
                        }

                        Console.WriteLine(evenElements);
                        break;
                    case "PrintOdd":
                        string oddElements = "";
                        foreach (var num in nums)
                        {
                            if (num % 2 != 0)
                            {
                                oddElements += num + " ";
                            }
                        }
                        Console.WriteLine(oddElements);
                        break;
                    case "GetSum":
                        int sum = 0;
                        foreach (var num in nums)
                        {
                            sum += num;
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string condition = elements[1];
                        int number = int.Parse(elements[2]);

                        switch (condition)
                        {
                            case "<":
                                foreach (var num in nums)
                                {
                                    if (num < number)
                                    {
                                        Console.Write(num + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case ">":
                                foreach (var num in nums)
                                {
                                    if (num > number)
                                    {
                                        Console.Write(num + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case "<=":
                                foreach (var num in nums)
                                {
                                    if (num <= number)
                                    {
                                        Console.Write(num + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case ">=":
                                foreach (var num in nums)
                                {
                                    if (num >= number)
                                    {
                                        Console.Write(num + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                        }
                        break;
                }
            }

            if (changed) Console.WriteLine(string.Join(" ", nums));
        }
    }
}
