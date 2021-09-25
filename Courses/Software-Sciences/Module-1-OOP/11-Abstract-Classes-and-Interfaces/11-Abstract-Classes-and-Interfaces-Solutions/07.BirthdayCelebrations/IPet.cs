using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public interface IPet : IBirthDate
    {
        public string Name { get;}
        public string BirthDate { get; }
    }
}
