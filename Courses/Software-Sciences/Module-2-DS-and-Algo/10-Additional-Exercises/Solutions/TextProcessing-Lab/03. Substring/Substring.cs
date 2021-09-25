using System;

namespace Substring
{
    class Substring
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().ToLower();
            var text = Console.ReadLine();

            while (text.Contains(word))
            {
                text = text.Replace(word, string.Empty);
            }

            Console.WriteLine(text);
        }
    }
}