using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class MyList : IRemove
    {
        public List<string> Collection = new List<string>();
        public int Used => Collection.Count;

        public override int Add(string element)
        {
            Collection.Insert(0, element);

            return 0;
        }
        public override string Remove()
        {
            string currentElement = Collection[0];
            Collection.RemoveAt(0);
            return currentElement;
        }
    }
}
