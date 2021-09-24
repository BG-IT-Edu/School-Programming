using System;
using System.Collections.Generic;

#nullable disable

namespace Diablo.Data.Models
{
    public partial class GameType
    {
        public GameType()
        {
            GameTypeForbiddenItems = new HashSet<GameTypeForbiddenItem>();
            Games = new HashSet<Game>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? BonusStatsId { get; set; }

        public virtual Statistic BonusStats { get; set; }
        public virtual ICollection<GameTypeForbiddenItem> GameTypeForbiddenItems { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }
}
