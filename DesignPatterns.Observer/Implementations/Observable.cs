using System.Collections.Generic;
using DesignPatterns.Observer.Interfaces;

namespace DesignPatterns.Observer.Implementations
{
    public class Observable : IObservable
    {
        private readonly List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer) => _observers.Add(observer);
        
        public void NotifyObservers() => _observers.ForEach(x => x.Update());

        public void RemoveObserver(IObserver observer)
        {
            if (_observers.Contains(observer)) 
                _observers.Remove(observer);
        }
    }
}