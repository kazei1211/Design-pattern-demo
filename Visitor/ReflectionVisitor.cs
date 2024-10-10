using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ReflectionVisitor
    {
        public void Visit(IElement element)
        {
            var method = this.GetType().GetMethod("Visit", new[] { element.GetType() });
            if (method != null)
            {
                method.Invoke(this, new object[] { element });
            }
            else
            {
                Console.WriteLine("No visit method found for " + element.GetType().Name);
            }
        }

        public void Visit(ElementA elementA)
        {
            Console.WriteLine("Reflection Visitor visiting Element A");
        }

        public void Visit(ElementB elementB)
        {
            Console.WriteLine("Reflection Visitor visiting Element B");
        }
    }

}
