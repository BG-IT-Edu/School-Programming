using System;
using System.Collections.Generic;
using System.Text;

namespace _1._Prototype
{
    public class SandwichMenu
    {
        private Dictionary<string, SandwichPrototype> sandwiches = new Dictionary<string, SandwichPrototype>();

        public SandwichPrototype this[string name]
        {
            get { return sandwiches[name]; }
            set { sandwiches.Add(name, value); }
        }
    }
}
