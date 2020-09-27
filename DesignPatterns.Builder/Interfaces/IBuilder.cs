namespace DesignPatterns.Builder.Interfaces
{
    public interface IBuilder
    {
        void SetBrand();
        void SetModel();
        void SetColor();
        void SetWheels();
        void SetSeats();
        void SetEngineVolume();
        void SetPrice();
        ICar ReturnCar();
    }
}