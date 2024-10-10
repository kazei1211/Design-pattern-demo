using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class FuncContext
    {
        public Func<string> ExecuteStrategy { get; set; }

        public void SetStrategy(Func<string> strategy)
        {
            ExecuteStrategy = strategy;
        }

        public void RunStrategy()
        {
            string result = ExecuteStrategy();
            Console.WriteLine(result);
        }
    }

    // Strategies as Func methods
    public class FuncStrategies
    {
        public string ExecuteA()
        {
            return "Executing Strategy A using Func";
        }

        public string ExecuteB()
        {
            return "Executing Strategy B using Func";
        }
    }

}
