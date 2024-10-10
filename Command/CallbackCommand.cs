using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class CallbackCommand : ICommand
    {
        private readonly Action _action;

        public CallbackCommand(Action action)
        {
            _action = action;
        }

        public void Execute()
        {
            _action.Invoke();
        }
    }

    public class LightWithCallback
    {
        public void TurnOn()
        {
            Console.WriteLine("The light is on with callback");
        }

        public void TurnOff()
        {
            Console.WriteLine("The light is off with callback");
        }
    }
}
