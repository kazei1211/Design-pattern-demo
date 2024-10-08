using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Generics
{
    public class GenericConcreteDecoratorA<T> : GenericDecorator<T> where T : IComponent
    {
        public GenericConcreteDecoratorA(T component) : base(component) { }

        public override string Operation()
        {
            return $"GenericConcreteDecoratorA({base.Operation()})";
        }

        public void AddedBehavior()
        {
            // Thêm hành vi mới
            Console.WriteLine("AddedBehavior in GenericConcreteDecoratorA");
        }
    }

    public class GenericConcreteDecoratorB<T> : GenericDecorator<T> where T : IComponent
    {
        public GenericConcreteDecoratorB(T component) : base(component) { }

        public override string Operation()
        {
            return $"GenericConcreteDecoratorB({base.Operation()})";
        }

        public void AnotherAddedBehavior()
        {
            // Thêm hành vi khác
            Console.WriteLine("AnotherAddedBehavior in GenericConcreteDecoratorB");
        }
    }
}
