using DesignPatterns.Adapter.Interfaces;

namespace DesignPatterns.Adapter.Implementations
{
    public class Driver : IDriver
    {
        private readonly ICar _car;

        public Driver(ICar car)
        {
            _car = car;
        }

        public string Drive()
        {
            return _car.Ride();
        }
    }
}