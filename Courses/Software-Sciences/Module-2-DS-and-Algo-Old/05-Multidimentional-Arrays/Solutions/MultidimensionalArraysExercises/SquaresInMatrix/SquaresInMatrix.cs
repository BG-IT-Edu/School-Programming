using System;
using System.Linq;

namespace SquaresInMatrix
{
    class SquaresInMatrix
    {
        static void Main(string[] args)
        {

            int[] matrixParameters = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[matrixParameters[0], matrixParameters[1]];
            matrix = FillTheMatrix(matrix);

            int countOfSquaMatrixes = Find2x2MatrixesWithEqualChars(matrix);
            Console.WriteLine(countOfSquaMatrixes);
        }
        private static int Find2x2MatrixesWithEqualChars(char[,] matrix)
        {
            int count = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    char firstChar = matrix[row, col];
                    char secondChar = matrix[row, col + 1];
                    char thirdChar = matrix[row + 1, col];
                    char fourthChar = matrix[row + 1, col + 1];

                    if (firstChar == secondChar && firstChar == thirdChar && firstChar == fourthChar)
                    {
                        count++;
                    }

                }
            }

            return count;
        }

        private static char[,] FillTheMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
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
