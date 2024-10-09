using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class FilterIterator<T> : IIterator<T>
    {
        private readonly List<T> _collection;
        private readonly Func<T, bool> _filter;
        private int _currentIndex;

        public FilterIterator(List<T> collection, Func<T, bool> filter)
        {
            _collection = collection;
            _filter = filter;
            _currentIndex = 0;
            MoveToNextValid();
        }

        public bool HasNext()
        {
            return _currentIndex < _collection.Count;
        }

        public T Current()
        {
            return _collection[_currentIndex];
        }

        public void Next()
        {
            _currentIndex++;
            MoveToNextValid();
        }

        private void MoveToNextValid()
        {
            while (_currentIndex < _collection.Count && !_filter(_collection[_currentIndex]))
            {
                _currentIndex++;
            }
        }
    }

}
