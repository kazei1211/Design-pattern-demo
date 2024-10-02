using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class AudioPlayer
    {
        private PrototypeRegistry _registry;

        public AudioPlayer(PrototypeRegistry registry)
        {
            _registry = registry;
        }

        public void PlayPrototype(string key)
        {
            try
            {
                IPrototype prototype = _registry.GetPrototype(key);
                Console.WriteLine($"Cloned Prototype: {prototype}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
