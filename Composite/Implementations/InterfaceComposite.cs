using Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Implementations
{
    public class InterfaceComposite : IComponent
    {
        private string _name;
        private List<IComponent> _children = new List<IComponent>();

        public InterfaceComposite(string name)
        {
            _name = name;
        }

        public void Add(IComponent component)
        {
            _children.Add(component);
        }

        public void Remove(IComponent component)
        {
            _children.Remove(component);
        }

        public void Operation()
        {
            Console.WriteLine($"Interface Composite {_name} operation.");
            foreach (var child in _children)
            {
                child.Operation();
            }
        }
    }
}
