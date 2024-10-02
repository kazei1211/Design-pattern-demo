using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class DeepCopyPrototype : IPrototype
    {
        public string Name { get; set; }
        public Address Address { get; set; }

        public DeepCopyPrototype(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        public IPrototype Clone()
        {
            return new DeepCopyPrototype(this.Name, new Address(this.Address.City));
        }

        public override string ToString()
        {
            return $"[DeepCopy] Name: {Name}, City: {Address.City}";
        }
    }
}
