using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorator.Interfaces;
using System.Threading.Tasks;

namespace Decorator.AbstractDecorators
{
    public class ConcreteAbstractDecoratorA : AbstractDecorator
    {
        public ConcreteAbstractDecoratorA(IComponent component) : base(component) { }

        public override string Operation()
        {
            return $"ConcreteAbstractDecoratorA({base.Operation()})";
        }

        public void AddedBehavior()
        {
            // Thêm hành vi mới
        }
    }
}
