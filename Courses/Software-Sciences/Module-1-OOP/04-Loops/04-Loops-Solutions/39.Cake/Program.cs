using System;

namespace _39.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());
            int cakeSize = cakeWidth * cakeLength;
            int totalPieces = 0;
            while (true)
            {
                string cakePieces = Console.ReadLine();

                if (cakePieces == "STOP")
                {
                    int piecesLeft = cakeSize - totalPieces;
                    Console.WriteLine($"{piecesLeft} pieces are left.");
                    break;
                }

                int cakePiece = int.Parse(cakePieces);
                totalPieces += cakePiece;
                if (totalPieces >= cakeSize)
                {
                    int piecesNeeded = cakeSize - totalPieces;
                    Console.WriteLine($"No more cake left! You need {Math.Abs(piecesNeeded)} pieces more.");
                    break;
                }
            }
        }
    }
}