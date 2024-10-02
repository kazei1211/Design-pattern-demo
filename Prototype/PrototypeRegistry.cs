using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class PrototypeRegistry
    {
        private Dictionary<string, IPrototype> _prototypes = new Dictionary<string, IPrototype>();

        public void RegisterPrototype(string key, IPrototype prototype)
        {
            _prototypes[key] = prototype;
        }

        public IPrototype GetPrototype(string key)
        {
            if (_prototypes.ContainsKey(key))
            {
                return _prototypes[key].Clone();
            }
            throw new ArgumentException($"Prototype with key '{key}' not found.");
        }

        public void ListPrototypes()
        {
            Console.WriteLine("Registered Prototypes:");
            foreach (var key in _prototypes.Keys)
            {
                Console.WriteLine($"- {key}");
            }
        }
    }
}
