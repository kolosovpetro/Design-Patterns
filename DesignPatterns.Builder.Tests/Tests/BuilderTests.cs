using DesignPatterns.Builder.Builders;
using DesignPatterns.Builder.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Builder.Tests.Tests
{
    [TestFixture]
    public class BuilderTests
    {
        [Test]
        public void Builder_Test()
        {
            IBuilder builder = new BmwBuilder();
            var car = builder.Build();
            car.Brand.Should().Be("BMW");
            car.Color.Should().Be("Black");
            car.Model.Should().Be("M3");
            car.Price.Should().Be(1000);
            car.EngineVolume.Should().Be(3);
            car.NumberOfSeats.Should().Be(4);
            car.NumberOfWheels.Should().Be(4);
        }
    }
}