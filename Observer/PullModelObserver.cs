using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IPullObserver
    {
        void Update();
    }

    public class PullSubject
    {
        private List<IPullObserver> _observers = new List<IPullObserver>();
        private string _state;

        public void Attach(IPullObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IPullObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }

        public string GetState()
        {
            return _state;
        }

        public void SetState(string newState)
        {
            _state = newState;
            Notify();
        }
    }

    public class PullObserver : IPullObserver
    {
        private PullSubject _subject;

        public PullObserver(PullSubject subject)
        {
            _subject = subject;
        }

        public void Update()
        {
            Console.WriteLine($"Observer received state: {_subject.GetState()}");
        }
    }

}
