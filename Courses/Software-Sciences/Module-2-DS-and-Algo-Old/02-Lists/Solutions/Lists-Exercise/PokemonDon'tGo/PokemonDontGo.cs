using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDon_tGo
{
    class PokemonDontGo
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int sum = 0;

            while (pokemons.Count > 0)
            {
                int currentIndex = int.Parse(Console.ReadLine());

                if (currentIndex < 0)
                {
                    int currentValue = pokemons[0];
                    sum += currentValue;
                    pokemons[0] = pokemons[pokemons.Count - 1];

                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= currentValue)
                        {
                            pokemons[i] += currentValue;
                        }
                        else
                        {
                            pokemons[i] -= currentValue;
                        }
                    }
                }
                else if (currentIndex >= pokemons.Count)
                {
                    int currentValue = pokemons[pokemons.Count - 1];
                    sum += currentValue;

                    pokemons[pokemons.Count - 1] = pokemons[0];
                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= currentValue)
                        {
                            pokemons[i] += currentValue;
                        }
                        else
                        {
                            pokemons[i] -= currentValue;
                        }
                    }
                }
                else
                {
                    int currentValue = pokemons[currentIndex];
                    sum += currentValue;
                    pokemons.RemoveAt(currentIndex);

                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= currentValue)
                        {
                            pokemons[i] += currentValue;
                        }
                        else
                        {
                            pokemons[i] -= currentValue;
                        }
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
