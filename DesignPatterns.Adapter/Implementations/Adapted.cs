using DesignPatterns.Adapter.Interfaces;

namespace DesignPatterns.Adapter.Implementations
{
    public class Adapted: IAdapted
    {
        private readonly IAnimal _animal;

        public Adapted(IAnimal animal)
        {
            _animal = animal;
        }

        public string Ride()
        {
            return _animal.Ride();
        }
    }
}