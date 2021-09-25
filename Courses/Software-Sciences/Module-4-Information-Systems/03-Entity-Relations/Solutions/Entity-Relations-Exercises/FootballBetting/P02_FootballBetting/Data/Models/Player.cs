using System;
using System.Collections.Generic;
using System.Text;

namespace P02_FootballBetting.Data.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public int SquadNumber { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public bool IsInjured { get; set; }
        public ICollection<PlayerStatistic> PlayerStatistics { get; set; }
    }
}
