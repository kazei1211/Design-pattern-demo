using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    // Strategy Interface
    public interface IStrategy
    {
        void Execute();
    }

    // Concrete Strategies
    public class StrategyA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Executing Strategy A");
        }
    }

    public class StrategyB : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Executing Strategy B");
        }
    }

    // Context class
    public class Context
    {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteStrategy()
        {
            _strategy.Execute();
        }
    }

}
