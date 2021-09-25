using System;
using System.Collections.Generic;
using System.Linq;

namespace Classification
{
    class Classification
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();

            string[] contestInput = Console.ReadLine()
                .Split(":", StringSplitOptions.RemoveEmptyEntries);

            while (contestInput[0] != "the contests are ended")
            {
                string name = contestInput[0];
                string password = contestInput[1];

                contests[name] = password;

                contestInput = Console.ReadLine()
               .Split(":", StringSplitOptions.RemoveEmptyEntries);
            }

            var candidates = new Dictionary<string, Dictionary<string, int>>();

            string[] candidateInput = Console.ReadLine().Split("=>");

            while (candidateInput[0] != "the submissions are ended")
            {
                string contestName = candidateInput[0];
                string contestPass = candidateInput[1];
                string candidateName = candidateInput[2];
                int points = int.Parse(candidateInput[3]);

                if (!contests.ContainsKey(contestName) ||
                    contests[contestName] != contestPass)
                {
                    candidateInput = Console.ReadLine().Split("=>");
                    continue;
                }

                if (!candidates.ContainsKey(candidateName))
                {
                    candidates.Add(candidateName, new Dictionary<string, int>());
                }

                if (!candidates[candidateName].ContainsKey(contestName))
                {
                    candidates[candidateName].Add(contestName, points);
                }
                else if (candidates[candidateName].ContainsKey(contestName))
                {
                    if (candidates[candidateName][contestName] < points)
                    {
                        candidates[candidateName][contestName] = points;
                    }
                }

                candidateInput = Console.ReadLine().Split("=>");
            }

            var bestCandidate = candidates
                .OrderByDescending(v => v.Value.Values.Sum())
                .FirstOrDefault();

            string bestName = bestCandidate.Key;
            int bestPoints = bestCandidate.Value.Values.Sum();

            Console.WriteLine($"Candidate number one is {bestName} with total {bestPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var (student, value) in candidates.OrderBy(x => x.Key))
            {
                Console.WriteLine(student);

                foreach (var (contestname, points) in value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contestname} -> {points}");
                }
            }
        }
    }
}
