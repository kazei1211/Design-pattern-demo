using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Interfaces;

namespace Decorator.Decorators
{
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(IComponent component) : base(component) { }

        public override string Operation()
        {
            return $"ConcreteDecoratorB({base.Operation()})";
        }

        public void AnotherAddedBehavior()
        {
            // Thêm hành vi khác
        }
    }
}
