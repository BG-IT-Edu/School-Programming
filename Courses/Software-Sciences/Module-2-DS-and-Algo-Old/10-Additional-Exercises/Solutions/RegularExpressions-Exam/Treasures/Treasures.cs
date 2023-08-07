using System;
using System.Text.RegularExpressions;

namespace Treasures
{
    class Treasures
    {
        static void Main(string[] args)
        {
            Regex metalPattern = new Regex(@"@(?<metal>[\S\s]*?)\|");
            Regex gemPattern = new Regex(@"#(?<gem>[\S\s]*?)\*");

            string input = Console.ReadLine();

            var metal = metalPattern.Match(input).Groups["metal"].ToString();
            var gem = gemPattern.Match(input).Groups["gem"].ToString();

            Console.WriteLine($"Found hidden {metal} and {gem} in the cave.");
        }
    }
}
