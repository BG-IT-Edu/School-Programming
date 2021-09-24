using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class AddCollection : IAdd
    {
        public List<string> Collection = new List<string>();

        public override int Add(string element)
        {
            Collection.Add(element);

            return Collection.Count-1;
        }

    }
}
