using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class SoftUniBarIncome
    {
        static void Main(string[] args)
        {
            var result = new List<string>();
            double totalIncome = 0;

            var regex = new Regex(@"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|[^|$%.]*?(?<count>\d+)\|[^|$%.]*?(?<price>\d+\.*\d*)\$");

            string input;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                if (regex.IsMatch(input))
                {
                    var regexInput = regex.Match(input);

                    var name = regexInput.Groups["name"].Value;
                    var product = regexInput.Groups["product"].Value;
                    var count = int.Parse(regexInput.Groups["count"].Value);
                    var price = double.Parse(regexInput.Groups["price"].Value);

                    var total = count * price;

                    result.Add($"{name}: {product} - {total:F2}");
                    totalIncome += total;
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, result));
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}