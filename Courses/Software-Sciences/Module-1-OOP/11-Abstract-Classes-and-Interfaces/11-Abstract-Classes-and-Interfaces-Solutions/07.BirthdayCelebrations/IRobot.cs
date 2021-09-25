using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
   public interface IRobot : IIdentification
    {
        public string Model { get;}
    }
}
