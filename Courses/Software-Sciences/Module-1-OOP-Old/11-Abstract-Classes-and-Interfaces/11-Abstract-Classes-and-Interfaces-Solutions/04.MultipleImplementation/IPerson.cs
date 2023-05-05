using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public interface IPerson
    {
        string Name { get; }

        int Age { get; }
    }
}
