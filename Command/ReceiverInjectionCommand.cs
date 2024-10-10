using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ReceiverInjectionCommand<T> : ICommand
    {
        private readonly Action<T> _action;
        private readonly T _receiver;

        public ReceiverInjectionCommand(T receiver, Action<T> action)
        {
            _receiver = receiver;
            _action = action;
        }

        public void Execute()
        {
            _action.Invoke(_receiver);
        }
    }

}
