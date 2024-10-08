using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public interface IFlyweight
    {
        void Operation(string extrinsicState);
    }

    public class ConcreteFlyweight : IFlyweight
    {
        private string _intrinsicState;

        public ConcreteFlyweight()
        {

        }

        public ConcreteFlyweight(string intrinsicState)
        {
            _intrinsicState = intrinsicState;
        }

        public void Operation(string extrinsicState)
        {
            Console.WriteLine($"Intrinsic State: {_intrinsicState}, Extrinsic State: {extrinsicState}");
        }
    }
}
