using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface ICommando : IMission
    {
        IReadOnlyCollection<Missions> Missions { get; }

        void CompleteMission(Missions mission);
    }
}
