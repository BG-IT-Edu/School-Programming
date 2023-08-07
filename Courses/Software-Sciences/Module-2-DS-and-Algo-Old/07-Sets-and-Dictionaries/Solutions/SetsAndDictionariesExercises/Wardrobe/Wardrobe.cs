using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            var clothesColor = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ");

                string currentColor = input[0];
                string[] clothes = input[1]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!clothesColor.ContainsKey(currentColor))
                {
                    clothesColor.Add(currentColor, new Dictionary<string, int>());
                }

                foreach (var garment in clothes)
                {
                    if (!clothesColor[currentColor].ContainsKey(garment))
                    {
                        clothesColor[currentColor].Add(garment, 1);
                    }
                    else
                    {
                        clothesColor[currentColor][garment]++;
                    }
                }
            }

            string[] searchingGarment = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string searchColor = searchingGarment[0];
            string searchGarment = searchingGarment[1];


            foreach (var color in clothesColor)
            {
                Console.WriteLine($"{color.Key} clothes:");

                bool isThatColor = color.Key == searchColor;

                foreach (var garment in color.Value)
                {
                    if ((garment.Key == searchGarment) && isThatColor)
                    {
                        Console.WriteLine($"* {garment.Key} - {garment.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {garment.Key} - {garment.Value}");
                    }
                }
            }
        }
    }
}
