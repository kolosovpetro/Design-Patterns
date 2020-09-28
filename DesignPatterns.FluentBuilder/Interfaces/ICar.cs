namespace DesignPatterns.FluentBuilder.Interfaces
{
    public interface ICar
    {
        string Brand { get; set; }
        string Model { get; set; }
        int EngineVolume { get; set; }
        int YearProduced { get; set; }
    }
}