using System;

namespace _15.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = MidChars(input);

            Console.WriteLine(result);
        }

        static string MidChars(string input)
        {
            string result = "";

            if (input.Length % 2 != 0)
            {
                result = input[input.Length / 2].ToString();
            }
            else
            {
                result = input[input.Length / 2 - 1].ToString() + input[input.Length / 2].ToString();
            }

            return result;
        }
    }
}