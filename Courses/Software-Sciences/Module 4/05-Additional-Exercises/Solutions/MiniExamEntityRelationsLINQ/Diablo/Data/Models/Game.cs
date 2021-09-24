using System;
using System.Collections.Generic;

#nullable disable

namespace Diablo.Data.Models
{
    public partial class Game
    {
        public Game()
        {
            UsersGames = new HashSet<UsersGame>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public int? Duration { get; set; }
        public int GameTypeId { get; set; }
        public bool IsFinished { get; set; }

        public virtual GameType GameType { get; set; }
        public virtual ICollection<UsersGame> UsersGames { get; set; }
    }
}
