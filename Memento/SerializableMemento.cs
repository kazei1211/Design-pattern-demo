using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    [Serializable]
    public class SerializableMemento
    {
        public string State { get; set; }

        public SerializableMemento(string state)
        {
            State = state;
        }
    }

}
