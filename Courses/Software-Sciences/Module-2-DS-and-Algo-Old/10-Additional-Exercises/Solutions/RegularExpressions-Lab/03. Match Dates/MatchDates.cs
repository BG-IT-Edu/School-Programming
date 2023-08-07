using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class MatchDates
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(?<day>\d{2})([-.\/])(?<mont>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            var inputDates = Console.ReadLine();

            var matchesDates = Regex.Matches(inputDates, pattern);

            foreach (Match date in matchesDates)
            {
                var result = $"Day: {date.Groups["day"].Value}, Month: {date.Groups["mont"].Value}, Year: {date.Groups["year"].Value}";
                Console.WriteLine(result);
            }
        }
    }
}