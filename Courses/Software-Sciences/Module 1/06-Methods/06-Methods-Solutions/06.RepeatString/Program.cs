using System;

namespace _06.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            double n = double.Parse(Console.ReadLine());
            string result = NewText(text, n);

            Console.WriteLine(result);
        }

        static string NewText(string text, double n)
        {
            string result = "";

            for (int i = 0; i < n; i++)
            {
                result += text;
            }

            return result;
        }
    }
}