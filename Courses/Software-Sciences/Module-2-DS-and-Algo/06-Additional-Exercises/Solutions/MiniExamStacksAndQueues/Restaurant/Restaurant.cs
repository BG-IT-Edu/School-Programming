using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant
{
    class Restaurant
    {
        static void Main(string[] args)
        {
            int quantityOfMyFood = int.Parse(Console.ReadLine());
            int[] inputFoods = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> foods = new Queue<int>(inputFoods);

            Console.WriteLine(foods.Max());

            while (foods.Count > 0)
            {
                if (quantityOfMyFood - foods.Peek() >= 0)
                {
                    quantityOfMyFood -= foods.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", foods)}");
                    return;
                }
            }
            Console.WriteLine("All orders are completed");
        }
    }
}
