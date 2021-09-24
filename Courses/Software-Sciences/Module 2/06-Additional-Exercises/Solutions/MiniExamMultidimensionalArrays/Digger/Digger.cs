using System;
using System.Linq;

namespace Digger
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] field = new char[size, size];
            string[] commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            field = FillTheMatrix(field);

            byte[] positionAndCoalCount = new byte[3];
            positionAndCoalCount = FindPositionAndCoalCount(field, positionAndCoalCount);

            int minerRow = positionAndCoalCount[0];
            int minerCol = positionAndCoalCount[1];
            int coalCount = positionAndCoalCount[2];
            int colectedCoal = 0;

            for (int i = 0; i < commands.Length; i++)
            {
                bool isValid = false;

                switch (commands[i])
                {
                    case "left":
                        if (IsValid(field, minerRow, minerCol - 1))
                        {
                            minerCol--;
                            isValid = true;
                        }
                        IsRegularPosition(field, minerRow, minerCol);
                        break;
                    case "right":
                        if (IsValid(field, minerRow, minerCol + 1))
                        {
                            minerCol++;
                            isValid = true;
                        }
                        break;
                    case "up":
                        if (IsValid(field, minerRow - 1, minerCol))
                        {
                            minerRow--;
                            isValid = true;
                        }
                        break;
                    case "down":
                        if (IsValid(field, minerRow + 1, minerCol))
                        {
                            minerRow++;
                            isValid = true;
                        }
                        break;

                }

                if (isValid)
                {
                    switch (field[minerRow, minerCol])
                    {
                        case 'r':
                            coalCount--;
                            colectedCoal++;
                            field[minerRow, minerCol] = '*';

                            if (coalCount == 0)
                            {
                                Console.WriteLine($"All rocks are collected! ({minerRow}, {minerCol})");
                                return;
                            }
                            break;
                        case 'e':
                            Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                            return;
                    }
                }
            }

            Console.WriteLine($"{coalCount} rocks left. ({minerRow}, {minerCol})");
        }

        private static void IsRegularPosition(char[,] field, int row, int col)
        {
            char currentChar = field[row, col];
        }

        private static bool IsValid(char[,] field, int row, int col)
        {
            return row >= 0 && row < field.GetLength(0)
                && col >= 0 && col < field.GetLength(1);
        }

        private static byte[] FindPositionAndCoalCount(char[,] field, byte[] positionOfMiner)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == 's')
                    {
                        positionOfMiner[0] = (byte)row;
                        positionOfMiner[1] = (byte)col;
                    }
                    else if (field[row, col] == 'r')
                    {
                        positionOfMiner[2]++;
                    }
                }
            }

            return positionOfMiner;
        }

        private static char[,] FillTheMatrix(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                char[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = input[col];
                }
            }

            return field;
        }
    }
}
