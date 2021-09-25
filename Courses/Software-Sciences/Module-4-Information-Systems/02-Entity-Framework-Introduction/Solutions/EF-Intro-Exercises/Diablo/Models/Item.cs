using System;
using System.Collections.Generic;

#nullable disable

namespace Diablo.Models
{
    public partial class Item
    {
        public Item()
        {
            GameTypeForbiddenItems = new HashSet<GameTypeForbiddenItem>();
            UserGameItems = new HashSet<UserGameItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ItemTypeId { get; set; }
        public int StatisticId { get; set; }
        public decimal Price { get; set; }
        public int MinLevel { get; set; }

        public virtual ItemType ItemType { get; set; }
        public virtual Statistic Statistic { get; set; }
        public virtual ICollection<GameTypeForbiddenItem> GameTypeForbiddenItems { get; set; }
        public virtual ICollection<UserGameItem> UserGameItems { get; set; }
    }
}
