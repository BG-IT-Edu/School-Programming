using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface IRepair
    {
        public string Name { get; }
        public int Hours { get; }
    }
}
