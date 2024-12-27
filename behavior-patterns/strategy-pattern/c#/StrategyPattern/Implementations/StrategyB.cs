using StrategyPattern.Interfaces;

namespace StrategyPattern.Implementations
{
    // Strategy B
    public class StrategyB : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Strategy B executed.");
        }
    }
}