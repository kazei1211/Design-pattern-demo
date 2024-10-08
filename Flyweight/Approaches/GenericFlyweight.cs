using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Approaches
{
    public class FlyweightFactoryWithGeneric<T>
        where T : class, IFlyweight, new()
    {
        private readonly FlyweightFactory _flyweightFactory = new FlyweightFactory();

        public void ExecuteFlyweightOperation(string key, string extrinsicState)
        {
            var flyweight = _flyweightFactory.GetFlyweight(key);
            flyweight?.Operation(extrinsicState);
        }
    }
}
