using Composite.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Implementations
{
    public class AbstractComposite : AbstractComponent
    {
        private string _name;
        private List<AbstractComponent> _children = new List<AbstractComponent>();

        public AbstractComposite(string name)
        {
            _name = name;
        }

        public void Add(AbstractComponent component)
        {
            _children.Add(component);
        }

        public void Remove(AbstractComponent component)
        {
            _children.Remove(component);
        }

        public override void Operation()
        {
            Console.WriteLine($"Abstract Composite {_name} operation.");
            foreach (var child in _children)
            {
                child.Operation();
            }
        }
    }
}
