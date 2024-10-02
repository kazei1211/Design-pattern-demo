using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class ShallowCopyPrototype : IPrototype
    {
        public string Name { get; set; }
        public Address Address { get; set; }

        public ShallowCopyPrototype(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        public IPrototype Clone()
        {
            return (IPrototype)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"[ShallowCopy] Name: {Name}, City: {Address.City}";
        }
    }
}
