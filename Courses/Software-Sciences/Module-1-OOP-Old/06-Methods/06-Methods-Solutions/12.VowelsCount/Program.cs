using System;

namespace _12.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            int result = GetVowelCount(input);

            Console.WriteLine($"{result}");
        }

        static int GetVowelCount(string input)
        {
            int result = 0;

            foreach (var element in input)
            {
                if (element == 'a' || element == 'o' || element == 'u' || element == 'e' || element == 'i' || element == 'y')
                {
                    result++;
                }
            }

            return result;
        }
    }
}