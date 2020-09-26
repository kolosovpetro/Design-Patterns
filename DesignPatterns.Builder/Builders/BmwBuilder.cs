using DesignPatterns.Builder.Cars;
using DesignPatterns.Builder.Interfaces;

namespace DesignPatterns.Builder.Builders
{
    public class BmwBuilder : IBuilder
    {
        private readonly ICar _car = new Car();

        public ICar Build()
        {
            _car.Brand = "BMW";
            _car.Color = "Black";
            _car.Model = "M3";
            _car.EngineVolume = 3;
            _car.NumberOfSeats = 4;
            _car.NumberOfWheels = 4;
            _car.Price = 1000;
            return _car;
        }
    }
}