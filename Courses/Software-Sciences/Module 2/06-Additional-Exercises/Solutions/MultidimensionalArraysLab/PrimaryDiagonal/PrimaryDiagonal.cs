using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class PrimaryDiagonal
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] squareMatrix = new int[size, size];

            int sumOfDiagonal = 0;

            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    squareMatrix[row, col] = input[col];

                    if (row == col)
                    {
                        sumOfDiagonal += squareMatrix[row, col];
                    }
                }
            }


            Console.WriteLine(sumOfDiagonal);
        }
    }
}
