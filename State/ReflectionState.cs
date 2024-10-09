using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class ReflectionContext
    {
        private string _state;

        public ReflectionContext(string initialState)
        {
            _state = initialState;
        }

        public void Request()
        {
            var method = GetType().GetMethod(_state);
            method.Invoke(this, null);
        }

        public void StateA()
        {
            Console.WriteLine("State A handling request.");
            _state = "StateB";
        }

        public void StateB()
        {
            Console.WriteLine("State B handling request.");
            _state = "StateA";
        }
    }
}
