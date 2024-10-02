using Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Implementations
{
    public class InterfaceLeaf : IComponent
    {
        private string _name;

        public InterfaceLeaf(string name)
        {
            _name = name;
        }

        public void Operation()
        {
            Console.WriteLine($"Interface Leaf {_name} operation.");
        }
    }
}
