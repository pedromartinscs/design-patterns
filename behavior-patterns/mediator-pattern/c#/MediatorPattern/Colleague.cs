
// Abstract Colleague
public abstract class Colleague
{
    protected IMediator _mediator;

    public Colleague(IMediator mediator)
    {
        _mediator = mediator;
    }

    public abstract void Receive(string message);
    public void Send(string message)
    {
        _mediator.SendMessage(message, this);
    }
}
