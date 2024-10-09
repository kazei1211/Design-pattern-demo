using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public enum StateType
    {
        StateA,
        StateB
    }

    public class EnumContext
    {
        public StateType State { get; private set; }

        public EnumContext(StateType initialState)
        {
            State = initialState;
        }

        public void Request()
        {
            if (State == StateType.StateA)
            {
                Console.WriteLine("State A handling request.");
                State = StateType.StateB;
            }
            else if (State == StateType.StateB)
            {
                Console.WriteLine("State B handling request.");
                State = StateType.StateA;
            }
        }
    }

}
