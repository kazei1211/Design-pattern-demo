using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ConcreteAggregate<T> : IAggregate<T>
    {
        private readonly List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public IIterator<T> CreateIterator()
        {
            return new ConcreteIterator<T>(_items);
        }
    }
}
