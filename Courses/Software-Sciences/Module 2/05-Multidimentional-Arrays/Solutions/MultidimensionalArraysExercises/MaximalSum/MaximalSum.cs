using System;
using System.Linq;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int[] matrixParameters = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[matrixParameters[0], matrixParameters[1]];
            matrix = FillTheMatrix(matrix);

            int maxSum = int.MinValue;
            int startRow = -1;
            int startCol = -1;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                int sum = 0;

                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        startRow = row;
                        startCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[startRow, startCol]} {matrix[startRow, startCol + 1]} {matrix[startRow, startCol + 2]}\n" +
                $"{matrix[startRow + 1, startCol]} {matrix[startRow + 1, startCol + 1]} {matrix[startRow + 1, startCol + 2]}\n" +
                $"{matrix[startRow + 2, startCol]} {matrix[startRow + 2, startCol + 1]} {matrix[startRow + 2, startCol + 2]}");
        }
        private static int[,] FillTheMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            return matrix;
        }
    }
}
