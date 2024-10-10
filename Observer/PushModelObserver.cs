using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IPushObserver
    {
        void Update(string data);
    }

    public class PushSubject
    {
        private List<IPushObserver> _observers = new List<IPushObserver>();
        private string _state;

        public void Attach(IPushObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IPushObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_state);
            }
        }

        public void SetState(string newState)
        {
            _state = newState;
            Notify();
        }
    }

    public class PushObserver : IPushObserver
    {
        private string _name;

        public PushObserver(string name)
        {
            _name = name;
        }

        public void Update(string data)
        {
            Console.WriteLine($"{_name} received pushed data: {data}");
        }
    }

}
