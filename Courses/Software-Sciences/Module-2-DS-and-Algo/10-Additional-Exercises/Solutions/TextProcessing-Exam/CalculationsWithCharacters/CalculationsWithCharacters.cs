using System;

namespace CalculationsWithCharacters
{
    class CalculationsWithCharacters
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var text1 = input[0];
            var text2 = input[1];

            var maxLength = Math.Max(text1.Length, text2.Length);
            var sum = 0;

            for (var i = 0; i < maxLength; i++)
            {
                if (i < text1.Length && i < text2.Length)
                {
                    sum += text1[i] * text2[i];
                }
                else if (i < text1.Length)
                {
                    sum += text1[i];
                }
                else if (i < text2.Length)
                {
                    sum += text2[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
