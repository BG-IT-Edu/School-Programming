using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class NetherRealms
    {
        static void Main(string[] args)
        {
            var separator = new Regex(@"\s*,\s*");
            var healthRegex = new Regex(@"[^\d+\-\/*.]");
            var numbersRegex = new Regex(@"-?\d+\.?\d*");
            var divOrMultRegex = new Regex(@"[*\/]");

            var result = new List<string>();

            var input = Console.ReadLine();
            var splitedInput = separator.Split(input);

            foreach (var name in splitedInput)
            {
                var health = 0;
                var healthChars = healthRegex.Matches(name);

                foreach (Match character in healthChars)
                {
                    health += char.Parse(character.Value);
                }

                double damage = 0;

                if (numbersRegex.IsMatch(name))
                {
                    var numbers = numbersRegex.Matches(name);
                    foreach (Match number in numbers)
                    {
                        damage += double.Parse(number.Value);
                    }
                    if (divOrMultRegex.IsMatch(name))
                    {
                        var elements = divOrMultRegex.Matches(name);
                        foreach (Match element in elements)
                        {
                            switch (element.Value)
                            {
                                case "/":
                                    damage /= 2;
                                    break;
                                case "*":
                                    damage *= 2;
                                    break;
                            }
                        }
                    }
                }

                result.Add($"{name} - {health} health, {damage:F2} damage");
            }

            result.Sort();
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
