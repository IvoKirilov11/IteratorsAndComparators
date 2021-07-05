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
            Books = books.ToList();
        }
        public List<Book> Books { get; set; }


        public IEnumerator<Book> GetEnumerator()
        {
            return new LiberaryIterator(Books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((System.Collections.IEnumerable)Books).GetEnumerator();
        }

        private class LiberaryIterator : IEnumerator<Book>
        {

            private int index = -1;
            public LiberaryIterator(List<Book> books)
            {
                Books = books;
            }

            public List<Book> Books { get; set; }
            public Book Current => Books[index];

            object IEnumerator.Current => Books[index];

            public void Dispose()
            {

            }

            public bool MoveNext()
            {
                return ++index < Books.Count;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
