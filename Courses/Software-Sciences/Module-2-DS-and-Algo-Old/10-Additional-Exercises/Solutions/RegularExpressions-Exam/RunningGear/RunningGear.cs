using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RunningGear
{
    class RunningGear
    {
        static void Main()
        {
            var regex = new Regex(@"<>(?<name>[A-z]+)<>(?<quantity>\d+)--(?<price>\d+\.*\d*)");

            var gear = new List<string>();
            var total = 0.0;
            string input;

            while ((input = Console.ReadLine()) != "Run!")
            {
                if (regex.IsMatch(input))
                {
                    var matchInput = regex.Match(input);
                    var name = matchInput.Groups["name"].Value;
                    var quantity = int.Parse(matchInput.Groups["quantity"].Value);
                    var price = double.Parse(matchInput.Groups["price"].Value);

                    gear.Add(name);
                    total += price * quantity;
                }
            }

            Console.WriteLine("Gear bought:");

            foreach (var item in gear)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total cost: {total:F2}");
        }
    }
}
