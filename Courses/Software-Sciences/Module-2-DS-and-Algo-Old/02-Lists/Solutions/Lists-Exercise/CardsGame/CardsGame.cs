using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class CardsGame
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondDeck = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> firstDeckNew = firstDeck;
            List<int> secondDeckNew = secondDeck;

            while (true)
            {
                int firstPlayer = firstDeck[0];
                int secondPlayer = secondDeck[0];

                if (firstPlayer > secondPlayer)
                {
                    firstDeckNew.Remove(firstPlayer);
                    secondDeckNew.Remove(secondPlayer);
                    firstDeckNew.Add(firstPlayer);
                    firstDeckNew.Add(secondPlayer);
                }
                else if (firstPlayer < secondPlayer)
                {
                    firstDeckNew.Remove(firstPlayer);
                    secondDeckNew.Remove(secondPlayer);
                    secondDeckNew.Add(secondPlayer);
                    secondDeckNew.Add(firstPlayer);
                }
                else
                {
                    firstDeckNew.Remove(firstPlayer);
                    secondDeckNew.Remove(secondPlayer);
                }

                firstDeck = firstDeckNew;
                secondDeck = secondDeckNew;

                if (firstDeck.Sum() == 0 || secondDeck.Sum() == 0)
                {
                    break;
                }
            }

            Console.WriteLine(secondDeck.Sum() > 0
                ? $"Second player wins! Sum: {secondDeck.Sum()}"
                : $"First player wins! Sum: {firstDeck.Sum()}");
        }
    }
}
