using DesignPatterns.Adapter.Interfaces;

namespace DesignPatterns.Adapter.Implementations
{
    public class Car : ICar
    {
        public string Ride()
        {
            return "Driver drives car";
        }
    }
}