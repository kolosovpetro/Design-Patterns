using DesignPatterns.Factory.Concrete;
using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Factory
{
    public class Factory : IFactory
    {
        public IEntity CreateEntityA() => new EntityA();
        public IEntity CreateEntityB() => new EntityB();
        public IEntity CreateEntityC() => new EntityC();
    }
}