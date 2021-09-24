using System;
using System.Collections.Generic;

namespace WordSynonyms
{
    class WordSynonyms
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var words = new Dictionary<string, List<string>>();

            for (var i = 0; i < n; i++)
            {
                var word = Console.ReadLine();

                var synonym = Console.ReadLine();

                if (words.ContainsKey(word) == false)
                {
                    words.Add(word, new List<string>());
                }

                words[word].Add(synonym);
            }

            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
