using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface ISpecialisedSoldier
    {
        public Corps Corps { get; set; }

        void Add(Corps corps);
    }
}
