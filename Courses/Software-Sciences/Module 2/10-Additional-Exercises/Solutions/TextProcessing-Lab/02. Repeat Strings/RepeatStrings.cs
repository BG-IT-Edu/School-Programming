using System;

namespace RepeatStrings
{
    class RepeatStrings
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine().Split();

            var resultText = string.Empty;

            foreach (var word in inputText)
            {
                foreach (var t in word)
                {
                    resultText += word;
                }
            }

            Console.WriteLine(resultText);
        }
    }
}