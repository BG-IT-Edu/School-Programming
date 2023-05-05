using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
    public interface IPerson : IResident
    {
        public int Age { get; }

       string GetName() { return this.Name; }
    }
}
