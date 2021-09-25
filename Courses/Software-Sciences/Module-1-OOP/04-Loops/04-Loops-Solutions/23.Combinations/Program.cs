using System;

namespace _23.Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int combinationsCount = 0;
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    for (int k = 0; k <= n; k++)
                    {
                        if (i + j + k == n)
                        {
                            combinationsCount++;
                        }
                    }
                }
            }

            Console.WriteLine(combinationsCount);
        }
    }
}