using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
   public class Missions : IMission
    {
        public Missions(string name, State state)
        {
            Name = name;
            State = state;
        }

        public string Name { get; set; }
        public State State { get; set; }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Mission:");
            sb.AppendLine($"Code Name: {Name} State: {State}");
            return sb.ToString().TrimEnd();
        }
    }
}
