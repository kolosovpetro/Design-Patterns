using DesignPatterns.Prototype.Concrete;
using DesignPatterns.Prototype.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Prototype.Tests.Tests
{
    [TestFixture]
    public class PrototypeTest
    {
        [Test]
        public void Prototype_Clone_Test()
        {
            IEntity entity = new Entity("John", "Dow", 12);
            var clone = entity.Clone();
            clone.Name.Should().Be(entity.Name);
            clone.Age.Should().Be(entity.Age);
            clone.Id.Should().Be(entity.Id);
            ReferenceEquals(clone, entity).Should().BeFalse();
        }
    }
}