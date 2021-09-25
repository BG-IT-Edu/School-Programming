using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
   public interface IRobot : IIdentification
    {
        public string Model { get;}
    }
}
