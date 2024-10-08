using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.AbstractDecorators
{
    public abstract class AbstractDecorator : IComponent
    {
        protected IComponent _component;

        protected AbstractDecorator(IComponent component)
        {
            _component = component;
        }

        public virtual string Operation()
        {
            return _component.Operation();
        }
    }
}
