using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class BidirectionalIterator<T> : IIterator<T>
    {
        private readonly List<T> _collection;
        private int _currentIndex;

        public BidirectionalIterator(List<T> collection)
        {
            _collection = collection;
            _currentIndex = 0;
        }

        public bool HasNext()
        {
            return _currentIndex < _collection.Count;
        }

        public bool HasPrevious()
        {
            return _currentIndex > 0;
        }

        public T Current()
        {
            return _collection[_currentIndex];
        }

        public void Next()
        {
            _currentIndex++;
        }

        public void Previous()
        {
            _currentIndex--;
        }
    }

}
