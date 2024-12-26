using StatePattern.Implementations;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initial state is ConcreteStateA
            Context context = new Context(new ConcreteStateA());

            // Request transitions between states
            context.Request();  // State A handling request
            context.Request();  // State A handling request again
            context.ChangeState(new ConcreteStateB());  // State changed to ConcreteStateB
            context.Request();  // State B handling request
            context.ChangeState(new ConcreteStateA());  // State changed to ConcreteStateA
            context.Request();  // State A handling request
            context.ChangeState(new ConcreteStateB());  // State changed to ConcreteStateB
            context.Request();  // State B handling request
            context.Request();  // State B handling request again
        }
    }
}