using System;
using System.Text;

namespace Collections
{
    public class Collection<T>
    {
        private const int InitialCapacity = 16;
        private T[] items;
        public int Capacity => this.items.Length;
        public int Count { get; private set; }

        public Collection(params T[] items)
        {
            int capacity = Math.Max(2 * items.Length, InitialCapacity);
            this.items = new T[capacity];
            for (int i = 0; i < items.Length; i++)
                this.items[i] = items[i];
            this.Count = items.Length;
        }

        public void Add(T item)
        {
            this.EnsureCapacity();
            this.items[this.Count] = item;
            this.Count++;
        }

        public void AddRange(params T[] items)
        {
            foreach (var item in items)
                this.Add(item);
        }

        private void EnsureCapacity()
        {
            if (this.Count == this.Capacity)
            {
                //Grow the capacity 2 times and move the items
               T[] oldItems = this.items;
                this.items = new T[2 * oldItems.Length];
                for (int i = 0; i < this.Count; i++)
                    this.items[i] = oldItems[i];
            }
        }

        public T this[int index]
        {
            get
            {
                this.CheckRange(index, nameof(index), minValue: 0, maxValue: this.Count - 1);
                return this.items[index];
            }
            set
            {
                this.CheckRange(index, nameof(index), minValue: 0, maxValue: this.Count - 1);
                this.items[index] = value;
            }
        }

        public void InsertAt(int index, T item)
        {
            this.CheckRange(index, nameof(index), minValue: 0, maxValue: this.Count);
            this.EnsureCapacity();
            for (int i = this.Count - 1; i >= index; i--)
                this.items[i + 1] = this.items[i];
            this.items[index] = item;
            this.Count++;
        }

        private void CheckRange(int index, string paramName, int minValue, int maxValue)
        {
            if ((index < minValue) || (index > maxValue))
            {
                string errMsg = $"Parameter should be in the range [{minValue}...{maxValue}]";
                throw new ArgumentOutOfRangeException(paramName, index, errMsg);
            }
        }

        public void Exchange(int index1, int index2)
        {
            this.CheckRange(index1, nameof(index1), minValue: 0, maxValue: this.Count - 1);
            this.CheckRange(index2, nameof(index1), minValue: 0, maxValue: this.Count - 1);
            T oldItem = this.items[index1];
            this.items[index1] = this.items[index2];
            this.items[index2] = oldItem;
        }

        public T RemoveAt(int index)
        {
            this.CheckRange(index, nameof(index), minValue: 0, maxValue: this.Count - 1);
            T removedItem = this.items[index];
            for (int i = index + 1; i < this.Count; i++)
                this.items[i - 1] = this.items[i];
            this.Count--;
            return removedItem;
        }

        public void Clear()
        {
            this.Count = 0;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder("[");
            for (int i = 0; i < this.Count; i++)
            {
                if (i > 0)
                    result.Append(", ");
                result.Append(this.items[i]);
            }
            result.Append("]");
            return result.ToString();
        }
    }
}
