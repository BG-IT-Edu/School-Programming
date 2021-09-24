using System;
using System.Linq;

namespace _19.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] currCommand = command.Split();

                switch (currCommand[0])
                {
                    case "exchange":
                        initialArray = ExchangeArrayByIndex(initialArray, int.Parse(currCommand[1]));
                        break;
                    case "max":
                    case "min":
                        int index = GetLastIndexOfEvenOrOdd(initialArray, currCommand[0], currCommand[1]);
                        if (index < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(index);
                        }
                        break;
                    case "first":
                    case "last":
                        if (int.Parse(currCommand[1]) > initialArray.Length ||
                            int.Parse(currCommand[1]) < 1)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            int[] array = GetElementsFromArray(initialArray, currCommand[0], int.Parse(currCommand[1]), currCommand[2]);
                            Console.WriteLine($"[{String.Join(", ", array)}]");
                        }
                        break;
                }

                command = Console.ReadLine();
            }
            //output
            Console.WriteLine($"[{String.Join(", ", initialArray)}]");
        }

        static int[] GetElementsFromArray(int[] array, string firstOrLast, int countOfElements, string evenOrOdd)
        {
            array = evenOrOdd == "even" ? array.Where(x => x % 2 == 0).ToArray() : array.Where(x => x % 2 != 0).ToArray();

            if (array.Length > countOfElements && firstOrLast == "first")
            {
                array = array.Take(countOfElements).ToArray();
            }
            else if (array.Length > countOfElements && firstOrLast == "last")
            {
                array = array.TakeLast(countOfElements).ToArray();
            }

            return array;
        }
        static int GetLastIndexOfEvenOrOdd(int[] array, string maxOrMin, string evenOrOdd)
        {
            bool isAllEvenNumbers = Array.TrueForAll(array, x => x % 2 == 0);
            bool isAllOddNumbers = Array.TrueForAll(array, x => x % 2 != 0);

            if ((isAllEvenNumbers && evenOrOdd == "odd") ||
                (isAllOddNumbers && evenOrOdd == "even"))
            {
                return -1;
            }

            if (evenOrOdd == "even")
            {
                if (maxOrMin == "max")
                {
                    int maxEvenElement = array.Where(x => x % 2 == 0).Max();
                    return Array.LastIndexOf(array, maxEvenElement);
                }

                int minEvenElement = array.Where(x => x % 2 == 0).Min();
                return Array.LastIndexOf(array, minEvenElement);
            }

            if (maxOrMin == "max")
            {
                int maxOddElement = array.Where(x => x % 2 != 0).Max();

                return Array.LastIndexOf(array, maxOddElement);
            }

            int minOddElement = array.Where(x => x % 2 != 0).Min();

            return Array.LastIndexOf(array, minOddElement);
        }

        static int[] ExchangeArrayByIndex(int[] array, int index)
        {
            if (0 > index || index > array.Length - 1)
            {
                Console.WriteLine("Invalid index");
                return array;
            }

            array = RotateArray(array, index + 1);

            return array;
        }
        static int[] RotateArray(int[] array, int countOfRotation)
        {
            if (array.Length == countOfRotation)
            {
                return array;
            }

            for (int i = 0; i < countOfRotation; i++)
            {
                int firstElement = array[0];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }

                array[array.Length - 1] = firstElement;
            }

            return array;
        }
    }
}