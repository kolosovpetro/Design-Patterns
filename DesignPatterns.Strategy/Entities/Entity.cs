using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Entities
{
    public class Entity : IStrategyEntity
    {
        private IStrategy _strategy;
        
        public void SetStrategy(IStrategy strategy) => _strategy = strategy;

        public string Execute() => _strategy.Execute();
    }
}