namespace _01.ListyIterator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ListyIterator<T>
    {
        private int index = 0;
        private List<T> collection;

        public ListyIterator()
        {
            this.collection = new List<T>();
        }

        public void Create(params T[] items)
        {
            foreach (var item in items)
            {
                this.collection.Add(item);
            }
        }

        public bool Move()
        {
            var hasNext = this.HasNext();

            if (hasNext)
            {
                this.index++;
            }

            return hasNext;
        }

        public bool HasNext()
        {
            if (index >= 0 && index < this.collection.Count - 1)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (this.collection.Any() == false)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(this.collection[index]);
        }
    }
}