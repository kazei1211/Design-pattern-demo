using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class ComplexOriginator
    {
        public string State { get; set; }
        public int Value { get; set; }

        public ComplexMemento Save()
        {
            return new ComplexMemento(State, Value);
        }

        public void Restore(ComplexMemento memento)
        {
            State = memento.State;
            Value = memento.Value;
        }
    }

}
