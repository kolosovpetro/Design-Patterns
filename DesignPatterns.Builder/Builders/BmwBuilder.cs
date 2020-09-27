using DesignPatterns.Builder.Cars;
using DesignPatterns.Builder.Interfaces;

namespace DesignPatterns.Builder.Builders
{
    public class BmwBuilder : IBuilder
    {
        private readonly ICar _car = new Car();

        public void SetBrand() => _car.Brand = "BMW";

        public void SetModel() => _car.Model = "M3";

        public void SetColor() => _car.Color = "Black";

        public void SetWheels() => _car.NumberOfWheels = 4;

        public void SetSeats() => _car.NumberOfSeats = 4;

        public void SetEngineVolume() => _car.EngineVolume = 3;

        public void SetPrice() => _car.Price = 1000;

        public ICar ReturnCar() => _car;
    }
}