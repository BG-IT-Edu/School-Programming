using System;

namespace _11.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = GetSmallestNumber(a, b, c);

            Console.WriteLine($"{result}");
        }

        static int GetSmallestNumber(int a, int b, int c)
        {
            int result = 0;

            if (a < b && a < c)
            {
                result = a;
            }
            else if (b < a && b < c)
            {
                result = b;
            }
            else
            {
                result = c;
            }

            return result;
        }
    }
}