using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Generics
{
    public class GenericDecorator<T> : IComponent where T : IComponent
    {
        protected T _component;

        public GenericDecorator(T component)
        {
            _component = component;
        }

        public virtual string Operation()
        {
            return _component.Operation();
        }
    }
}
