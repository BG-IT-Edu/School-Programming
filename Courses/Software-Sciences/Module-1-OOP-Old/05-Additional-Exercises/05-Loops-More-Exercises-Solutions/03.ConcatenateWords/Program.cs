using System;

namespace _03.ConcatenateWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string word = string.Empty;
                for (int i = 0; i < 3; i++)
                {
                    string currentWord = Console.ReadLine();
                    word += currentWord;
                }

                Console.WriteLine(word);
                input = Console.ReadLine();
            }
        }
    }
}