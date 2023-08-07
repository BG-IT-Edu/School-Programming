using System;
using System.Collections.Generic;

namespace ProductShop
{
    class ProductShop
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            var supermarkets = new SortedDictionary<string, Dictionary<string, double>>();

            while (input[0] != "Revision")
            {
                string marketName = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (supermarkets.ContainsKey(marketName))
                {
                    supermarkets[marketName].Add(product, price);
                }
                else
                {
                    supermarkets.Add(marketName, new Dictionary<string, double>());
                    supermarkets[marketName].Add(product, price);
                }

                input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var market in supermarkets)
            {
                Console.WriteLine($"{market.Key}->");

                foreach (var product in market.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
