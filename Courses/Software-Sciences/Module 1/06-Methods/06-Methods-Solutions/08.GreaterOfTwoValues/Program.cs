using System;

namespace _08.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine();
            switch (valueType)
            {
                case "int":
                    int firstInt = int.Parse(Console.ReadLine());
                    int secondInt = int.Parse(Console.ReadLine());
                    int greaterInt = GetMax(firstInt, secondInt);
                    Console.WriteLine(greaterInt);
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    char greaterChar = GetMax(firstChar, secondChar);
                    Console.WriteLine(greaterChar);
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    string greaterString = GetMax(firstString, secondString);
                    Console.WriteLine(greaterString);
                    break;
                default:
                    break;
            }
        }

        private static int GetMax(int firstInt, int secondInt)
        {
            return Math.Max(firstInt, secondInt);
        }

        private static char GetMax(char firstChar, char secondChar)
        {
            return (char)Math.Max(firstChar, secondChar);
        }

        private static string GetMax(string firstString, string secondString)
        {
            if (firstString.CompareTo(secondString) >= 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }
    }
}