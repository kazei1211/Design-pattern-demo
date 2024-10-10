using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public interface IGenericVisitor<T>
    {
        void Visit(T element);
    }

    public class GenericVisitor : IGenericVisitor<ElementA>, IGenericVisitor<ElementB>
    {
        public void Visit(ElementA elementA)
        {
            Console.WriteLine("Generic Visitor visiting Element A");
        }

        public void Visit(ElementB elementB)
        {
            Console.WriteLine("Generic Visitor visiting Element B");
        }
    }

    public interface IGenericElement<T>
    {
        void Accept(IGenericVisitor<T> visitor);
    }

    public class GenericElementA : IGenericElement<ElementA>
    {
        private ElementA _elementA = new ElementA(); // Khởi tạo một đối tượng ElementA

        public void Accept(IGenericVisitor<ElementA> visitor)
        {
            visitor.Visit(_elementA); // Truyền đúng đối tượng kiểu ElementA
        }
    }

    public class GenericElementB : IGenericElement<ElementB>
    {
        private ElementB _elementB = new ElementB(); // Khởi tạo một đối tượng ElementB

        public void Accept(IGenericVisitor<ElementB> visitor)
        {
            visitor.Visit(_elementB); // Truyền đúng đối tượng kiểu ElementB
        }
    }

}
