using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Strategies
{
    public class StrategyC : IStrategy
    {
        public string Execute() => "Invoked on behalf of Strategy C";
    }
}