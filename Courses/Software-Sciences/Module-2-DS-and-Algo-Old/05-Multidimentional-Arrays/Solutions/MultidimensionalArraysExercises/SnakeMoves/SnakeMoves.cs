using System;
using System.Linq;

namespace SnakeMoves
{
    class SnakeMoves
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];

            char[,] matrix = new char[rows, cols];

            string snakeName = Console.ReadLine();
            int counter = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snakeName[counter];
                        counter++;
                        if (counter == snakeName.Length)
                        {
                            counter = 0;
                        }
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snakeName[counter];
                        counter++;
                        if (counter == snakeName.Length)
                        {
                            counter = 0;
                        }
                    }
                }         
            }
            for (int rowPrint = 0; rowPrint < rows; rowPrint++)
            {
                for (int colPrint = 0; colPrint < cols; colPrint++)
                {
                    Console.Write(matrix[rowPrint, colPrint]);
                }
                Console.WriteLine();
            }
        }
    }
}
