using System;
using System.Collections.Generic;

#nullable disable

namespace Diablo.Models
{
    public partial class GameTypeForbiddenItem
    {
        public int ItemId { get; set; }
        public int GameTypeId { get; set; }

        public virtual GameType GameType { get; set; }
        public virtual Item Item { get; set; }
    }
}
