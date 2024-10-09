using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class UndoRedoCaretaker
    {
        private readonly Stack<Memento> _undoStack = new Stack<Memento>();
        private readonly Stack<Memento> _redoStack = new Stack<Memento>();

        public void SaveState(Originator originator)
        {
            _undoStack.Push(originator.Save());
            _redoStack.Clear(); // clear redo stack on new action
        }

        public void Undo(Originator originator)
        {
            if (_undoStack.Count > 0)
            {
                var memento = _undoStack.Pop();
                _redoStack.Push(originator.Save());
                originator.Restore(memento);
            }
        }

        public void Redo(Originator originator)
        {
            if (_redoStack.Count > 0)
            {
                var memento = _redoStack.Pop();
                _undoStack.Push(originator.Save());
                originator.Restore(memento);
            }
        }
    }

}
