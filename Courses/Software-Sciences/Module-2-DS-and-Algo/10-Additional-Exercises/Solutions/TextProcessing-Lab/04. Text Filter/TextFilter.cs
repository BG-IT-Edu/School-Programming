using System;

namespace TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(", ");

            var text = Console.ReadLine();

            foreach (var word in words)
            {
                var replaceWord = new string('*', word.Length);

                while (text.Contains(word))
                {
                    text = text.Replace(word, replaceWord);
                }
            }

            Console.WriteLine(text);
        }
    }
}