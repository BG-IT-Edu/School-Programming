using System;
using System.Collections.Generic;

#nullable disable

namespace Diablo.Models
{
    public partial class Statistic
    {
        public Statistic()
        {
            Characters = new HashSet<Character>();
            GameTypes = new HashSet<GameType>();
            Items = new HashSet<Item>();
        }

        public int Id { get; set; }
        public int Strength { get; set; }
        public int Defence { get; set; }
        public int Mind { get; set; }
        public int Speed { get; set; }
        public int Luck { get; set; }

        public virtual ICollection<Character> Characters { get; set; }
        public virtual ICollection<GameType> GameTypes { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
