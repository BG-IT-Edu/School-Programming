using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementArrayList
{
    public class CustomArrayList<T>
    {
        private T[] arr;
        private static int INITIAL_CAPACITY = 4;
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
            private set { count = value; }
        }

        public CustomArrayList()
        {
            arr = new T[INITIAL_CAPACITY];
            count = 0;
        }
        public void Add(T item)
        {
            Insert(Count, item);
        }

        public void Insert(int index, T item)
        {

            if (Count == arr.Length)
            {
                Resize();
            }

            for (int i = arr.Length - 1; i > index; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[index] = item;
            Count++;
        }
        public int IndexOf(T item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
        public void Clear()
        {
            arr = new T[INITIAL_CAPACITY];
            Count = 0;
        }
        public bool Contains(T item)
        {
            int index = IndexOf(item);

            bool found = (index != -1);

            return found;
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);
                }
                return arr[index];
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);
                }
                arr[index] = value;
            }

        }

        public T Remove(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index: " + index);
            }

            T item = arr[index];

            arr[index] = default(T);
            Shift(index);
            Count--;

            if (Count <= arr.Length / 2)
            {
                Shrink();
            }

            return item;
        }

        public int Remove(T item)
        {
            int index = IndexOf(item);

            if (index == -1)
            {
                return index;
            }

            Remove(index);

            return index;
        }

        private void Resize()
        {
            T[] copy = new T[arr.Length * 2];
            Array.Copy(arr, copy, arr.Length);
            arr = copy;
        }
        private void Shift(int index)
        {
            for (int i = index; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            arr[Count - 1] = default(T);
        }
        private void Shrink()
        {
            T[] copy = new T[arr.Length / 2];
            Array.Copy(arr, copy, copy.Length);
            arr = copy;
        }
    }
}
