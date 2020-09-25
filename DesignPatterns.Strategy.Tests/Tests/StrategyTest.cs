using DesignPatterns.Strategy.Entities;
using DesignPatterns.Strategy.Interfaces;
using DesignPatterns.Strategy.Strategies;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Strategy.Tests.Tests
{
    [TestFixture]
    public class StrategyTest
    {
        [Test]
        public void Strategy_Test()
        {
            IStrategyEntity entity = new Entity();
            entity.SetStrategy(new StrategyA());
            entity.Execute().Should().Be("Invoked on behalf of Strategy A");
            entity.SetStrategy(new StrategyB());
            entity.Execute().Should().Be("Invoked on behalf of Strategy B");
            entity.SetStrategy(new StrategyC());
            entity.Execute().Should().Be("Invoked on behalf of Strategy C");
        }
    }
}