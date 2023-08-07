using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] detonation = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int bomb = detonation[0];
            int power = detonation[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    int leftBombPower = power;

                    if (i - power < 0)
                    {
                        leftBombPower = i;
                    }

                    for (int j = 0; j < leftBombPower; j++)
                    {
                        numbers.RemoveAt(i - leftBombPower);
                    }

                    int indexOfTheBombAfterTheLeftDetonations = i - leftBombPower;
                    int rightBombPower = power;

                    if (indexOfTheBombAfterTheLeftDetonations + power >= numbers.Count)
                    {
                        rightBombPower = numbers.Count - indexOfTheBombAfterTheLeftDetonations - 1;
                    }

                    for (int j = 0; j < rightBombPower; j++)
                    {
                        numbers.RemoveAt(indexOfTheBombAfterTheLeftDetonations + 1);
                    }

                    numbers.RemoveAt(indexOfTheBombAfterTheLeftDetonations);

                    i = indexOfTheBombAfterTheLeftDetonations - 1;
                }
            }

            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
