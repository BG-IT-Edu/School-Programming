using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class AddRemoveCollection : IRemove
    {
        public List<string> Collection = new List<string>();


        public override int Add(string element)
        {
            Collection.Insert(0, element);

            return 0;
        }
        public override string Remove()
        {
            string currentElement = Collection[Collection.Count - 1];
            Collection.RemoveAt(Collection.Count - 1);
            return currentElement;
        }
    }
}
