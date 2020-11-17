using DesignPatterns.Adapter.Implementations;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Adapter.Tests.Tests
{
    [TestFixture]
    public class AdapterTests
    {
        [Test]
        public void Adapter_Test()
        {
            var animal = new Animal();
            var adapted = new Adapted(animal);
            var driver = new Driver(adapted);
            driver.Drive().Should().Be("Driver rides on animal.");
        }
    }
}