using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class DeepCopyOriginator
    {
        public string State { get; set; }
        public Dictionary<string, string> Data { get; set; } = new Dictionary<string, string>();

        public DeepCopyMemento Save()
        {
            return new DeepCopyMemento(State, Data);
        }

        public void Restore(DeepCopyMemento memento)
        {
            State = memento.State;
            Data = new Dictionary<string, string>(memento.Data); // Deep copy of data
        }
    }

}
