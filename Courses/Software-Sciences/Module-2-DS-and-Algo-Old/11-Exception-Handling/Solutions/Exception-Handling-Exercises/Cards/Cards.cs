using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards
{
    class Cards
    {
        static void Main(string[] args)
        {

            var cardsToCreate = Console.ReadLine().Split(", ").ToArray();
            
            var cards = new List<Card>();

            foreach (var cardToCreate in cardsToCreate)
            {
                var validFaces = new[] { "A", "K", "Q", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
                var validSuites = new Dictionary<string, string>() {
                    {"S", "\u2660"},
                    {"H", "\u2665"},
                    {"D", "\u2666"},
                    {"C", "\u2663"}
                };

                var cardElements = cardToCreate.Split(" ").ToArray();
                var face = cardElements[0];
                var suit = cardElements[1];

                try
                {
                    if (!validFaces.Contains(face) || !validSuites.ContainsKey(suit))
                    {
                        throw new Exception("Invalid card!");
                    }

                    var card = new Card();
                    card.Face = face;
                    card.Suit = validSuites[suit];
                    cards.Add(card);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine(string.Join(' ', cards));
        }

        public class Card
        {
            public string Face { get; set; }
            public string Suit { get; set; }
            public override string ToString()
            {
                return $"[{this.Face}{this.Suit}]";
            }
        }
    }
}
