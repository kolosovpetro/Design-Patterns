using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Observer.Interfaces;

namespace DesignPatterns.Observer.Implementations
{
    public class Observer : IObserver
    {
        private readonly List<string> _notifications = new List<string>();
        private int _count;

        public string LastNotification => _notifications.Last();

        public void Update()
        {
            _notifications.Add($"Notification {_count}");
            _count++;
        }
    }
}