using DesignPatterns.Builder.Interfaces;

namespace DesignPatterns.Builder.Director
{
    public class Director : IDirector
    {
        private readonly IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.SetBrand();
            _builder.SetColor();
            _builder.SetModel();
            _builder.SetPrice();
            _builder.SetSeats();
            _builder.SetWheels();
            _builder.SetEngineVolume();
        }
    }
}