using System;
using StrategyPattern.Implementations;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context;

            // Using strategy A
            context = new Context(new StrategyA());
            context.ExecuteStrategy();

            // Using strategy B
            context.SetStrategy(new StrategyB());
            context.ExecuteStrategy();
        }
    }
}