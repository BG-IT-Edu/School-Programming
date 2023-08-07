using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class CupsAndBottles
    {
        static void Main(string[] args)
        {
            int[] cupsCapacityInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] bottleCountInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> cups = new Queue<int>(cupsCapacityInput);
            Stack<int> bottles = new Stack<int>(bottleCountInput);


            int wastedWater = 0;
            int currentCup = 0;

            bool isCupEmpty = true;

            while (cups.Count > 0 && bottles.Count > 0)
            {
                int currentBottle = bottles.Pop();

                if (isCupEmpty)
                {
                    currentCup = cups.Peek();
                }

                if (currentBottle - currentCup >= 0)
                {
                    wastedWater += currentBottle - currentCup;
                    cups.Dequeue();
                    isCupEmpty = true;
                }
                else if (currentBottle - currentCup < 0)
                {
                    currentCup = Math.Abs(currentBottle - currentCup);
                    isCupEmpty = false;
                }
            }

            if (cups.Count > 0)
            {
                Console.WriteLine($"Cups: {String.Join(" ", cups)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            else
            {
                Console.WriteLine($"Bottles: {String.Join(" ", bottles)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
        }
    }
}
