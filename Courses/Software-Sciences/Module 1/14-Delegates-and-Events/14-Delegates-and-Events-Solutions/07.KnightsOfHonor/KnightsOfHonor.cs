using System;

namespace KnightsOfHonor
{
    class KnightsOfHonor
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Action<string[]> print = PrintWords;
            print(words);
        }
        static void PrintWords(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"Sir {words[i]}");
            }
        }
    }
}
