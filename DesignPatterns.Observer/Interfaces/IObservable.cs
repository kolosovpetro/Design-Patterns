namespace DesignPatterns.Observer.Interfaces
{
    public interface IObservable
    {
        void AddObserver(IObserver observer);
        void NotifyObservers();
        void RemoveObserver(IObserver observer);
    }
}