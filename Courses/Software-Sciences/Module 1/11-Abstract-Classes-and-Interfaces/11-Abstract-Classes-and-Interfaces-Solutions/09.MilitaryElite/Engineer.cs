using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Engineer : Private
    {
        private List<Repair> repairs;
        public Engineer(string id, string firstName, string lastName, decimal salary, Corps corps)
            : base(id, firstName, lastName, salary)
        {
            repairs = new List<Repair>();
            Corps = corps;
        }

        public Corps Corps { get; private set; }
        IReadOnlyCollection<Repair> Repairs => this.repairs.AsReadOnly();

        public void Add(Repair repair)
        {
            repairs.Add(repair);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {FirstName} {LastName} Id: {ID} Salary: {Salary:f2}");
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine("Repairs:");
            foreach (var item in repairs)
            {
                sb.AppendLine("  " + $"Part Name: {item.Name} Hours Worked: {item.Hours}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
