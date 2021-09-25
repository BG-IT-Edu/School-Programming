using System;

namespace _13.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            string result = GetCharacters(a, b);

            Console.WriteLine($"{result}");
        }

        static string GetCharacters(char a, char b)
        {
            string result = "";

            if (a < b)
            {
                for (char i = a; i < b; i++)
                {
                    if (i != a)
                    {
                        result += i + " ";
                    }
                }
            }
            else
            {
                for (char i = b; i < a; i++)
                {
                    if (i != b)
                    {
                        result += i + " ";
                    }
                }
            }

            return result;
        }
    }
}