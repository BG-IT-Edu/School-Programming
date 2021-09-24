using System;
using System.Linq;

namespace Bombs
{
    class Bombs
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];
            matrix = FillTheMatrix(matrix);

            int[] coordinates = Console.ReadLine()
                .Split(new char[] { ',', ' ' })
                .Select(int.Parse)
                .ToArray();


            for (int i = 0; i < coordinates.Length; i += 2)
            {
                int currentRow = coordinates[i];
                int currentCol = coordinates[i + 1];

                if (matrix[currentRow, currentCol] > 0)
                {

                    int value = matrix[currentRow, currentCol];
                    matrix[currentRow, currentCol] = 0;

                    if (isValid(matrix, currentRow - 1, currentCol)
                        && matrix[currentRow - 1, currentCol] > 0)
                    {
                        matrix[currentRow - 1, currentCol] -= value;
                    }
                    if (isValid(matrix, currentRow - 1, currentCol + 1)
                         && matrix[currentRow - 1, currentCol + 1] > 0)
                    {
                        matrix[currentRow - 1, currentCol + 1] -= value;
                    }
                    if (isValid(matrix, currentRow - 1, currentCol - 1)
                         && matrix[currentRow - 1, currentCol - 1] > 0)
                    {
                        matrix[currentRow - 1, currentCol - 1] -= value;
                    }
                    if (isValid(matrix, currentRow, currentCol + 1)
                         && matrix[currentRow, currentCol + 1] > 0)
                    {
                        matrix[currentRow, currentCol + 1] -= value;
                    }
                    if (isValid(matrix, currentRow, currentCol - 1)
                         && matrix[currentRow, currentCol - 1] > 0)
                    {
                        matrix[currentRow, currentCol - 1] -= value;
                    }
                    if (isValid(matrix, currentRow + 1, currentCol)
                         && matrix[currentRow + 1, currentCol] > 0)
                    {
                        matrix[currentRow + 1, currentCol] -= value;
                    }
                    if (isValid(matrix, currentRow + 1, currentCol + 1)
                         && matrix[currentRow + 1, currentCol + 1] > 0)
                    {
                        matrix[currentRow + 1, currentCol + 1] -= value;
                    }
                    if (isValid(matrix, currentRow + 1, currentCol - 1)
                         && matrix[currentRow + 1, currentCol - 1] > 0)
                    {
                        matrix[currentRow + 1, currentCol - 1] -= value;
                    }
                }
            }

            int activeCells = 0;
            int sumOfAC = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        activeCells++;
                        sumOfAC += matrix[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {activeCells} \nSum: {sumOfAC}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }
        private static bool isValid(int[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0)
            && col >= 0 && col < matrix.GetLength(1);
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
