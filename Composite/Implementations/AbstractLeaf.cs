using Composite.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Implementations
{
    public class AbstractLeaf : AbstractComponent
    {
        private string _name;

        public AbstractLeaf(string name)
        {
            _name = name;
        }

        public override void Operation()
        {
            Console.WriteLine($"Abstract Leaf {_name} operation.");
        }
    }
}
