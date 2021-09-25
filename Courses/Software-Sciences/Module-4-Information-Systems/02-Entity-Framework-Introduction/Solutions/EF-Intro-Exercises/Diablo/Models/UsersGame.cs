using System;
using System.Collections.Generic;

#nullable disable

namespace Diablo.Models
{
    public partial class UsersGame
    {
        public UsersGame()
        {
            UserGameItems = new HashSet<UserGameItem>();
        }

        public int Id { get; set; }
        public int GameId { get; set; }
        public int UserId { get; set; }
        public int CharacterId { get; set; }
        public int Level { get; set; }
        public DateTime JoinedOn { get; set; }
        public decimal Cash { get; set; }

        public virtual Character Character { get; set; }
        public virtual Game Game { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<UserGameItem> UserGameItems { get; set; }
    }
}
