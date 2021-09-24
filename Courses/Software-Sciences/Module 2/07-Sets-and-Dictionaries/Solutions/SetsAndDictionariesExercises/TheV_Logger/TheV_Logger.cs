using System;
using System.Collections.Generic;
using System.Linq;

namespace TheV_Logger
{
    class TheV_Logger
    {
        static void Main(string[] args)
        {
            var vloggers = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "Statistics")
            {
                string firstVlogger = command[0];
                string currentCommand = command[1];
                string secondVlogger = command[2];

                switch (currentCommand)
                {
                    case "joined":
                        if (!vloggers.ContainsKey(firstVlogger))
                        {
                            vloggers.Add(firstVlogger, new Dictionary<string, HashSet<string>>());
                            vloggers[firstVlogger].Add("followers", new HashSet<string>());
                            vloggers[firstVlogger].Add("following", new HashSet<string>());
                        }
                        break;
                    case "followed":
                        if (!vloggers.ContainsKey(firstVlogger) ||
                            !vloggers.ContainsKey(secondVlogger) ||
                            firstVlogger == secondVlogger ||
                            vloggers[secondVlogger].ContainsKey(firstVlogger))
                        {
                            break;
                        }

                        vloggers[firstVlogger]["following"].Add(secondVlogger);
                        vloggers[secondVlogger]["followers"].Add(firstVlogger);
                        break;
                }

                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Keys.Count} vloggers in its logs.");

            int count = 1;

            var sortedVloggers = vloggers
                .OrderByDescending(x => x.Value["followers"].Count)
                .ThenBy(x => x.Value["following"].Count)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var (vlogger, value) in sortedVloggers)
            {
                Console.WriteLine($"{count}. {vlogger} : {value["followers"].Count} followers, {value["following"].Count} following");

                if (count == 1)
                {
                    foreach (var follower in value["followers"].OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                count++;
            }
        }
    }
}
