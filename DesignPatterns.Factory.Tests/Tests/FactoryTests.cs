using DesignPatterns.Factory.Concrete;
using DesignPatterns.Factory.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Factory.Tests.Tests
{
    [TestFixture]
    public class FactoryTests
    {
        [Test]
        public void Create_Entity_A_Test()
        {
            IFactory factory = new Factory.Factory();
            var entityA = factory.CreateEntityA();
            var ofTypeA = entityA is EntityA;
            ofTypeA.Should().BeTrue();
        }
        
        [Test]
        public void Create_Entity_B_Test()
        {
            IFactory factory = new Factory.Factory();
            var entityB = factory.CreateEntityB();
            var ofTypeB = entityB is EntityB;
            ofTypeB.Should().BeTrue();
        }
        
        [Test]
        public void Create_Entity_C_Test()
        {
            IFactory factory = new Factory.Factory();
            var entityC = factory.CreateEntityC();
            var ofTypeC = entityC is EntityC;
            ofTypeC.Should().BeTrue();
        }
    }
}