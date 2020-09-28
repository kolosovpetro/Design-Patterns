using DesignPatterns.FluentBuilder.Interfaces;

namespace DesignPatterns.FluentBuilder.Implementations
{
    public class Director : IDirector
    {
        private readonly IFluentBuilder _builder;

        public Director(IFluentBuilder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.SetBrand("BMW")
                .SetModel("M3")
                .SetEngineVolume(3)
                .SetYearProduced(2017);
        }
    }
}