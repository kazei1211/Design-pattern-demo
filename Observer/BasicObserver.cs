using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IObserver
    {
        void Update(string message);
    }

    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

    public class BasicSubject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private string _state;

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
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

        public void ChangeState(string newState)
        {
            _state = newState;
            Notify();
        }
    }

    public class BasicObserver : IObserver
    {
        private string _name;

        public BasicObserver(string name)
        {
            _name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{_name} received update: {message}");
        }
    }

}
