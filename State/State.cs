using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public interface IState
    {
        void Handle(Context context);
    }

    public class ConcreteStateA : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("State A handling request.");
            context.SetState(new ConcreteStateB());
        }
    }

    public class ConcreteStateB : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("State B handling request.");
            context.SetState(new ConcreteStateA());
        }
    }

}
