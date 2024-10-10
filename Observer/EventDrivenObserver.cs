using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class EventDrivenSubject
    {
        public event Action<string> OnStateChanged;

        private string _state;

        public void SetState(string newState)
        {
            _state = newState;
            OnStateChanged?.Invoke(_state);
        }
    }

    public class EventObserver
    {
        private string _name;

        public EventObserver(string name, EventDrivenSubject subject)
        {
            _name = name;
            subject.OnStateChanged += Update;
        }

        public void Update(string state)
        {
            Console.WriteLine($"{_name} received event with state: {state}");
        }
    }

}
