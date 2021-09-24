using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface ILieutenantGeneral : IPrivate
    {
        IReadOnlyCollection<Private> Soldiers { get; }

        void Add(Private @private);
        
    }
}
