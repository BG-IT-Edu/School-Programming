using System;

namespace LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            var totalSum = 0.0;

            foreach (var code in input)
            {
                var numberString = string.Empty;

                for (var i = 1; i < code.Length - 1; i++)
                {
                    numberString += code[i];
                }

                var number = double.Parse(numberString);
                var firstChar = code[0];
                var lastChar = code[code.Length - 1];

                if (char.IsUpper(firstChar))
                {
                    var codeNumber = (int)(firstChar - 'A' + 1);
                    number /= codeNumber;
                }
                else if (char.IsLower(firstChar))
                {
                    var codeNumber = (int)(firstChar - 'a' + 1);
                    number *= codeNumber;
                }

                if (char.IsUpper(lastChar))
                {
                    var codeNumber = (int)(lastChar - 'A' + 1);
                    number -= codeNumber;
                }
                else if (char.IsLower(lastChar))
                {
                    var codeNumber = (int)(lastChar - 'a' + 1);
                    number += codeNumber;
                }

                totalSum += number;
            }

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
