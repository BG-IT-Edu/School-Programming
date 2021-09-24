using System;
using System.Collections.Generic;
using System.Linq;

namespace FootbalTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                try
                {
                    string[] cmdArgs = command.Split(';');
                    string cmdType = cmdArgs[0];
                    string teamName = cmdArgs[1];
                    if (cmdType == "Team")
                    {
                        teams.Add(new Team(teamName));
                        continue;
                    }
                    else if (cmdType == "Rating")
                    {
                        if (teams.Any(x => x.Name == teamName) == false)
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }
                        Team team = teams.FirstOrDefault(x => x.Name == teamName);
                        Console.WriteLine($"{team.Name} - {team.Rating}");
                    }
                    else if (cmdType == "Add")
                    {
                        if (teams.Any(x => x.Name == teamName) == false)
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }
                        Stat stat = new Stat(int.Parse(cmdArgs[3]), int.Parse(cmdArgs[4]),
                            int.Parse(cmdArgs[5]), int.Parse(cmdArgs[6]), int.Parse(cmdArgs[7]));
                        Player newPlayer = new Player(cmdArgs[2], stat);
                        Team team = teams.FirstOrDefault(x => x.Name == teamName);
                        team.Add(newPlayer);
                    }
                    else if (cmdType == "Remove")
                    {
                        Team team = teams.FirstOrDefault(x => x.Name == teamName);
                        team.Remove(cmdArgs[2]);
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}
