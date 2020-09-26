using DesignPatterns.Observer.Implementations;
using DesignPatterns.Observer.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Observer.Tests.Tests
{
    [TestFixture]
    public class ObserverTests
    {
        [Test]
        public void Observer_Test()
        {
            IObserver observer = new Implementations.Observer();
            IObservable observable = new Observable();
            observable.AddObserver(observer);
            observable.NotifyObservers();
            observer.LastNotification.Should().Be("Notification 0");
            observable.NotifyObservers();
            observer.LastNotification.Should().Be("Notification 1");
        }
    }
}