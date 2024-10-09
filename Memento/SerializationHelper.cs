using System;
using System.Text.Json;

namespace Memento
{
    public static class SerializationHelper
    {
        public static string Serialize(SerializableMemento memento)
        {
            return JsonSerializer.Serialize(memento);
        }

        public static SerializableMemento Deserialize(string jsonData)
        {
            return JsonSerializer.Deserialize<SerializableMemento>(jsonData);
        }
    }
}
