using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class DynamicMediator : IMediator
    {
        private readonly List<BaseComponent> _components = new List<BaseComponent>();

        public void Register(BaseComponent component)
        {
            _components.Add(component);
            component.SetMediator(this);
        }

        public void Notify(object sender, string eventCode)
        {
            foreach (var component in _components)
            {
                if (component != sender)
                {
                    component.ReceiveNotification(eventCode);
                }
            }
        }
    }

    public class DynamicComponent : BaseComponent
    {
        public string Name { get; set; }

        public void DoSomething()
        {
            Console.WriteLine($"{Name} is doing something.");
            _mediator.Notify(this, Name);
        }

        public override void ReceiveNotification(string eventCode)
        {
            Console.WriteLine($"{Name} received notification about {eventCode}");
        }
    }
}
