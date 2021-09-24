using System;

namespace ReverseStrings
{
    class ReverseStrings
    {
        static void Main(string[] args)
        {
            string inputText;

            while ((inputText = Console.ReadLine()) != "end")
            {
                var reversedText = string.Empty;

                for (var i = inputText.Length - 1; i >= 0; i--)
                {
                    reversedText += inputText[i];
                }

                Console.WriteLine($"{inputText} = {reversedText}");
            }
        }
    }
}