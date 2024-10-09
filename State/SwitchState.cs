using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class SwitchContext
    {
        public string State { get; private set; }

        public SwitchContext(string initialState)
        {
            State = initialState;
        }

        public void Request()
        {
            switch (State)
            {
                case "StateA":
                    Console.WriteLine("State A handling request.");
                    State = "StateB";
                    break;
                case "StateB":
                    Console.WriteLine("State B handling request.");
                    State = "StateA";
                    break;
            }
        }
    }

}
