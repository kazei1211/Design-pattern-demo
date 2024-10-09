using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public interface IStrategy
    {
        void Execute(StrategyContext context);
    }

    public class StrategyA : IStrategy
    {
        public void Execute(StrategyContext context)
        {
            Console.WriteLine("Executing strategy A.");
            context.SetStrategy(new StrategyB());
        }
    }

    public class StrategyB : IStrategy
    {
        public void Execute(StrategyContext context)
        {
            Console.WriteLine("Executing strategy B.");
            context.SetStrategy(new StrategyA());
        }
    }

    public class StrategyContext
    {
        private IStrategy _strategy;

        public StrategyContext(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Request()
        {
            _strategy.Execute(this);
        }
    }

}
