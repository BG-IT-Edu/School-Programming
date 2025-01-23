using System;
using System.Collections.Generic;
using System.Text;

namespace P02_FootballBetting.Data.Models
{
    public class Position
    {
        public int PositionId { get; set; }
        public string Name { get; set; }
        public ICollection<Player> Players { get; set; }
    }
}
