using System;
using System.Collections.Generic;
using System.Text;

namespace P02_FootballBetting.Data.Models
{
    public class Town
    {
        public int TownId { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
