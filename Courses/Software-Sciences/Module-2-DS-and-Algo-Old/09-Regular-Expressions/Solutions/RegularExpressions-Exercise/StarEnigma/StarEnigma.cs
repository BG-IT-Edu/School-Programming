using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    class StarEnigma
    {
        static void Main(string[] args)
        {
            var attackedPlanets = new List<string>();
            var destroyedPlanets = new List<string>();

            var regexStar = new Regex(@"[STARstar]");

            var countInput = int.Parse(Console.ReadLine());

            for (var i = 0; i < countInput; i++)
            {
                var encryptedCode = Console.ReadLine();

                var starCollection = regexStar.Matches(encryptedCode);
                var decryptNum = starCollection.Count;

                var decryptedCode = new StringBuilder();

                foreach (var charachter in encryptedCode)
                {
                    decryptedCode.Append((char)(charachter - decryptNum));
                }

                var regex = new Regex(@"@(?<name>[A-Za-z]+)[^@\-!:>]*:\d+[^@\-!:>]*!(?<type>[A|D])![^@\-!:>]*->\d+");

                if (regex.IsMatch(decryptedCode.ToString()))
                {
                    var correctCode = regex.Match(decryptedCode.ToString());
                    var type = correctCode.Groups["type"].Value;
                    var name = correctCode.Groups["name"].Value;

                    switch (type)
                    {
                        case "A":
                            attackedPlanets.Add(name);
                            break;
                        case "D":
                            destroyedPlanets.Add(name);
                            break;
                    }
                }
            }
            attackedPlanets.Sort();
            destroyedPlanets.Sort();
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");

            if (attackedPlanets.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, attackedPlanets.Select(x => $"-> {x}")));
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");

            if (destroyedPlanets.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, destroyedPlanets.Select(x => $"-> {x}")));
            }
        }
    }
}
