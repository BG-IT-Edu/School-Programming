using System;

namespace _17.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                bool palindrome = PalindromeNumber(input);

                Console.WriteLine(palindrome ? "true" : "false");
            }
        }

        static bool PalindromeNumber(string input)
        {
            bool result = false;
            string firstHalf = "";
            string secondHalf = "";

            if (input.Length == 1)
            {
                result = true;
            }
            else if (input.Length % 2 != 0)
            {
                for (int i = 0; i < input.Length / 2; i++)
                {
                    firstHalf += input[i];
                }

                for (int i = input.Length - 1; i > input.Length / 2; i--)
                {
                    secondHalf += input[i];
                }

                if (firstHalf == secondHalf)
                {
                    result = true;
                }
            }
            else
            {
                for (int i = 0; i < input.Length / 2; i++)
                {
                    firstHalf += input[i];
                }

                for (int i = input.Length - 1; i >= input.Length / 2; i--)
                {
                    secondHalf += input[i];
                }

                if (firstHalf == secondHalf)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}