using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ReverseIterator<T> : IIterator<T>
    {
        private readonly List<T> _collection;
        private int _currentIndex;

        public ReverseIterator(List<T> collection)
        {
            _collection = collection;
            _currentIndex = _collection.Count - 1;
        }

        public bool HasNext()
        {
            return _currentIndex >= 0;
        }

        public T Current()
        {
            return _collection[_currentIndex];
        }

        public void Next()
        {
            _currentIndex--;
        }
    }
}
