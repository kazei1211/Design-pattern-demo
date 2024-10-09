using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Caretaker
    {
        private readonly List<Memento> _mementoList = new List<Memento>();

        public void SaveState(Originator originator)
        {
            _mementoList.Add(originator.Save());
        }

        public void RestoreState(Originator originator, int index)
        {
            if (index >= 0 && index < _mementoList.Count)
            {
                originator.Restore(_mementoList[index]);
            }
        }
    }

}
