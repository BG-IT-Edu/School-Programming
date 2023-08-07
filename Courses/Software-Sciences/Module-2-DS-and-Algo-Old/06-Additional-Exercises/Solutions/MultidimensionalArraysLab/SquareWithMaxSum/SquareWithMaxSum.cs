using System;
using System.Linq;

namespace SquareWithMaxSum
{
    class SquareWithMaxSum
    {
        static void Main(string[] args)
        {
            int[] matrixParametars = Console.ReadLine()
                  .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();

            int[,] matrix = new int[matrixParametars[0], matrixParametars[1]];
            int maxSum = int.MinValue;
            int startRow = 0;
            int startCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        startRow = row;
                        startCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[startRow, startCol]} {matrix[startRow, startCol + 1]} \n{matrix[startRow + 1, startCol]} {matrix[startRow + 1, startCol + 1]} \n{maxSum}");
        
    }
    }
}
