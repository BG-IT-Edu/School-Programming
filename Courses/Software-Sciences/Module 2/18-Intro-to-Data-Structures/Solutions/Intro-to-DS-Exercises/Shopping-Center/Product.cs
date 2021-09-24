using System;

namespace Shopping_Center
{
    public class Product : IComparable<Product>
    {
        public Product(string name, decimal price, string producer)
        {
            this.Name = name;
            this.Price = price;
            this.Producer = producer;
        }

        public string Name { get; }

        public decimal Price { get; }

        public string Producer { get; }

        public int CompareTo(Product other)
        {
            if (other == null)
            {
                throw new NullReferenceException();
            }

            var cmp = string.Compare(this.Name, other.Name, StringComparison.InvariantCulture);
            if (cmp == 0) cmp = string.Compare(this.Producer, other.Producer, StringComparison.InvariantCulture);
            if (cmp == 0) cmp = this.Price.CompareTo(other.Price);

            return cmp;
        }

        public override string ToString()
        {
            var result = $"{this.Name};{this.Producer};{this.Price:F2}";
            return $"{{{result}}}";
        }
    }
}
