using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        private List<Book> books;

        public IEnumerator<Book> GetEnumerator()
        {
            LibraryIterator libraryIterator = new LibraryIterator(this.books);

            return libraryIterator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Sort()
        {
            BookComparator bookComparator = new BookComparator();

            this.books.Sort(bookComparator);
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex;

            public LibraryIterator(List<Book> books)
            {
                this.Reset();
                this.books = books;
            }

            public Book Current => books[currentIndex];

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {}

            public bool MoveNext()
            {
                return ++this.currentIndex < this.books.Count;
            }

            public void Reset()
            {
                this.currentIndex = -1;
            }
        }
    }
}
