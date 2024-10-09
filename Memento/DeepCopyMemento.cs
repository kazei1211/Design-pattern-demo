using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class DeepCopyMemento
    {
        public string State { get; }
        public Dictionary<string, string> Data { get; }

        public DeepCopyMemento(string state, Dictionary<string, string> data)
        {
            State = state;
            Data = new Dictionary<string, string>(data); // Deep copy of data
        }
    }

}
