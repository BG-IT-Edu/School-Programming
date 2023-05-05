using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private List<Soldier> specialSoldiers;

        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary)
            : base(id,firstName,lastName, salary)
        {
            specialSoldiers = new List<Soldier>();
        }
        public Corps Corps { get; set; }

        public IReadOnlyCollection<Soldier> SpecialSoldiers => this.specialSoldiers.AsReadOnly();
        public void Add(Corps corps)
        {

        }
    }
}
