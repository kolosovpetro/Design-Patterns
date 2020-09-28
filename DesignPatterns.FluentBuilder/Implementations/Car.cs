using DesignPatterns.FluentBuilder.Interfaces;

namespace DesignPatterns.FluentBuilder.Implementations
{
    public class Car : ICar
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int EngineVolume { get; set; }
        public int YearProduced { get; set; }

        public override string ToString()
        {
            return $"{Brand} - {Model} - Volume: {EngineVolume} - Year: {YearProduced}";
        }
    }
}