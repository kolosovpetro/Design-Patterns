using DesignPatterns.Memento.Implementations;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Memento.Tests.Tests
{
    [TestFixture]
    public class MementoTests
    {
        [Test]
        public void Memento_Test()
        {
            var gun = new Gun(10);
            gun.Shot();
            gun.Shot();
            gun.AmmoCount.Should().Be(8);
            gun.SaveState();
            gun.Shot();
            gun.Shot();
            gun.Shot();
            gun.AmmoCount.Should().Be(5);
            gun.LoadState();
            gun.AmmoCount.Should().Be(8);
        }
    }
}