using DesignPatterns.State.Entities;
using DesignPatterns.State.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.State.Tests.Tests
{
    [TestFixture]
    public class StateTest
    {
        [Test]
        public void State_Test()
        {
            IContext water = new WaterEntity();
            water.StateDescription.Should().Be("Water is in Ice state");
            water.ChangeState();
            water.StateDescription.Should().Be("Water is in Liquid State");
            water.ChangeState();
            water.StateDescription.Should().Be("Water is in Steam State");
            water.ChangeState();
            water.StateDescription.Should().Be("Water is in Ice state");
        }
    }
}