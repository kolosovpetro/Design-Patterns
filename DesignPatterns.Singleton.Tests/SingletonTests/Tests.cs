using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Singleton.Tests.SingletonTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Singleton_Test()
        {
            var instance1 = Concrete.Singleton.GetInstance;
            var instance2 = Concrete.Singleton.GetInstance;
            instance1.TimeCreated.Should().Be(instance2.TimeCreated);
            ReferenceEquals(instance1, instance2).Should().BeTrue();
        }
    }
}