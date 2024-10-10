using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class WeakReferenceSubject
    {
        private List<WeakReference<IWeakObserver>> _observers = new List<WeakReference<IWeakObserver>>();

        public void Attach(IWeakObserver observer)
        {
            _observers.Add(new WeakReference<IWeakObserver>(observer));
        }

        public void Detach(IWeakObserver observer)
        {
            _observers.RemoveAll(wr => wr.TryGetTarget(out var o) && o == observer);
        }

        public void Notify(string state)
        {
            foreach (var weakReference in _observers)
            {
                if (weakReference.TryGetTarget(out var observer))
                {
                    observer.Update(state);
                }
            }
        }
    }

    public interface IWeakObserver
    {
        void Update(string state);
    }

    public class WeakObserver : IWeakObserver
    {
        private string _name;

        public WeakObserver(string name)
        {
            _name = name;
        }

        public void Update(string state)
        {
            Console.WriteLine($"{_name} received weakly referenced state: {state}");
        }
    }

}
