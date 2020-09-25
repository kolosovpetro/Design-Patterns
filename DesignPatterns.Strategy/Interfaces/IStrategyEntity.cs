namespace DesignPatterns.Strategy.Interfaces
{
    public interface IStrategyEntity
    {
        void SetStrategy(IStrategy strategy);
        string Execute();
    }
}