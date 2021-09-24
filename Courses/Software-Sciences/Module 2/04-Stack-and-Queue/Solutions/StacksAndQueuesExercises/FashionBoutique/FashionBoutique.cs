using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class FashionBoutique
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> clothes = new Stack<int>(input);

            int capacity = int.Parse(Console.ReadLine());
            int boxes = 0;

            if (capacity > 0 && clothes.Count > 0 && clothes.Sum() > 0)
            {
                boxes = 1;
                int currentBox = capacity;

                while (clothes.Count > 0)
                {

                    int currentClothe = clothes.Peek();

                    if (currentBox >= currentClothe)
                    {
                        currentBox -= currentClothe;
                        clothes.Pop();
                    }
                    else if (currentBox < currentClothe)
                    {
                        currentBox = capacity;
                        boxes++;
                    }
                }
            }

            Console.WriteLine(boxes);
        }
    }
}
