using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Commando : Engineer
    {
        List<Missions> missions;
        public Commando(string id, string firstName, string lastName, decimal salary, Corps corps)
            : base(id, firstName, lastName, salary, corps)
        {
            missions = new List<Missions>();
        }

        IReadOnlyCollection<Missions> Missions => this.missions.AsReadOnly();

        public void Add(Missions mission)
        {
            missions.Add(mission);
        }
        public void CompleteMission(Missions mission)
        {
            mission.State = State.Finished;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {FirstName} {LastName} Id: {ID} Salary: {Salary:f2}");
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine("Missions:");

            foreach (var mission in Missions)
            {
                sb.AppendLine("  " + $"Code Name: {mission.Name} State: {mission.State}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
