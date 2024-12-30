
// Concrete Colleague 1
public class ConcreteColleague1 : Colleague
{
    public ConcreteColleague1(IMediator mediator) : base(mediator) { }

    public override void Receive(string message)
    {
        Console.WriteLine("Colleague1 received: " + message);
    }
}
