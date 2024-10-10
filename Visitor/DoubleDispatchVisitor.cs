using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public interface IVisitable
    {
        void Accept(IAdvancedVisitor visitor);
    }

    public class AdvancedElementA : IVisitable
    {
        public void Accept(IAdvancedVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class AdvancedElementB : IVisitable
    {
        public void Accept(IAdvancedVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public interface IAdvancedVisitor
    {
        void Visit(AdvancedElementA elementA);
        void Visit(AdvancedElementB elementB);
    }

    public class DoubleDispatchVisitor : IAdvancedVisitor
    {
        public void Visit(AdvancedElementA elementA)
        {
            Console.WriteLine("Advanced Visitor visiting Element A");
        }

        public void Visit(AdvancedElementB elementB)
        {
            Console.WriteLine("Advanced Visitor visiting Element B");
        }
    }

}
