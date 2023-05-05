using System;

namespace Collections
{
    public class CircularQueue<T>
    {
        private T[] elements;

        public int Count { get; private set; }
        public int Capacity { get => elements.Length; }
        public int StartIndex { get; private set; }
        public int EndIndex { get; private set; }

        private const int InitialCapacity = 8;

        public CircularQueue(int capacity = InitialCapacity)
        {
            this.elements = new T[capacity];
            this.StartIndex = 0;
            this.EndIndex = 0;
        }

        public void Enqueue(T element)
        {
            if (this.Count >= this.elements.Length)
                this.Grow();
            this.elements[this.EndIndex] = element;
            this.EndIndex = (this.EndIndex + 1) % this.elements.Length;
            this.Count++;
        }

        private void Grow()
        {
            var newElements = new T[2 * this.elements.Length];
            this.CopyAllElementsTo(newElements);
            this.elements = newElements;
            this.StartIndex = 0;
            this.EndIndex = this.Count;
        }

        private void CopyAllElementsTo(T[] resultArr)
        {
            int sourceIndex = this.StartIndex;
            for (int destIndex = 0; destIndex < this.Count; destIndex++)
            {
                resultArr[destIndex] = this.elements[sourceIndex];
                sourceIndex = (sourceIndex + 1) % this.elements.Length;
            }
        }

        public T Dequeue()
        {
            if (this.Count == 0)
                throw new InvalidOperationException("The queue is empty!");

            var result = this.elements[this.StartIndex];
            this.StartIndex = (this.StartIndex + 1) % this.elements.Length;
            this.Count--;
            return result;
        }

        public T Peek()
        {
            if (this.Count == 0)
                throw new InvalidOperationException("The queue is empty!");

            var result = this.elements[this.StartIndex];
            return result;
        }

        public T[] ToArray()
        {
            var resultArray = new T[this.Count];
            this.CopyAllElementsTo(resultArray);
            return resultArray;
        }

        public override string ToString()
        {
            return "[" + string.Join(", ", this.ToArray()) + "]";
        }
    }
}
