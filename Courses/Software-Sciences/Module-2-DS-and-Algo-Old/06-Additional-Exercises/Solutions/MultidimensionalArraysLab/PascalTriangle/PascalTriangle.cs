using System;

namespace PascalTriangle
{
    class PascalTriangle
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            long[][] pascalTriangle = new long[rows][];

            int currentCol = 1;

            for (long row = 0; row < pascalTriangle.GetLength(0); row++)
            {
                pascalTriangle[row] = new long[currentCol];
                long[] currentRow = pascalTriangle[row];
                currentRow[0] = 1;
                currentRow[currentRow.Length - 1] = 1;
                currentCol++;

                if (currentRow.Length > 2)
                {
                    for (int i = 1; i < currentRow.Length - 1; i++)
                    {
                        long[] previousRow = pascalTriangle[row - 1];
                        long previousRowSum = previousRow[i] + previousRow[i - 1];
                        currentRow[i] = previousRowSum;
                    }
                }

            }

            foreach (long[] item in pascalTriangle)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }
    }
}
