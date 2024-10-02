using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class CopyConstructorPrototype : IPrototype
    {
        public string Name { get; set; }
        public Address Address { get; set; }

        // Regular constructor
        public CopyConstructorPrototype(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        // Copy constructor
        public CopyConstructorPrototype(CopyConstructorPrototype other)
        {
            Name = other.Name;
            Address = new Address(other.Address.City);
        }

        public IPrototype Clone()
        {
            return new CopyConstructorPrototype(this);
        }

        public override string ToString()
        {
            return $"[CopyConstructor] Name: {Name}, City: {Address.City}";
        }
    }
}
