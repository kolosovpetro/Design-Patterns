namespace DesignPatterns.FluentBuilder.Interfaces
{
    public interface IFluentBuilder
    {
        IFluentBuilder SetBrand(string brand);
        IFluentBuilder SetModel(string model);
        IFluentBuilder SetEngineVolume(int volume);
        IFluentBuilder SetYearProduced(int year);
        ICar ReturnCar();
    }
}