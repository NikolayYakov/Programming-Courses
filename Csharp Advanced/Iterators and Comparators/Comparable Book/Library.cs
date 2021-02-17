using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private SortedSet<Book> books;

        public Library(params Book[] books)
        {
            this.books = new SortedSet<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (var book in books)
            {
                yield return book;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int index;
            public LibraryIterator(IEnumerable<Book> books)
            {
                Reset();
                books = new List<Book>(books);
            }
            public Book Current => books[index];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
               
            }

            public bool MoveNext()
            {
                return ++index < books.Count;
            }

            public void Reset()
            {
                index--;
            }
        }
    }
     
}
