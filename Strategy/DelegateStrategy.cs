    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class DelegateContext
    {
        public Action ExecuteStrategy { get; set; }

        public void SetStrategy(Action strategy)
        {
            ExecuteStrategy = strategy;
        }
    }

    // Strategies as delegate methods
    public class StrategyWithDelegates
    {
        public void ExecuteA()
        {
            Console.WriteLine("Executing Strategy A using delegates");
        }

        public void ExecuteB()
        {
            Console.WriteLine("Executing Strategy B using delegates");
        }
    }

}
