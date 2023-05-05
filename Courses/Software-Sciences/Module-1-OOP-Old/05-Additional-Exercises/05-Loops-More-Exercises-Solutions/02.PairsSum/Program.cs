using System;

namespace _02.PairsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                int sum = firstNum + secondNum;

                if (sum > n)
                {
                    Console.WriteLine("Bigger Sum!");
                }
            }
        }
    }
}