using System;
using System.Text;

namespace ReduceCharacters
{
    class ReduceCharacters
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var result = new StringBuilder();

            var lastChar = input[0];

            result.Append(input[0]);

            for (var i = 1; i < input.Length; i++)
            {
                if (input[i] == lastChar)
                {
                    continue;
                }

                result.Append(input[i]);
                lastChar = input[i];
            }

            Console.WriteLine(result);
        }
    }
}
