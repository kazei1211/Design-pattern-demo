using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Approaches
{
    public interface IFlyweightFactoryFacade
    {
        void ExecuteFlyweightOperation(string key, string extrinsicState);
    }

    public class FlyweightFactoryFacadeWithInterface : IFlyweightFactoryFacade
    {
        private readonly FlyweightFactory _flyweightFactory = new FlyweightFactory();

        public void ExecuteFlyweightOperation(string key, string extrinsicState)
        {
            IFlyweight flyweight = _flyweightFactory.GetFlyweight(key);
            flyweight.Operation(extrinsicState);
        }
    }
}
