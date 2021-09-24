using System;
using System.Linq;

namespace Zig_ZagArrays
{
    class ZigZagArrays
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] firstArr = new string[n];
            string[] secondArr = new string[n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    firstArr[i] = input[0].ToString();
                    secondArr[i] = input[1].ToString();
                }
                else
                {
                    secondArr[i] = input[0].ToString();
                    firstArr[i] = input[1].ToString();
                }
            }

            Console.WriteLine(String.Join(' ', firstArr));
            Console.WriteLine(String.Join(' ', secondArr));
        }
    }
}
