
// Concrete Colleague 2
public class ConcreteColleague2 : Colleague
{
    public ConcreteColleague2(IMediator mediator) : base(mediator) { }

    public override void Receive(string message)
    {
        Console.WriteLine("Colleague2 received: " + message);
    }
}
