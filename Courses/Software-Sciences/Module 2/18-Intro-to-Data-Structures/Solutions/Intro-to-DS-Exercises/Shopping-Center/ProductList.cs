using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

namespace Shopping_Center
{
    public class ProductList
    {
        private readonly Dictionary<string, OrderedBag<Product>> _byName;
        private readonly Dictionary<string, OrderedBag<Product>> _byProducer;
        private readonly OrderedDictionary<decimal, Bag<Product>> _byPrice;
        private readonly Dictionary<string, Bag<Product>> _byNameAndProducer;

        public ProductList()
        {
            this._byName = new Dictionary<string, OrderedBag<Product>>();
            this._byProducer = new Dictionary<string, OrderedBag<Product>>();
            this._byPrice = new OrderedDictionary<decimal, Bag<Product>>();
            this._byNameAndProducer = new Dictionary<string, Bag<Product>>();
        }

        public void AddProduct(string name, decimal price, string producer)
        {
            var product = new Product(name, price, producer);

            this._byName.AppendValueToKey(name, product);
            this._byProducer.AppendValueToKey(producer, product);
            this._byPrice.AppendValueToKey(price, product);
            this._byNameAndProducer.AppendValueToKey(name + producer, product);
        }

        public int DeleteByProducer(string producer)
        {
            if (!this._byProducer.ContainsKey(producer))
            {
                return 0;
            }

            var productsToBeDeleted = this._byProducer[producer];

            this._byProducer.Remove(producer);

            foreach (var product in productsToBeDeleted)
            {
                this._byName[product.Name].Remove(product);
                this._byNameAndProducer[product.Name + product.Producer].Remove(product);
                this._byPrice[product.Price].Remove(product);
            }

            return productsToBeDeleted.Count;
        }

        public int DeleteByNameAndProducer(string name, string producer)
        {
            var key = name + producer;

            if (!this._byNameAndProducer.ContainsKey(key))
            {
                return 0;
            }

            var productsToBeDeleted = this._byNameAndProducer[key];

            this._byNameAndProducer.Remove(key);

            foreach (var product in productsToBeDeleted)
            {
                this._byName[product.Name].Remove(product);
                this._byProducer[product.Producer].Remove(product);
                this._byPrice[product.Price].Remove(product);
            }

            return productsToBeDeleted.Count;
        }

        public IEnumerable<Product> FindProductsByName(string name)
        {
            if (!this._byName.ContainsKey(name))
            {
                return Enumerable.Empty<Product>();
            }

            return this._byName[name];
        }

        public IEnumerable<Product> FindProductsProducer(string producer)
        {
            if (!this._byProducer.ContainsKey(producer))
            {
                return Enumerable.Empty<Product>();
            }

            return this._byProducer[producer];
        }

        public IEnumerable<Product> FindProductsByPriceRange(decimal from, decimal to)
        {
            var range = this._byPrice.Range(from, true, to, true)
                .Values
                .SelectMany(x => x)
                .ToList();

            range.Sort();

            return range;
        }
    }
}
