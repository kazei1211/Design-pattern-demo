using Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Implementations
{
    public class GenericComposite : IGenericComposite
    {
        private string _name;
        private List<IGenericComponent> _children = new List<IGenericComponent>();

        public GenericComposite(string name)
        {
            _name = name;
        }

        public void Add(IGenericComponent component)
        {
            _children.Add(component);
        }

        public void Remove(IGenericComponent component)
        {
            _children.Remove(component);
        }

        public void Operation()
        {
            Console.WriteLine($"Generic Composite {_name} operation.");
            foreach (var child in _children)
            {
                child.Operation();
            }
        }
    }
}
