using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public interface IGenericPrototype<T>
    {
        T Clone();
    }

    public class GenericPrototype<T> : IGenericPrototype<T> where T : IGenericPrototype<T>
    {
        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }
    }

    public class GenericPerson : IGenericPrototype<GenericPerson>, IPrototype
    {
        public string Name { get; set; }
        public Address Address { get; set; }

        public GenericPerson(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        // Implement IGenericPrototype<GenericPerson>
        public GenericPerson Clone()
        {
            return (GenericPerson)this.MemberwiseClone();
        }

        // Implement IPrototype.Clone
        IPrototype IPrototype.Clone()
        {
            return this.Clone();
        }

        public override string ToString()
        {
            return $"[Generic] Name: {Name}, City: {Address.City}";
        }
    }
}
