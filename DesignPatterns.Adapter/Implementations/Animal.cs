using DesignPatterns.Adapter.Interfaces;

namespace DesignPatterns.Adapter.Implementations
{
    public class Animal : IAnimal
    {
        public string Ride()
        {
            return "Driver rides on animal.";
        }
    }
}