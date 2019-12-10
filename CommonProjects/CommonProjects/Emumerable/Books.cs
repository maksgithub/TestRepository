using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emumerable
{
    class Books : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            return new BooksEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    internal class BooksEnumerator : IEnumerator<string>
    {
        private int _c=0;
        public bool MoveNext()
        {
            _c++;
            if (_c < 15)
            {
                Current = "Book #" + _c;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _c = 0;
        }

        public void Dispose()
        {
        }

        public string Current { get; private set; }

        object IEnumerator.Current => Current;
    }
}
