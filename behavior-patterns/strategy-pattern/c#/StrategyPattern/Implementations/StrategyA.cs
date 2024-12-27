using StrategyPattern.Interfaces;

namespace StrategyPattern.Implementations
{
    // Strategy A
    public class StrategyA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Strategy A executed.");
        }
    }
}