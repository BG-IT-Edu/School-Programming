using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootbalTeamGenerator
{
    class Team
    {
        private string name;

        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            players = new List<Player>();
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }

        public int Rating { get => GetAverageRatingOfTeam(); }

        public void Add(Player player)
        {
            players.Add(player);
        }

        public void Remove(string playerName)
        {
            if (players.Any(x => x.Name == playerName) == false)
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
            }
            Player currentPlayer = players.FirstOrDefault(p => p.Name == playerName);
            players.Remove(currentPlayer);
        }

        private int GetAverageRatingOfTeam()
        {
            if (players.Count == 0)
            {
                return 0;
            }
            return (int)Math.Round(GetAverageRatingOfAllPlayers() / players.Count);
        }

        private double GetAverageRatingOfAllPlayers()
        {
            double result = 0;
            foreach (var player in players)
            {
               int currentPlayerRate = (player.Stats.Endurance + player.Stats.Sprint 
                    + player.Stats.Dribble + player.Stats.Passing + player.Stats.Shooting);
                result += Math.Round((double)currentPlayerRate / 5d);
            }
            return result;
        }
    }
}
