using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Championship
{
    class Championship
    {
        static void Main(string[] args)
        {
            var racers = Console.ReadLine().Split(", ").ToList();
            var racersScores = new Dictionary<string, int>();

            var regexChar = new Regex(@"([A-Z]|[a-z])");
            var regexNumber = new Regex(@"\d");
            string input;

            while ((input = Console.ReadLine()) != "end of race")
            {
                var chars = regexChar.Matches(input);
                var numbers = regexNumber.Matches(input);

                var racer = string.Join("", chars);
                var sum = 0;

                foreach (Match num in numbers)
                {
                    sum += int.Parse(num.ToString());
                }

                if (racers.Contains(racer))
                {
                    if (!racersScores.ContainsKey(racer))
                    {
                        racersScores[racer] = 0;
                    }
                    racersScores[racer] += sum;
                }
            }

            racersScores = racersScores.OrderByDescending(x => x.Value).Take(3).ToDictionary(x => x.Key, x => x.Value);
            var first = string.Empty;
            var second = string.Empty;
            var third = string.Empty;

            var counter = 1;

            foreach (var racer in racersScores)
            {
                switch (counter)
                {
                    case 1:
                        first = racer.Key;
                        break;
                    case 2:
                        second = racer.Key;
                        break;
                    case 3:
                        third = racer.Key;
                        break;
                }

                counter++;
            }

            Console.WriteLine($"1st place: {first}");
            Console.WriteLine($"2nd place: {second}");
            Console.WriteLine($"3rd place: {third}");
        }
    }
}
