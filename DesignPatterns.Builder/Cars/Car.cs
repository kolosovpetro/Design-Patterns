using DesignPatterns.Builder.Interfaces;

namespace DesignPatterns.Builder.Cars
{
    public class Car : ICar
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfSeats { get; set; }
        public int EngineVolume { get; set; }
        public int Price { get; set; }
    }
}