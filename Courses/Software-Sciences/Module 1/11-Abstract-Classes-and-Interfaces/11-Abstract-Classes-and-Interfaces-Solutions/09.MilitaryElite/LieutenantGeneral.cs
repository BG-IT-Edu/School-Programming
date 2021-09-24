using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MilitaryElite
{
    public class LieutenantGeneral : Private
    {
        List<Private> soldiers;
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary)
             : base(id, firstName, lastName, salary)
        {
            soldiers = new List<Private>();
        }

        IReadOnlyCollection<Private> Soldiers => this.soldiers.AsReadOnly();


        public void Add(Private @private)
        {
            soldiers.Add(@private);
        }

        public override string ToString()
        {
             StringBuilder sb = new StringBuilder();
             sb.AppendLine(base.ToString());
             sb.AppendLine("Privates:");

            foreach (var soldir in Soldiers)
            {
                sb.AppendLine("  "+soldir.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }

}
