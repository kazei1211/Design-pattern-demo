using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class FlyweightFactory
    {
        private Dictionary<string, IFlyweight> _flyweights = new Dictionary<string, IFlyweight>();

        public IFlyweight GetFlyweight(string key)
        {
            if (!_flyweights.ContainsKey(key))
            {
                _flyweights[key] = new ConcreteFlyweight(key);
                Console.WriteLine($"Created new Flyweight with key: {key}");
            }
            else
            {
                Console.WriteLine($"Reusing existing Flyweight with key: {key}");
            }
            return _flyweights[key];
        }
    }
}
