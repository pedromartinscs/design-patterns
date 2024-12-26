using StatePattern.interfaces;

namespace StatePattern.Implementations
{
    public class ConcreteStateB : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("State B handling request.");
        }
    }
}