using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class RandomIterator<T> : IIterator<T>
    {
        private readonly List<T> _collection;
        private readonly Random _random;
        private readonly HashSet<int> _visitedIndexes;
        private int _currentIndex;

        public RandomIterator(List<T> collection)
        {
            _collection = collection;
            _random = new Random();
            _visitedIndexes = new HashSet<int>();
        }

        public bool HasNext()
        {
            return _visitedIndexes.Count < _collection.Count;
        }

        public T Current()
        {
            return _collection[_currentIndex];
        }

        public void Next()
        {
            do
            {
                _currentIndex = _random.Next(0, _collection.Count);
            }
            while (_visitedIndexes.Contains(_currentIndex));

            _visitedIndexes.Add(_currentIndex);
        }
    }

}
