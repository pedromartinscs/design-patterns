using StatePattern.interfaces;

namespace StatePattern.Implementations
{
    // Concrete States
    public class ConcreteStateA : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("State A handling request.");
        }
    }
}