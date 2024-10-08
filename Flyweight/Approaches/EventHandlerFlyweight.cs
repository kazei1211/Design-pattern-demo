using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Approaches
{
    public class FlyweightEventArgs : EventArgs
    {
        public string Key { get; set; }
        public string ExtrinsicState { get; set; }
    }

    public class FlyweightFactoryWithEventHandler
    {
        public event EventHandler<FlyweightEventArgs> OnFlyweightOperation;

        private readonly FlyweightFactory _flyweightFactory = new FlyweightFactory();

        public void ExecuteFlyweightOperation(string key, string extrinsicState)
        {
            var flyweight = _flyweightFactory.GetFlyweight(key);
            OnFlyweightOperation?.Invoke(this, new FlyweightEventArgs { Key = key, ExtrinsicState = extrinsicState });
            flyweight.Operation(extrinsicState);
        }
    }
}
