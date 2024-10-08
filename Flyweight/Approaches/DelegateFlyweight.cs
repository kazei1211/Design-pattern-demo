using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Approaches
{
    public delegate void FlyweightOperationDelegate(string extrinsicState);

    public class FlyweightFactoryWithDelegate
    {
        private readonly FlyweightFactory _flyweightFactory = new FlyweightFactory();

        public FlyweightOperationDelegate GetFlyweightOperation(string key)
        {
            IFlyweight flyweight = _flyweightFactory.GetFlyweight(key);
            return (extrinsicState) => flyweight.Operation(extrinsicState);
        }
    }
}
