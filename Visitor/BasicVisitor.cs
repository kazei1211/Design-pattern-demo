using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    // Visitor Interface
    public interface IVisitor
    {
        void Visit(ElementA elementA);
        void Visit(ElementB elementB);
    }

    // Concrete Visitor
    public class ConcreteVisitor : IVisitor
    {
        public void Visit(ElementA elementA)
        {
            Console.WriteLine("Visited Element A");
        }

        public void Visit(ElementB elementB)
        {
            Console.WriteLine("Visited Element B");
        }
    }

    // Element Interface
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }

    // Concrete Elements
    public class ElementA : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class ElementB : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

}
