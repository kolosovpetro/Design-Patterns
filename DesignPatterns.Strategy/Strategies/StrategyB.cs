using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Strategies
{
    public class StrategyB : IStrategy
    {
        public string Execute() => "Invoked on behalf of Strategy B";
    }
}