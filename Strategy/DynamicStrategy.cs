using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class DynamicStrategyContext
    {
        private IStrategy _strategy;

        public void SetStrategyBasedOnCondition(bool condition)
        {
            if (condition)
            {
                _strategy = new StrategyA();
            }
            else
            {
                _strategy = new StrategyB();
            }
        }

        public void ExecuteStrategy()
        {
            _strategy.Execute();
        }
    }

}
