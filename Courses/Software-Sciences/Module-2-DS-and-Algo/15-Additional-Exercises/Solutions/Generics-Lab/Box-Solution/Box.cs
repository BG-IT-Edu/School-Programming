using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxOfT
{
    public class Box <T>
    {
        private List<T> data;

        public Box()
        {
           this.data = new List<T>();
        }

        public int Count { get { return this.data.Count; } }

        public void Add(T item)
        {
            this.data.Add(item);
        }
        public T Remove()
        {
            var removed = this.data[data.Count - 1];
            this.data.RemoveAt(data.Count - 1);
            return removed;
        }
    }
}
