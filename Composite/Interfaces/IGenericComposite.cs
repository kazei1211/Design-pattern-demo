using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Interfaces
{
    public interface IGenericComposite : IGenericComponent
    {
        void Add(IGenericComponent component);
        void Remove(IGenericComponent component);
    }
}
