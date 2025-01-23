using System;
using System.Collections.Generic;
using System.Text;

namespace P02_FootballBetting.Data.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public ICollection<Town> Towns { get; set; }
    }
}
