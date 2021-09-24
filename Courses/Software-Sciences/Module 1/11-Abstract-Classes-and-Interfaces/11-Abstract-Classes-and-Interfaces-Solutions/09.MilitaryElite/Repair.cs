using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Repair : IRepair
    {
        public Repair(string name, int hours)
        {
            Name = name;
            Hours = hours;
        }

        public string Name { get; set; }
        public int Hours { get; set; }

        public override string ToString()
        {
                StringBuilder sb = new StringBuilder();
            sb.AppendLine("Repair:");
            sb.AppendLine($"Part Name: {Name} Hours Worked: {Hours}");
            return sb.ToString().TrimEnd();
        }
    }
}
