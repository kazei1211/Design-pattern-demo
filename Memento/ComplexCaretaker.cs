using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class ComplexCaretaker
    {
        private readonly List<ComplexMemento> _mementoList = new List<ComplexMemento>();

        public void SaveState(ComplexOriginator originator)
        {
            _mementoList.Add(originator.Save());
        }

        public void RestoreState(ComplexOriginator originator, int index)
        {
            if (index >= 0 && index < _mementoList.Count)
            {
                originator.Restore(_mementoList[index]);
            }
        }
    }
}
