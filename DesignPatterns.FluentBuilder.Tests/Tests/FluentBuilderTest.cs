using DesignPatterns.FluentBuilder.Implementations;
using DesignPatterns.FluentBuilder.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.FluentBuilder.Tests.Tests
{
    [TestFixture]
    public class FluentBuilderTest
    {
        [Test]
        public void Fluent_Builder_Test()
        {
            IFluentBuilder builder = new Implementations.FluentBuilder();
            IDirector director = new Director(builder);
            director.Construct();
            var car = builder.ReturnCar();
            car.Brand.Should().Be("BMW");
            car.Model.Should().Be("M3");
            car.EngineVolume.Should().Be(3);
            car.YearProduced.Should().Be(2017);
        }
    }
}