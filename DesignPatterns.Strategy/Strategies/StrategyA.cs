using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Strategies
{
    public class StrategyA : IStrategy
    {
        public string Execute() => "Invoked on behalf of Strategy A";
    }
}