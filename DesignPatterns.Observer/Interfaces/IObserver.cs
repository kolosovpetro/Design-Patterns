namespace DesignPatterns.Observer.Interfaces
{
    public interface IObserver
    {
        string LastNotification { get; }
        void Update();
    }
}