using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ConcreteIterator<T> : IIterator<T>
    {
        private readonly List<T> _collection;
        private int _currentIndex = 0;

        public ConcreteIterator(List<T> collection)
        {
            _collection = collection;
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
        }
    }

}
