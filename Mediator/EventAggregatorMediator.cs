using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class EventAggregator
    {
        private readonly Dictionary<string, Action> _events = new Dictionary<string, Action>();

        public void Register(string eventCode, Action action)
        {
            _events[eventCode] = action;
        }

        public void Publish(string eventCode)
        {
            if (_events.ContainsKey(eventCode))
            {
                _events[eventCode].Invoke();
            }
        }
    }

    public class EventComponentA
    {
        private readonly EventAggregator _eventAggregator;

        public EventComponentA(EventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.Register("A", DoA);
        }

        public void DoA()
        {
            Console.WriteLine("Event Component A does A.");
        }
    }

    public class EventComponentB
    {
        private readonly EventAggregator _eventAggregator;

        public EventComponentB(EventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.Register("B", DoB);
        }

        public void DoB()
        {
            Console.WriteLine("Event Component B does B.");
        }
    }

}
