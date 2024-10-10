using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public interface IMediator
    {
        void Notify(object sender, string eventCode);
    }

    public class BasicMediator : IMediator
    {
        private readonly ComponentA _componentA;
        private readonly ComponentB _componentB;

        public BasicMediator(ComponentA componentA, ComponentB componentB)
        {
            _componentA = componentA;
            _componentA.SetMediator(this);
            _componentB = componentB;
            _componentB.SetMediator(this);
        }

        public void Notify(object sender, string eventCode)
        {
            if (eventCode == "A")
            {
                Console.WriteLine("Mediator reacts to event A and triggers the following operations:");
                //_componentB.DoB();
            }
            else if (eventCode == "B")
            {
                Console.WriteLine("Mediator reacts to event B and triggers the following operations:");
                //_componentA.DoA();
            }
        }
    }

    public class BaseComponent
    {
        protected IMediator _mediator;

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        public virtual void ReceiveNotification(string eventCode)
        {
            // Provide default implementation if necessary
            Console.WriteLine($"{this.GetType().Name} received notification about {eventCode}");
        }
    }

    public class ComponentA : BaseComponent
    {
        public void DoA()
        {
            Console.WriteLine("Component A does A.");
            _mediator.Notify(this, "A");
        }
    }

    public class ComponentB : BaseComponent
    {
        public void DoB()
        {
            Console.WriteLine("Component B does B.");
            _mediator.Notify(this, "B");
        }
    }

}
