using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface IDependencyStrategy
    {
        void Execute();
    }

    public class StrategyDI_A : IDependencyStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Executing Strategy A with Dependency Injection");
        }
    }

    public class StrategyDI_B : IDependencyStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Executing Strategy B with Dependency Injection");
        }
    }

    // Context using Dependency Injection
    public class DIContext
    {
        private IDependencyStrategy _strategy;

        public DIContext(IDependencyStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteStrategy()
        {
            _strategy.Execute();
        }
    }

}
