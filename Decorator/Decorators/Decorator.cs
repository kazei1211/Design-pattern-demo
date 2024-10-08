using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public abstract class Decorator : IDecorator
    {
        public IComponent Component { get; set; }

        protected Decorator(IComponent component)
        {
            Component = component;
        }

        public virtual string Operation()
        {
            return Component.Operation();
        }
    }
}
