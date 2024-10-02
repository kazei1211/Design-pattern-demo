using Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Implementations
{
    public class GenericLeaf : IGenericComponent
    {
        private string _name;

        public GenericLeaf(string name)
        {
            _name = name;
        }

        public void Operation()
        {
            Console.WriteLine($"Generic Leaf {_name} operation.");
        }
    }
}
