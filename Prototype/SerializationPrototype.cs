using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Prototype
{
    [Serializable]
    public class SerializationPrototype : IPrototype
    {
        public string Name { get; set; }
        public Address Address { get; set; }

        public SerializationPrototype(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        public IPrototype Clone()
        {
            // Sử dụng System.Text.Json để tuần tự hóa và giải tuần tự hóa đối tượng
            string serialized = JsonSerializer.Serialize(this);
            return JsonSerializer.Deserialize<SerializationPrototype>(serialized);
        }

        public override string ToString()
        {
            return $"[Serialization] Name: {Name}, City: {Address.City}";
        }
    }
}
