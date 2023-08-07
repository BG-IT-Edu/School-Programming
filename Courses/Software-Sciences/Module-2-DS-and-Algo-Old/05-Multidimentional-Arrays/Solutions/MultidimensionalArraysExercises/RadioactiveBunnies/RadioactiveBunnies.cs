using System;
using System.Collections.Generic;
using System.Linq;

namespace RadioactiveBunnies
{
    class RadioactiveBunnies
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = size[0];
            int cols = size[1];

            char[,] lair = new char[rows, cols];

            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < lair.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    lair[row, col] = input[col];

                    if (lair[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;

                        lair[row, col] = '.';
                    }
                }
            }

            string commands = Console.ReadLine();
            string result = String.Empty;
            bool isPlayerWin = false;
            bool isGameOver = false;

            foreach (var command in commands)
            {
                if (isGameOver)
                {
                    break;
                }
                if (lair[playerRow, playerCol] == 'B')
                {
                    isPlayerWin = false;
                    isGameOver = true;
                    break;
                }

                //Move player
                switch (command)
                {
                    case 'L':
                        if (IsValid(lair, playerRow, playerCol - 1))
                        {
                            playerCol--;
                        }
                        else
                        {
                            isPlayerWin = true;
                            isGameOver = true;
                        }
                        break;
                    case 'R':
                        if (IsValid(lair, playerRow, playerCol + 1))
                        {
                            playerCol++;
                        }
                        else
                        {
                            isPlayerWin = true;
                            isGameOver = true;
                        }
                        break;
                    case 'U':
                        if (IsValid(lair, playerRow - 1, playerCol))
                        {
                            playerRow--;
                        }
                        else
                        {
                            isPlayerWin = true;
                            isGameOver = true;
                        }
                        break;
                    case 'D':
                        if (IsValid(lair, playerRow + 1, playerCol))
                        {
                            playerRow++;
                        }
                        else
                        {
                            isPlayerWin = true;
                            isGameOver = true;
                        }
                        break;
                }

                if (lair[playerRow, playerCol] == 'B')
                {
                    isPlayerWin = false;
                    isGameOver = true;
                }

                //Spread bunnies
                List<int[]> bunniesPosition = GetCurrentBunniesPosition(lair);
                SpreadBunnies(lair, bunniesPosition);
            }

            PrintLair(lair);
            if (isPlayerWin)
            {
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }
            else if (isGameOver)
            {
                Console.WriteLine($"dead: {playerRow} {playerCol}");
            }
        }
        private static void SpreadBunnies(char[,] lair, List<int[]> bunniesPosition)
        {
            foreach (var position in bunniesPosition)
            {
                int row = position[0];
                int col = position[1];

                if (IsValid(lair, row, col - 1))
                {
                    lair[row, col - 1] = 'B';
                }
                if (IsValid(lair, row, col + 1))
                {
                    lair[row, col + 1] = 'B';
                }
                if (IsValid(lair, row - 1, col))
                {
                    lair[row - 1, col] = 'B';
                }
                if (IsValid(lair, row + 1, col))
                {
                    lair[row + 1, col] = 'B';
                }
            }
        }

        private static void PrintLair(char[,] lair)
        {
            for (int row = 0; row < lair.GetLength(0); row++)
            {
                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    Console.Write(lair[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static List<int[]> GetCurrentBunniesPosition(char[,] lair)
        {
            List<int[]> positions = new List<int[]>();

            for (int row = 0; row < lair.GetLength(0); row++)
            {
                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    if (lair[row, col] == 'B')
                    {
                        positions.Add(new[] { row, col });
                    }
                }
            }

            return positions;
        }

        private static bool IsValid(char[,] lair, int row, int col)
        {
            return row >= 0 && row < lair.GetLength(0)
                  && col >= 0 && col < lair.GetLength(1);
        }
    }
}
