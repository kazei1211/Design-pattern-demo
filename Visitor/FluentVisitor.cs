using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class FluentVisitor : IVisitor
    {
        public FluentVisitor Visit(ElementA elementA)
        {
            Console.WriteLine("Fluent Visitor visiting Element A");
            return this;
        }

        public FluentVisitor Visit(ElementB elementB)
        {
            Console.WriteLine("Fluent Visitor visiting Element B");
            return this;
        }

        void IVisitor.Visit(ElementA elementA)
        {
            Visit(elementA);
        }

        void IVisitor.Visit(ElementB elementB)
        {
            Visit(elementB);
        }
    }

}
