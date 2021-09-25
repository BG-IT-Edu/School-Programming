using System;
using System.Linq;

namespace MatrixChangings
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixParameters = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[matrixParameters[0], matrixParameters[1]];
            matrix = FillTheMatrix(matrix);

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "END")
            {
                bool isValidCommand = IsValidCommand(matrixParameters, command);

                if (isValidCommand)
                {
                    int row1 = int.Parse(command[1]);
                    int col1 = int.Parse(command[2]);
                    int row2 = int.Parse(command[3]);
                    int col2 = int.Parse(command[4]);

                    string firstCell = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = firstCell;

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write($"{matrix[row, col]} ");
                        }

                        Console.WriteLine();
                    }

                }
                else if (!isValidCommand)
                {
                    Console.WriteLine("The input is invalid!");
                }

                command = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }
        private static bool IsValidCommand(int[] parameters, string[] command)
        {
            bool isValid = false;

            if (command[0] == "exchange" && command.Length == 5)
            {
                int row1 = int.Parse(command[1]);
                int col1 = int.Parse(command[2]);
                int row2 = int.Parse(command[3]);
                int col2 = int.Parse(command[4]);

                if (row1 >= 0 && row1 < parameters[0] &&
                    col1 >= 0 && col1 < parameters[1] &&
                    row2 >= 0 && row2 < parameters[0] &&
                    col2 >= 0 && col2 < parameters[1])
                {
                    isValid = true;
                }

            }

            return isValid;
        }

        private static string[,] FillTheMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            return matrix;
        }
    }
}
