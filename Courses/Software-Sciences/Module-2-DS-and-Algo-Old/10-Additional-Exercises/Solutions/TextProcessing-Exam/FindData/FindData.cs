using System;
using System.Text.RegularExpressions;

namespace FindData
{
    class FindData
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                int indexOfNameStart = input.IndexOf('@');
                int indexOfNameEnd = input.IndexOf('|');

                string name = input.Substring(indexOfNameStart + 1, indexOfNameEnd - indexOfNameStart - 1);

                int indexOfAgeStart = input.IndexOf('#');
                int indexOfAgeEnd = input.IndexOf('*');

                string ageStr = input.Substring(indexOfAgeStart + 1, indexOfAgeEnd - indexOfAgeStart - 1);

                Console.WriteLine($"{name} is {ageStr} years old.");
            }
        }
    }
}
