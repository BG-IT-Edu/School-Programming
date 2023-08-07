namespace _07.Tuple
{
    public class Tuple<T, T1>
    {
        public Tuple(T item, T1 item1)
        {
            this.Item = item;
            this.Item1 = item1;
        }

        public T Item { get; set; }

        public T1 Item1 { get; set; }

        public override string ToString()
        {
            return $"{this.Item} -> {this.Item1}";
        }
    }
}
