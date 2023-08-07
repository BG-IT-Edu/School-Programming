using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping_Center
{
    public static class DictionaryExtensions
    {
        /// <summary>
        /// Ensures the specified key exists in the dictionary.
        /// If the key does not exist, it is mapped to a new empty value.
        /// </summary>
        public static void EnsureKeyExists<TKey, TValue>(
            this IDictionary<TKey, TValue> dict, TKey key)
            where TValue : new()
        {
            if (!dict.ContainsKey(key))
            {
                dict.Add(key, new TValue());
            }
        }

        /// <summary>
        /// Appends a new value to the collection of values mapped to the specified
        /// dictionary key. If the collection does not exists for the specified key,
        /// a new empty collection is first created and mapped to this key.
        /// </summary>
        /// <param name="key">The key that holds a collection of values</param>
        /// <param name="value">The value to be added to the collection for this key</param>
        public static void AppendValueToKey<TKey, TCollection, TValue>(
            this IDictionary<TKey, TCollection> dict, TKey key, TValue value)
            where TCollection : ICollection<TValue>, new()
        {
            if (!dict.TryGetValue(key, out var collection))
            {
                collection = new TCollection();
                dict.Add(key, collection);
            }

            collection.Add(value);
        }

        /// <summary>
        /// Get a sequence of values assigned to the specified dictionary key.
        /// If the key is missing, an empty sequence is returned.
        /// </summary>
        public static IEnumerable<TValue> GetValuesForKey<TKey, TValue>(
            this IDictionary<TKey, SortedSet<TValue>> dict, TKey key)
        {
            if (dict.TryGetValue(key, out var collection))
            {
                return collection;
            }

            return Enumerable.Empty<TValue>();
        }
    }
}
