using System;
using System.Linq;

namespace DifferenceOfDiagonals
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];
            matrix = FillTheMatrix(matrix);

            int sumOfPrimaryDiagonal = GetsPrimarySum(matrix);
            int sumOfSecondaryDiagonal = GetsSecondarySum(matrix);

            int difference = Math.Abs(sumOfPrimaryDiagonal - sumOfSecondaryDiagonal);
            Console.WriteLine(difference);
        }

        private static int GetsSecondarySum(int[,] matrix)
        {
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    sum += matrix[row, col];
                    row++;
                }

                break;
            }

            return sum;
        }

        private static int GetsPrimarySum(int[,] matrix)
        {
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, row];
                    break;
                }
            }

            return sum;
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
