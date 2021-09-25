using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Furniture
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@">>(?<name>[A-z]+)<<(?<price>\d+\.*\d*)!(?<quantity>\d+)");

            var furniture = new List<string>();
            double total = 0;
            string input;

            while ((input = Console.ReadLine()) != "Purchase")
            {
                if (regex.IsMatch(input))
                {
                    var matchInput = regex.Match(input);
                    var name = matchInput.Groups["name"].Value;
                    var price = double.Parse(matchInput.Groups["price"].Value);
                    var quantity = int.Parse(matchInput.Groups["quantity"].Value);

                    furniture.Add(name);
                    total += price * quantity;
                }
            }

            Console.WriteLine("Bought furniture:");

            foreach (var item in furniture)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total money spent: {total:F2}");
        }
    }
}