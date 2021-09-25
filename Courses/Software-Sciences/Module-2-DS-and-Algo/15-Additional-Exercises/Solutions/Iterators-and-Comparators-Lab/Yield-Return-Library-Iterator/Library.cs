using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private readonly List<Book> books;
        public Library(params Book[] books)
        {
            this.Books = new List<Book>(books);

        }

        public List<Book> Books { get; }

        public IEnumerator<Book> GetEnumerator()
        {

            for (int i = 0; i < this.Books.Count; i++)
            {
                yield return this.Books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
