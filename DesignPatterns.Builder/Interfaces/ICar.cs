namespace DesignPatterns.Builder.Interfaces
{
    public interface ICar
    {
        string Brand { get; set; }
        string Model { get; set; }
        string Color { get; set; }
        int NumberOfWheels { get; set; }
        int NumberOfSeats { get; set; }
        int EngineVolume { get; set; }
        int Price { get; set; }
    }
}