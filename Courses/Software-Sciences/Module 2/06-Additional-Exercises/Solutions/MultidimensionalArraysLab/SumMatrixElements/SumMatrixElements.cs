using System;
using System.Collections.Generic;
using System.Linq;

namespace SumMatrixElements
{
    class SumMatrixElements
    {
        static void Main(string[] args)
        {
            List<int> parametarsOfMatrix = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[,] matrix = new int[parametarsOfMatrix[0], parametarsOfMatrix[1]];
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                    sum += input[col];
                }
            }

            Console.WriteLine($"{parametarsOfMatrix[0]} \n{parametarsOfMatrix[1]} \n{sum}");
        }
    }
}
