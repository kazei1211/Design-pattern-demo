using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.AbstractDecorators
{
    public class ConcreteAbstractDecoratorB : AbstractDecorator
    {
        public ConcreteAbstractDecoratorB(IComponent component) : base(component) { }

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
