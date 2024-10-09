using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class ComplexMemento
    {
        public string State { get; }
        public int Value { get; }

        public ComplexMemento(string state, int value)
        {
            State = state;
            Value = value;
        }
    }

}
