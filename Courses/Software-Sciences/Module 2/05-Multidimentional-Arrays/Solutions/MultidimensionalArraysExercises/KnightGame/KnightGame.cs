using System;

namespace KnightGame
{
    class KnightGame
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] board = new char[size, size];
            board = FillTheMatrix(board);

            int maxAttacks = 0;
            int rowToRemove = 0;
            int colToRemove = 0;
            int removedKnights = 0;

            while (true)
            {
                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {

                        int attackedHorses = 0;

                        if (board[row, col] == 'K')
                        {
                            if (isValid(board, row - 2, col + 1) && board[row - 2, col + 1] == 'K')
                            {
                                attackedHorses++;
                            }
                            if (isValid(board, row - 2, col - 1) && board[row - 2, col - 1] == 'K')
                            {
                                attackedHorses++;
                            }
                            if (isValid(board, row - 1, col - 2) && board[row - 1, col - 2] == 'K')
                            {
                                attackedHorses++;
                            }
                            if (isValid(board, row + 1, col - 2) && board[row + 1, col - 2] == 'K')
                            {
                                attackedHorses++;
                            }
                            if (isValid(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K')
                            {
                                attackedHorses++;
                            }
                            if (isValid(board, row + 1, col + 2) && board[row + 1, col + 2] == 'K')
                            {
                                attackedHorses++;
                            }
                            if (isValid(board, row + 2, col + 1) && board[row + 2, col + 1] == 'K')
                            {
                                attackedHorses++;
                            }
                            if (isValid(board, row + 2, col - 1) && board[row + 2, col - 1] == 'K')
                            {
                                attackedHorses++;
                            }

                            if (attackedHorses > maxAttacks)
                            {
                                maxAttacks = attackedHorses;
                                rowToRemove = row;
                                colToRemove = col;
                            }
                        }
                    }
                }

                if (maxAttacks == 0)
                {
                    break;
                }

                board[rowToRemove, colToRemove] = '0';
                removedKnights++;
                maxAttacks = 0;
            }

            Console.WriteLine(removedKnights);
        }
        private static bool isValid(char[,] board, int row, int col)
        {
            return row >= 0 && row < board.GetLength(0)
                && col >= 0 && col < board.GetLength(1);
        }

        private static char[,] FillTheMatrix(char[,] board)
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = input[col];
                }
            }

            return board;
        }
    }
}
