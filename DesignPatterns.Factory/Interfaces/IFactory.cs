namespace DesignPatterns.Factory.Interfaces
{
    public interface IFactory
    {
        IEntity CreateEntityA();
        IEntity CreateEntityB();
        IEntity CreateEntityC();
    }
}