using System;
using System.Linq;

namespace JaggedArrays
{
    class JaggedArrays
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            double[][] matrix = new double[numberOfRows][];

            for (int i = 0; i < numberOfRows; i++)
            {
                matrix[i] = Console.ReadLine().Split().Select(double.Parse).ToArray();
            }

            for (int i = 0; i < matrix.Length - 1; i++)
            {
                if (matrix[i].Length == matrix[i + 1].Length)
                {
                    matrix[i] = matrix[i].Select(x => x * 2).ToArray();
                    matrix[i + 1] = matrix[i + 1].Select(x => x * 2).ToArray();
                }
                else
                {
                    matrix[i] = matrix[i].Select(x => x / 2).ToArray();
                    matrix[i + 1] = matrix[i + 1].Select(x => x / 2).ToArray();
                }
            }

            string[] commandTokens = Console.ReadLine().Split().ToArray();
            while (commandTokens[0] != "End")
            {
                int row = int.Parse(commandTokens[1]);
                int column = int.Parse(commandTokens[2]);
                int value = int.Parse(commandTokens[3]);

                if (commandTokens[0] == "Add")
                {
                    if (row >= 0 && row < matrix.Length && column >= 0 && column < matrix[row].Length)
                    {
                        matrix[row][column] += value;
                    }
                }
                else if (commandTokens[0] == "Subtract")
                {
                    if (row >= 0 && row < matrix.Length && column >= 0 && column < matrix[row].Length)
                    {
                        matrix[row][column] -= value;
                    }
                }

                commandTokens = Console.ReadLine().Split().ToArray();
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(' ', row));
            }
        }
    }
}
